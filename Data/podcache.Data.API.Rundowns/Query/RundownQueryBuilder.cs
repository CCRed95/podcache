using podcache.Data.API.Common.Query;
using podcache.Data.API.Infrastructure;

namespace podcache.Data.API.Rundowns.Query
{
  public class RundownQueryBuilder
    : IRundownQueryBuilder,
      IQueryBuilder
  {
    public string BuildRequestUrl(
      DomainFragment requestBuilder)
    {
      return requestBuilder
        .Builder
        .WithPath("vbulletin")
        .WithPath("archive")
        .WithPath("index.php")
        .WithPath("f-61.html")
        .Build();
    }
  }
}
