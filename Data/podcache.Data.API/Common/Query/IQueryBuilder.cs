using podcache.Data.API.Infrastructure;

namespace podcache.Data.API.Common.Query
{
  public interface IQueryBuilder
  {
    string BuildRequestUrl(DomainFragment requestBuilder);
  }
}