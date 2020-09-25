namespace podcache.Data.API.Infrastructure
{
  public interface INamedAnchorFragment
    : IUriFragment
  {
    string AnchorValue { get; }
  }
}
