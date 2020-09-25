using System.Collections.Generic;
using podcache.Data.API.Common.Query;
using podcache.Data.API.Infrastructure;

namespace podcache.Data.API.Common
{
  public abstract class APIBase<TResult, TQueryBuilder>
    where TQueryBuilder
      : IQueryBuilder
  {
    protected abstract DomainFragment RequestBuilder { get; }


    public abstract IEnumerable<TResult> Query(TQueryBuilder queryBuilder);
  }
}
