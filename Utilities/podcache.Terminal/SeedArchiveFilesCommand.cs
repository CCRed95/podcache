using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Ccr.Colorization.Mappings;
using Ccr.Scraping.API.Web;
using Ccr.Std.Core.Extensions;
using InternetArchive.API;
using InternetArchive.API.Domain.Enums;
using InternetArchive.API.Domain.Fields;
using InternetArchive.API.Domain.Sorting;
using InternetArchive.API.Extensions;
using InternetArchive.API.Query;
using podcache.Data.Context;
using podcache.Data.Domain;
using static Ccr.Terminal.ExtendedConsole;


namespace podcache.Terminal
{
	public class SeedArchiveFilesCommand
		: TerminalCommand<string>
	{
		public override string CommandName => "seed-archivefiles";

		public override string ShortCommandName => "seed-archives";


		public override void Execute(string arg)
		{
			XConsole.WriteLine($"Seeding archive.org database shows to ArchiveFiles table.", Swatch.Cyan);

			using var context = new CoreContext();

			XConsole.WriteLine($"  Querying Opie and Anthony shows...", Swatch.Cyan);

			var archiveApi = new InternetArchiveAPI();

			var queryBuilder = IAQueryBuilder
				.Builder
				.WithUploader("opieandanthonylive@gmail.com")
				.FromCreator("Opie and Anthony")
				.WithSort(
					IAQueryFields.Title,
					IASortDirection.Ascending)
				.WithFields(
					IAQueryFields.Creator,
					IAQueryFields.Date,
					IAQueryFields.Identifier,
					IAQueryFields.Title)
				.WithRows(10000)
				.WithOutputKind(APIDataOutputKind.JSON)
				.WithCallback("callback")
				.WithShouldSave(true);


			var regex = new Regex(
				$"O&A-(?<year>[0-9]*)-(?<month>[0-9]*)");

			var fullShowRegex = new Regex(
				$"O&A-(?<year>[0-9]*)-(?<month>[0-9]*)-(?<day>[0-9]*)");


			foreach (var archiveItem in archiveApi.Query(queryBuilder))
			{
				var match = regex.Match(archiveItem.Title);

				var monthStr = match.Groups["month"]
					.Value;
				var yearStr = match.Groups["year"]
					.Value;

				var month = int.Parse(monthStr);
				var year = int.Parse(yearStr);

				var archiveAlbum = new ArchiveAlbum(
					archiveItem.Identifier,
					ContentCreator.Opie_and_Anthony,
					archiveItem.Description,
					archiveItem.UploadDate,
					year,
					month);

				context.ArchiveAlbums.Add(archiveAlbum);

				XConsole.WriteLine(
					$"Item: {archiveItem.Identifier} - {archiveItem.Title}", Swatch.Teal);

				foreach (var file in archiveItem.GetItemFiles())
				{
					//if (file.FileName.EndsWith(".torrent"))
					//{
					//	var decodedTorrentFileName = file.FileName.UrlDecode();
					//	var targetTorrentUrl =
					//		$"https://archive.org/download/{archiveItem.Identifier}/{decodedTorrentFileName}";

					//	Console.WriteLine($"Complete.");
					//}

					if (!file.FileName.EndsWith(".mp3"))
						continue;

					var decodedFileName = file.FileName.UrlDecode();

					var fullShowMatch = fullShowRegex.Match(decodedFileName);

					var fullShowYearStr = fullShowMatch.Groups["year"]
						.Value;
					var fullShowMonthStr = fullShowMatch.Groups["month"]
						.Value;
					var fullShowDayStr = fullShowMatch.Groups["day"]
						.Value;

					if (!int.TryParse(fullShowYearStr, out var fullShowYear))
					{
						XConsole.WriteLine(
							$"\t\tERROR: Cannot parse year int from string {fullShowYearStr.Quote()} " +
							$"for input {decodedFileName.Quote()}", Swatch.Red);

						continue;
					}

					if (!int.TryParse(fullShowMonthStr, out var fullShowMonth))
					{
						XConsole.WriteLine(
							$"\t\tERROR: Cannot parse month int from string {fullShowMonthStr.Quote()} " +
							$"for input {decodedFileName.Quote()}", Swatch.Red);

						continue;
					}

					if (!int.TryParse(fullShowDayStr, out var fullShowDay))
					{
						XConsole.WriteLine(
							$"\t\tERROR: Cannot parse day int from string {fullShowDayStr.Quote()} " +
							$"for input {decodedFileName.Quote()}", Swatch.Red);

						continue;
					}

					DateTime showAirDate;

					try
					{
						showAirDate = new DateTime(
							fullShowYear,
							fullShowMonth,
							fullShowDay);
					}
					catch
					{
						XConsole.WriteLine(
							$"\t\tERROR: {fullShowYear}-{fullShowMonth}-{fullShowDay} does not represent a valid " +
							$"DateTime. Defaulting to DateTime.MinValue", Swatch.Red);

						showAirDate = DateTime.MinValue;
					}

					var targetUrl =
						$"https://archive.org/download/{archiveItem.Identifier}/{decodedFileName}";

					context.ArchiveFiles.Add(
						new ArchiveFile(
							file.FileName,
							ArchiveFileTypeInfo.MP3,
							Show.OpieAndAnthonyShow,
							archiveAlbum,
							archiveItem.Identifier,
							targetUrl,
							showAirDate,
							archiveItem.Title,
							archiveItem.UploadDate,
							-1));

					XConsole
						.Write($"Adding file: ", Swatch.Cyan)
						.WriteLine($"{targetUrl}", Swatch.Pink);
				}
			}

			XConsole
				.Write($"Saving to database...", Swatch.Cyan);

			context.SaveChanges();

			XConsole
				.WriteLine($"Complete", Swatch.Teal);
		}
	}

}
