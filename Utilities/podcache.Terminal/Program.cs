namespace podcache.Terminal
{
	public class Program
	{
		public static void Main(
			string[] args)
		{
			var terminalApplication = new PodcacheTerminalApplication(args);
			terminalApplication.Start();
		}
	}
}


//public static void Main(
//	string[] args)
//{
//	XConsole
//		.AddUnderline()
//		.SetBold()
//		.WriteLine("podcache terminal - version 1.0.0.0", Swatch.Pink)
//		.RemoveUnderline()
//		.SetNormalIntensity()
//		.WriteLine()
//		.WriteLine();

//	var hasQuit = false;

//	while (!hasQuit)
//	{
//		XConsole
//			.Write("enter command: ", Swatch.Teal)
//			.Write("", Swatch.Cyan);

//		var c = XConsole.ReadLine();
//		XConsole.WriteLine();

//		if (c == "database-init")
//		{
//			try
//			{
//				DatabaseCommands.ConstructDB();
//			}
//			catch (Exception ex)
//			{
//				XConsole
//					.AddUnderline()
//					.SetBold()
//					.WriteLine("  EXCEPTION THROWN  ", Swatch.Red)
//					.RemoveUnderline()
//					.SetNormalIntensity();

//				XConsole
//					.WriteLine(ex.ToString(), Swatch.DeepOrange)
//					.WriteLine()
//					.WriteLine();

//				XConsole
//					.WriteLine("command completed, with errors.", Swatch.Red)
//					.WriteLine();
//			}
//		}
//		else if (c == "scrape-csv")
//		{
//			try
//			{
//				DatabaseCommands.ScrapeCSVs(
//					new DirectoryInfo(@"C:\Users\Eric\Desktop\csv\"));
//			}
//			catch (Exception ex)
//			{
//				Console.WriteLine("EXCEPTION THROWN");
//				Console.WriteLine(ex);
//				Console.WriteLine("Command completed, with errors.");
//			}
//		}
//		else if (c == "archive-ms")
//		{
//			Console.WriteLine("Archiving Matt and Shane Podcast...");

//			var libsynAPI = new LibsynAPI();

//			var queryBuilder = new LibsynQueryBuilder()
//				.WithAuthor("mattandshanessecret");

//			foreach (var libsynResult in libsynAPI.Query(queryBuilder))
//			{

//			}

//		}
//		else if (c == "transform-docstyle")
//		{
//			try
//			{
//				DatabaseCommands.ScrapeCSVs(
//					new DirectoryInfo(@"C:\Users\Eric\Desktop\csv\"));
//			}
//			catch (Exception ex)
//			{
//				Console.WriteLine("EXCEPTION THROWN");
//				Console.WriteLine(ex);
//				Console.WriteLine("Command completed, with errors.");
//			}
//		}
//		else if (c == "archive-rf")
//		{
//			using (var context = new CoreContext())
//			{
//				var archiveAPI = new InternetArchiveAPI();

//				var queryBuilder = new IAQueryBuilder()
//					.WithUploader("opieandanthonylive")
//					.WithSubject("Ron and Fez")
//					.WithFields(
//						Creator,
//						Date,
//						Description,
//						Identifier,
//						MediaType,
//						Title,
//						Collection,
//						Language,
//						Contributor)
//					.WithSort(
//						Title,
//						IASortDirection.Ascending)
//					.WithRows(5000)
//					.WithOutputKind(APIDataOutputKind.JSON)
//					.WithCallback("callback")
//					.WithShouldSave(true);

//				var archiveAlbums = archiveAPI
//					.Query(queryBuilder);

//				//var albumIndex = 0;

//				foreach (var archiveAlbum in archiveAlbums)
//				{
//					ExtendedConsole.XConsole.WriteIAItem(archiveAlbum);


//					//archiveAlbum

//					//Console.WriteLine($"- Album #{albumIndex}");

//					//archiveAlbum.ContentCreatorID = 2;

//					//Console.WriteLine($"  Identifier:             {archiveAlbum.Identifier.Quote()}");
//					//Console.WriteLine($"  AlbumFileContentsUrl:   {archiveAlbum.AlbumFileContentsUrl.Quote()}");
//					//Console.WriteLine($"  ContentCreatorID:				{archiveAlbum.ContentCreatorID}");
//					//Console.WriteLine($"  DatePublished:          {archiveAlbum.DatePublished:g}");
//					//Console.WriteLine($"  Description:            {archiveAlbum.Description.Quote()}");
//					//Console.WriteLine($"  ArchiveFiles:           {archiveAlbum.ArchiveFiles.Count}");
//					//Console.WriteLine();

