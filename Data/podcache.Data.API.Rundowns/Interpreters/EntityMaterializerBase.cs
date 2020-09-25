namespace podcache.Data.API.Rundowns.Interpreters
{
	public abstract class EntityMaterializerBase<TEntity, TSource>
	{
		public abstract TEntity MaterializeEntity(
			TSource source);
	}
}