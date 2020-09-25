using System.Collections.Generic;

namespace podcache.Data.API.Common.Scraping
{
  public interface ISearchScraper
  {
    IEnumerable<TEntity> Scrape<TEntity>(string htmlContent);
  }
}
