namespace podcache.Data.API.Infrastructure
{
  public interface IPathFragment
    : IUriFragment
  {
    string Path { get; }
  }
}