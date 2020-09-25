using System.Linq;
using AngleSharp;
using podcache.Data.API.Infrastructure;
using podcache.Data.Domain;

namespace podcache.Data.API.Rundowns.Interpreters
{
	public class ShowRundownInterpreter
    : EntityMaterializerBase<ShowRundown, ArchiveFile>
  {
    private const string _domain = "http://www.struff.org/";
    private DomainFragment _requestBuilder;


    protected DomainFragment RequestBuilder
    {
      get => _requestBuilder ??= new DomainFragment(_domain);
    }


    public override ShowRundown MaterializeEntity(
      ArchiveFile archiveFile)
    {
      var context = BrowsingContext
        .New(
          Configuration
            .Default
            .WithDefaultLoader());

      using (var document = context
        .OpenAsync(archiveFile.FilePathUrl)
        .GetAwaiter()
        .GetResult())
      {
        var searchResult = document
          .GetElementById("posts")
          .Children
          .First();

        var author = searchResult
          .QuerySelector(".postdetails")
          .QuerySelector(".userinfo")
          .QuerySelector(".username_container")
          .QuerySelector(".username")
          .TextContent
          .Trim();

        var title = searchResult
          .QuerySelector(".postbody")
          .QuerySelector(".title")
          .TextContent
          .Trim();

        var blockQuoteContent = searchResult
          .QuerySelector(".postbody")
          .QuerySelector(".title")
          .QuerySelector(".content")
          .QuerySelector("div")
          .Children
          .First()
          .InnerHtml;

        return new ShowRundown(
          title,
          blockQuoteContent,
          archiveFile,
          ShowRundownAuthor.CCRed95,
          archiveFile.AirDate,
          archiveFile.FilePathUrl);
      }
    }
  }
}

/*
    public static ShowRundown CreateShowRundownFromArchiveFile(
      ArchiveFile archiveFile)
    {
      var filePathUrl =
        $"https://www.archive.org/download/{archiveAlbum.Identifier}/";

      var context = BrowsingContext
        .New(
          Configuration
            .Default
            .WithDefaultLoader());

      using (var document = context
        .OpenAsync(filePathUrl)
        .GetAwaiter()
        .GetResult())
      {
      }

      return new ArchiveAlbum(
        ContentCreator.Opie_and_Anthony,
        doc.Date,
        doc.Date.Year,
        doc.Date.Month,
        doc.Description,
        doc.Identifier);
    }*/
