using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;
using Ccr.Std.Core.Extensions;
using JetBrains.Annotations;

namespace podcache.Data.Core.EntityFrameworkCore
{
	public abstract class DbContextStructure
	{

	}

	public class DbContextStructure<TContext>
		: DbContextStructure
			where TContext : DbContext
	{

		public DbContextStructure()
		{
			var contextEntityTypes = typeof(TContext)
				.GetProperties(BindingFlags.Instance | BindingFlags.Public)
				.ToArray();

			foreach (var contextEntityType in contextEntityTypes)
			{

			}
		}
	}

	public class EntityTypeStructure
	{
		private List<EntityTypeStructure> _referencesEntityType;

		[NotNull]
		public Type EntityType { get; }

		public bool IsSeedable { get; }

		public IReadOnlyList<EntityTypeStructure> ReferencesEntityType
		{
			get => _referencesEntityType;
		}

		
		public EntityTypeStructure(
			[NotNull] Type entityType)
		{
			EntityType = entityType;
			IsSeedable = entityType.Implements<ISeedableEntity>();

			_referencesEntityType = new List<EntityTypeStructure>();

			foreach (var property in EntityType.GetProperties(BindingFlags.Instance))
			{
				if (property.PropertyType.IsClass)
				{
					_referencesEntityType.Add(new EntityTypeStructure(property.PropertyType));
				}
			}
		}
	}
}