//					//int count = 0;

//					//foreach (var archiveFile in archiveAlbum.ArchiveFiles)
//					//{
//					//	Console.WriteLine($"  - File #{count}");
//					//	Console.WriteLine($"    FileName:               {archiveFile.FileName.Quote()}");
//					//	Console.WriteLine($"    ArchiveFileType Ext:    {archiveFile.ArchiveFileTypeInfo?.Extension.SQuote()}");
//					//	Console.WriteLine($"    ShowName:               {archiveFile.Show?.ShowName.SQuote()}");
//					//	Console.WriteLine($"    Identifier:             {archiveFile.Identifier.Quote()}");
//					//	Console.WriteLine($"    FilePathUrl:            {archiveFile.FilePathUrl.Quote()}");
//					//	Console.WriteLine($"    AirDate:                {archiveFile.AirDate:d}");
//					//	Console.WriteLine($"    Title:                  {archiveFile.Title.Quote()}");
//					//	Console.WriteLine($"    LastModifiedDate:       {archiveFile.LastModifiedDate:d}");
//					//	Console.WriteLine($"    ApproximateBytes:       {archiveFile.ApproximateBytes}");
//					//	Console.WriteLine();

//					//	context.ArchiveFiles.Add(archiveFile);
//					//	count++;
//					//}

//					//context.ArchiveAlbums.Add(archiveAlbum);

//					//context.SaveChanges();
//					//albumIndex++;

//					//Console.WriteLine("Saved.");
//				}
//			}
//		}
//		//else if (c == "archive-oa")
//		//{
//		//	using (var context = new CoreContext())
//		//	{
//		//		var archiveAPI = new InternetArchiveAPI();

//		//		var queryBuilder = new IAQueryBuilder()
//		//			.WithUploader("opieandanthonylive")
//		//			.WithSubject("Opie and Anthony")
//		//			.WithFields(
//		//				Creator,
//		//				Date,
//		//				Description,
//		//				Identifier,
//		//				MediaType,
//		//				Title)
//		//			.WithSort(
//		//				Title,
//		//				IASortDirection.Ascending)
//		//			.WithRows(5000)
//		//			.WithOutputKind(APIDataOutputKind.JSON)
//		//			.WithCallback("callback")
//		//			.WithShouldSave(true);

//		//		var iaItems = archiveAPI
//		//			.Query(queryBuilder);

//		//		var albumIndex = 0;

//		//		foreach (var iaItem in iaItems)
//		//		{
//		//			Console.WriteLine($"- Album #{albumIndex}");
//		//			XConsole
//		//				.BeginWriteTable("Identifier:", iaItem.Identifier.Quote())
//		//				.WriteRecord("AlbumFileContentsUrl:", iaItem.GetItemDownloadPageUrl());

//		//			//.Write("Identifier:", Swatch.Cyan)
//		//			//.WriteTable(t => t.WriteRecord())

//		//			Console.WriteLine($"  Identifier:             {archiveAlbum.Identifier.Quote()}");
//		//			Console.WriteLine($"  AlbumFileContentsUrl:   {archiveAlbum.AlbumFileContentsUrl.Quote()}");
//		//			Console.WriteLine($"  ContentCreatorID:				{archiveAlbum.ContentCreatorID}");
//		//			Console.WriteLine($"  DatePublished:          {archiveAlbum.DatePublished:g}");
//		//			Console.WriteLine($"  Description:            {archiveAlbum.Description.Quote()}");
//		//			Console.WriteLine($"  ArchiveFiles:           {archiveAlbum.ArchiveFiles.Count}");
//		//			Console.WriteLine();

//		//			int count = 0;

