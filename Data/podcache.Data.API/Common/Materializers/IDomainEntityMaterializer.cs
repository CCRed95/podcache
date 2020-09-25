namespace podcache.Data.API.Common.Materializers
{
	public interface IDomainEntityMaterializer
	{
		object MaterializeBase(object data);
	}
}