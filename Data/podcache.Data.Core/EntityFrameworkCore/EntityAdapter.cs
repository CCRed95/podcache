using System;

namespace podcache.Data.Core.EntityFrameworkCore
{
	public class EntityAdapter<TValue>
    : EntityAdapterBase
  {
    protected override object EntityBase => Entity;

    public TValue Entity { get; }

    public override Type EntityType => typeof(TValue);


    public EntityAdapter(
      int entityID,
      TValue entity)
        : base(entityID)
    {
      Entity = entity;
    }
  }
}