//		//			foreach (var archiveFile in archiveAlbum.ArchiveFiles)
//		//			{
//		//				Console.WriteLine($"  - File #{count}");
//		//				Console.WriteLine($"    FileName:               {archiveFile.FileName.Quote()}");
//		//				Console.WriteLine($"    ArchiveFileType Ext:    {archiveFile.ArchiveFileTypeInfo?.Extension.SQuote()}");
//		//				Console.WriteLine($"    ShowName:               {archiveFile.Show?.ShowName.SQuote()}");
//		//				Console.WriteLine($"    Identifier:             {archiveFile.Identifier.Quote()}");
//		//				Console.WriteLine($"    FilePathUrl:            {archiveFile.FilePathUrl.Quote()}");
//		//				Console.WriteLine($"    AirDate:                {archiveFile.AirDate:d}");
//		//				Console.WriteLine($"    Title:                  {archiveFile.Title.Quote()}");
//		//				Console.WriteLine($"    LastModifiedDate:       {archiveFile.LastModifiedDate:d}");
//		//				Console.WriteLine($"    ApproximateBytes:       {archiveFile.ApproximateBytes}");
//		//				Console.WriteLine();

//		//				context.ArchiveFiles.Add(archiveFile);
//		//				count++;
//		//			}

//		//			context.ArchiveAlbums.Add(archiveAlbum);

//		//			context.SaveChanges();
//		//			albumIndex++;

//		//			Console.WriteLine("Saved.");
//		//		}
//		//	}
//		//}
//		//else if (c == "archive-ct")
//		//{
//		//	using (var context = new CoreContext())
//		//	{
//		//		var archiveAPI = new InternetArchiveAPI();

//		//		var queryBuilder = new IAQueryBuilder()
//		//			.WithUploader("opieandanthonylive")
//		//			.WithSubject("Cumtown")
//		//			.WithFields(
//		//				Creator,
//		//				Date,
//		//				Description,
//		//				Identifier,
//		//				MediaType,
//		//				Title)
//		//			.WithSort(
//		//				Title,
//		//				IASortDirection.Ascending)
//		//			.WithRows(5000)
//		//			.WithOutputKind(APIDataOutputKind.JSON)
//		//			.WithCallback("callback")
//		//			.WithShouldSave(true);

//		//		var archiveAlbums = archiveAPI
//		//			.Query(queryBuilder);

//		//		var albumIndex = 0;

//		//		foreach (var archiveAlbum in archiveAlbums)
//		//		{
//		//			Console.WriteLine($"- Album #{albumIndex}");

//		//			archiveAlbum.ContentCreatorID = 4;

//		//			Console.WriteLine($"  Identifier:             {archiveAlbum.Identifier.Quote()}");
//		//			Console.WriteLine($"  AlbumFileContentsUrl:   {archiveAlbum.AlbumFileContentsUrl.Quote()}");
//		//			Console.WriteLine($"  ContentCreatorID:				{archiveAlbum.ContentCreatorID}");
//		//			Console.WriteLine($"  DatePublished:          {archiveAlbum.DatePublished:g}");
//		//			Console.WriteLine($"  Description:            {archiveAlbum.Description.Quote()}");
//		//			Console.WriteLine($"  ArchiveFiles:           {archiveAlbum.ArchiveFiles.Count}");
//		//			Console.WriteLine();

//		//			int count = 0;

//		//			foreach (var archiveFile in archiveAlbum.ArchiveFiles)
//		//			{
//		//				Console.WriteLine($"  - File #{count}");
//		//				Console.WriteLine($"    FileName:               {archiveFile.FileName.Quote()}");
//		//				Console.WriteLine($"    ArchiveFileType Ext:    {archiveFile.ArchiveFileTypeInfo?.Extension.SQuote()}");
//		//				Console.WriteLine($"    ShowName:               {archiveFile.Show?.ShowName.SQuote()}");
//		//				Console.WriteLine($"    Identifier:             {archiveFile.Identifier.Quote()}");
//		//				Console.WriteLine($"    FilePathUrl:            {archiveFile.FilePathUrl.Quote()}");
//		//				Console.WriteLine($"    AirDate:                {archiveFile.AirDate:d}");
//		//				Console.WriteLine($"    Title:                  {archiveFile.Title.Quote()}");
//		//				Console.WriteLine($"    LastModifiedDate:       {archiveFile.LastModifiedDate:d}");
//		//				Console.WriteLine($"    ApproximateBytes:       {archiveFile.ApproximateBytes}");
//		//				Console.WriteLine();

//		//				context.ArchiveFiles.Add(archiveFile);
//		//				count++;
//		//			}

//		//			context.ArchiveAlbums.Add(archiveAlbum);

//		//			context.SaveChanges();
//		//			albumIndex++;

