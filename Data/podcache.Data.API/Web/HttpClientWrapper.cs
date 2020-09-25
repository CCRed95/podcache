using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace podcache.Data.API.Web
{
  public class HttpClientWrapper
    : IHttpClient,
      IDisposable
  {
    private readonly HttpClient _client;


    public HttpClientWrapper()
    {
      _client = new HttpClient();
      _client
        .DefaultRequestHeaders
        .Add(
          "User-Agent",
          "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.11 Safari/537.36");
    }


    public async Task<string> GetContentAsync(
      string address)
    {
      return await _client.GetStringAsync(address);
    }

    public void Dispose()
    {
      _client?.Dispose();
    }
  }
}