using System;

namespace podcache.Data.Core.EntityFrameworkCore
{
	public abstract class EntityAdapterBase
	{
		public int EntityID { get; }

		protected abstract object EntityBase { get; }

		public abstract Type EntityType { get; }


		protected EntityAdapterBase(
			int entityID)
		{
			EntityID = entityID;
		}
	}
}