//		//			Console.WriteLine("Saved.");
//		//		}
//		//	}
//		//}
//		else if (c == "excel")
//		{
//			try
//			{
//				DatabaseCommands.ScrapeExcel(
//					new DirectoryInfo(@"C:\Users\Eric\Desktop\csv\01\"));
//			}
//			catch (Exception ex)
//			{
//				Console.WriteLine("EXCEPTION THROWN");
//				Console.WriteLine(ex);
//				Console.WriteLine("Command completed, with errors.");
//			}
//		}
//		else if (c == "quit" || c == "exit")
//		{
//			Console.WriteLine($"Really quit? (Y/N): ");

//			var result = Console.ReadLine();
//			if (result.ToUpper() == "Y")
//			{
//				hasQuit = true;
//			}
//		}
//		else
//		{
//			Console.WriteLine($"{c.SQuote()} is not a recognized command.");
//		}
//	}
//}

/*

				XConsole.WriteLine();

				if (c == "database-init")
				{
					try
					{
						DatabaseCommands.ConstructDB();
					}
					catch (Exception ex)
					{
						XConsole
							.AddUnderline()
							.SetBold()
							.WriteLine("  EXCEPTION THROWN  ", Swatch.Red)
							.RemoveUnderline()
							.SetNormalIntensity();

						XConsole
							.WriteLine(ex.ToString(), Swatch.DeepOrange)
							.WriteLine()
							.WriteLine();

						XConsole
							.WriteLine("command completed, with errors.", Swatch.Red)
							.WriteLine();
					}
				}
				else if (c == "scrape-csv")
				{
					try
					{
						DatabaseCommands.ScrapeCSVs(
							new DirectoryInfo(@"C:\Users\Eric\Desktop\csv\"));
					}
					catch (Exception ex)
					{
						Console.WriteLine("EXCEPTION THROWN");
						Console.WriteLine(ex);
						Console.WriteLine("Command completed, with errors.");
					}
				}
				else if (c == "archive-ms")
				{
					Console.WriteLine("Archiving Matt and Shane Podcast...");

					var libsynAPI = new LibsynAPI();

					var queryBuilder = new LibsynQueryBuilder()
						.WithAuthor("mattandshanessecret");

					foreach (var libsynResult in libsynAPI.Query(queryBuilder))
					{

					}

				}
				else if (c == "transform-docstyle")
				{
					try
					{
						DatabaseCommands.ScrapeCSVs(
							new DirectoryInfo(@"C:\Users\Eric\Desktop\csv\"));
					}
					catch (Exception ex)
					{
						Console.WriteLine("EXCEPTION THROWN");
						Console.WriteLine(ex);
						Console.WriteLine("Command completed, with errors.");
					}
				}
				else if (c == "archive-rf")
				{
					using (var context = new CoreContext())
					{
						var archiveAPI = new InternetArchiveAPI();

						var queryBuilder = new IAQueryBuilder()
							.WithUploader("opieandanthonylive")
							.WithSubject("Ron and Fez")
							.WithFields(
								Creator,
								Date,
								Description,
								Identifier,
								MediaType,
								Title,
								Collection,
								Language,
								Contributor)
							.WithSort(
								Title,
								IASortDirection.Ascending)
							.WithRows(5000)
							.WithOutputKind(APIDataOutputKind.JSON)
							.WithCallback("callback")
							.WithShouldSave(true);

						var archiveAlbums = archiveAPI
							.Query(queryBuilder);

						//var albumIndex = 0;

						foreach (var archiveAlbum in archiveAlbums)
						{
							ExtendedConsole.XConsole.WriteIAItem(archiveAlbum);


							//archiveAlbum

							//Console.WriteLine($"- Album #{albumIndex}");

							//archiveAlbum.ContentCreatorID = 2;

							//Console.WriteLine($"  Identifier:             {archiveAlbum.Identifier.Quote()}");
							//Console.WriteLine($"  AlbumFileContentsUrl:   {archiveAlbum.AlbumFileContentsUrl.Quote()}");
							//Console.WriteLine($"  ContentCreatorID:				{archiveAlbum.ContentCreatorID}");
							//Console.WriteLine($"  DatePublished:          {archiveAlbum.DatePublished:g}");
							//Console.WriteLine($"  Description:            {archiveAlbum.Description.Quote()}");
							//Console.WriteLine($"  ArchiveFiles:           {archiveAlbum.ArchiveFiles.Count}");
							//Console.WriteLine();

							//int count = 0;

							//foreach (var archiveFile in archiveAlbum.ArchiveFiles)
							//{
							//	Console.WriteLine($"  - File #{count}");
							//	Console.WriteLine($"    FileName:               {archiveFile.FileName.Quote()}");
							//	Console.WriteLine($"    ArchiveFileType Ext:    {archiveFile.ArchiveFileTypeInfo?.Extension.SQuote()}");
							//	Console.WriteLine($"    ShowName:               {archiveFile.Show?.ShowName.SQuote()}");
							//	Console.WriteLine($"    Identifier:             {archiveFile.Identifier.Quote()}");
							//	Console.WriteLine($"    FilePathUrl:            {archiveFile.FilePathUrl.Quote()}");
							//	Console.WriteLine($"    AirDate:                {archiveFile.AirDate:d}");
							//	Console.WriteLine($"    Title:                  {archiveFile.Title.Quote()}");
							//	Console.WriteLine($"    LastModifiedDate:       {archiveFile.LastModifiedDate:d}");
							//	Console.WriteLine($"    ApproximateBytes:       {archiveFile.ApproximateBytes}");
							//	Console.WriteLine();

							//	context.ArchiveFiles.Add(archiveFile);
							//	count++;
							//}

							//context.ArchiveAlbums.Add(archiveAlbum);

							//context.SaveChanges();
							//albumIndex++;

							//Console.WriteLine("Saved.");
						}
					}
				}
				//else if (c == "archive-oa")
				//{
				//	using (var context = new CoreContext())
				//	{
				//		var archiveAPI = new InternetArchiveAPI();

				//		var queryBuilder = new IAQueryBuilder()
				//			.WithUploader("opieandanthonylive")
				//			.WithSubject("Opie and Anthony")
				//			.WithFields(
				//				Creator,
				//				Date,
				//				Description,
				//				Identifier,
				//				MediaType,
				//				Title)
				//			.WithSort(
				//				Title,
				//				IASortDirection.Ascending)
				//			.WithRows(5000)
				//			.WithOutputKind(APIDataOutputKind.JSON)
				//			.WithCallback("callback")
				//			.WithShouldSave(true);

				//		var iaItems = archiveAPI
				//			.Query(queryBuilder);

				//		var albumIndex = 0;

				//		foreach (var iaItem in iaItems)
				//		{
				//			Console.WriteLine($"- Album #{albumIndex}");
				//			XConsole
				//				.BeginWriteTable("Identifier:", iaItem.Identifier.Quote())
				//				.WriteRecord("AlbumFileContentsUrl:", iaItem.GetItemDownloadPageUrl());

				//			//.Write("Identifier:", Swatch.Cyan)
				//			//.WriteTable(t => t.WriteRecord())

				//			Console.WriteLine($"  Identifier:             {archiveAlbum.Identifier.Quote()}");
				//			Console.WriteLine($"  AlbumFileContentsUrl:   {archiveAlbum.AlbumFileContentsUrl.Quote()}");
				//			Console.WriteLine($"  ContentCreatorID:				{archiveAlbum.ContentCreatorID}");
				//			Console.WriteLine($"  DatePublished:          {archiveAlbum.DatePublished:g}");
				//			Console.WriteLine($"  Description:            {archiveAlbum.Description.Quote()}");
				//			Console.WriteLine($"  ArchiveFiles:           {archiveAlbum.ArchiveFiles.Count}");
				//			Console.WriteLine();

				//			int count = 0;

				//			foreach (var archiveFile in archiveAlbum.ArchiveFiles)
				//			{
				//				Console.WriteLine($"  - File #{count}");
				//				Console.WriteLine($"    FileName:               {archiveFile.FileName.Quote()}");
				//				Console.WriteLine($"    ArchiveFileType Ext:    {archiveFile.ArchiveFileTypeInfo?.Extension.SQuote()}");
				//				Console.WriteLine($"    ShowName:               {archiveFile.Show?.ShowName.SQuote()}");
				//				Console.WriteLine($"    Identifier:             {archiveFile.Identifier.Quote()}");
				//				Console.WriteLine($"    FilePathUrl:            {archiveFile.FilePathUrl.Quote()}");
				//				Console.WriteLine($"    AirDate:                {archiveFile.AirDate:d}");
				//				Console.WriteLine($"    Title:                  {archiveFile.Title.Quote()}");
				//				Console.WriteLine($"    LastModifiedDate:       {archiveFile.LastModifiedDate:d}");
				//				Console.WriteLine($"    ApproximateBytes:       {archiveFile.ApproximateBytes}");
				//				Console.WriteLine();

				//				context.ArchiveFiles.Add(archiveFile);
				//				count++;
				//			}

				//			context.ArchiveAlbums.Add(archiveAlbum);

				//			context.SaveChanges();
				//			albumIndex++;

				//			Console.WriteLine("Saved.");
				//		}
				//	}
				//}
				//else if (c == "archive-ct")
				//{
				//	using (var context = new CoreContext())
				//	{
				//		var archiveAPI = new InternetArchiveAPI();

				//		var queryBuilder = new IAQueryBuilder()
				//			.WithUploader("opieandanthonylive")
				//			.WithSubject("Cumtown")
				//			.WithFields(
				//				Creator,
				//				Date,
				//				Description,
				//				Identifier,
				//				MediaType,
				//				Title)
				//			.WithSort(
				//				Title,
				//				IASortDirection.Ascending)
				//			.WithRows(5000)
				//			.WithOutputKind(APIDataOutputKind.JSON)
				//			.WithCallback("callback")
				//			.WithShouldSave(true);

				//		var archiveAlbums = archiveAPI
				//			.Query(queryBuilder);

				//		var albumIndex = 0;

				//		foreach (var archiveAlbum in archiveAlbums)
				//		{
				//			Console.WriteLine($"- Album #{albumIndex}");

				//			archiveAlbum.ContentCreatorID = 4;

				//			Console.WriteLine($"  Identifier:             {archiveAlbum.Identifier.Quote()}");
				//			Console.WriteLine($"  AlbumFileContentsUrl:   {archiveAlbum.AlbumFileContentsUrl.Quote()}");
				//			Console.WriteLine($"  ContentCreatorID:				{archiveAlbum.ContentCreatorID}");
				//			Console.WriteLine($"  DatePublished:          {archiveAlbum.DatePublished:g}");
				//			Console.WriteLine($"  Description:            {archiveAlbum.Description.Quote()}");
				//			Console.WriteLine($"  ArchiveFiles:           {archiveAlbum.ArchiveFiles.Count}");
				//			Console.WriteLine();

				//			int count = 0;

				//			foreach (var archiveFile in archiveAlbum.ArchiveFiles)
				//			{
				//				Console.WriteLine($"  - File #{count}");
				//				Console.WriteLine($"    FileName:               {archiveFile.FileName.Quote()}");
				//				Console.WriteLine($"    ArchiveFileType Ext:    {archiveFile.ArchiveFileTypeInfo?.Extension.SQuote()}");
				//				Console.WriteLine($"    ShowName:               {archiveFile.Show?.ShowName.SQuote()}");
				//				Console.WriteLine($"    Identifier:             {archiveFile.Identifier.Quote()}");
				//				Console.WriteLine($"    FilePathUrl:            {archiveFile.FilePathUrl.Quote()}");
				//				Console.WriteLine($"    AirDate:                {archiveFile.AirDate:d}");
				//				Console.WriteLine($"    Title:                  {archiveFile.Title.Quote()}");
				//				Console.WriteLine($"    LastModifiedDate:       {archiveFile.LastModifiedDate:d}");
				//				Console.WriteLine($"    ApproximateBytes:       {archiveFile.ApproximateBytes}");
				//				Console.WriteLine();

				//				context.ArchiveFiles.Add(archiveFile);
				//				count++;
				//			}

				//			context.ArchiveAlbums.Add(archiveAlbum);

				//			context.SaveChanges();
				//			albumIndex++;

				//			Console.WriteLine("Saved.");
				//		}
				//	}
				//}
				else if (c == "excel")
				{
					try
					{
						DatabaseCommands.ScrapeExcel(
							new DirectoryInfo(@"C:\Users\Eric\Desktop\csv\01\"));
					}
					catch (Exception ex)
					{
						Console.WriteLine("EXCEPTION THROWN");
						Console.WriteLine(ex);
						Console.WriteLine("Command completed, with errors.");
					}
				}
				else if (c == "quit" || c == "exit")
				{
					Console.WriteLine($"Really quit? (Y/N): ");

					var result = Console.ReadLine();

					if (result.ToUpper() == "Y")
					{
						hasQuit = true;
					}
				}
				else
				{
					Console.WriteLine($"{c.SQuote()} is not a recognized command.");
				}
			}*/
