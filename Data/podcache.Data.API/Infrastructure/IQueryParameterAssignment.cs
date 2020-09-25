namespace podcache.Data.API.Infrastructure
{
  public interface IQueryParameterAssignment
    : IUriFragment
  {
    string ParameterName { get; }

    string ArgumentValue { get; }
  }
}