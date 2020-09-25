using System.Threading.Tasks;

namespace podcache.Data.API.Web
{
  public interface IHttpClient
  {
    Task<string> GetContentAsync(string address);
  }
}