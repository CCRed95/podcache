using AngleSharp.Dom;

namespace podcache.Data.API.Common.Scraping
{
  public interface ISearchResultScraper<out TValue>
  {
    TValue Scrape(IElement htmlNode);
  }
}
