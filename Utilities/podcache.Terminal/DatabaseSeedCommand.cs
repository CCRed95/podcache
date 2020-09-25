using System;
using System.Linq;
using System.Reflection;
using Ccr.Colorization.Mappings;
using Ccr.Std.Core.Extensions;
using podcache.Data.Context;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;
using static Ccr.Terminal.ExtendedConsole;

namespace podcache.Terminal
{
	public class DatabaseSeedCommand
		: TerminalCommand<string>
	{
		public override string CommandName => "seed-database";

		public override string ShortCommandName => "seed-db";


		public override void Execute(
			string arg)
		{
			XConsole.WriteLine($"Creating Entity Framework Database Context", Swatch.Cyan);

			using var context = new CoreContext();

			XConsole.WriteLine($"Beginning database seed...", Swatch.Cyan);

			var seedableEntityTypes = new[]
			{
				typeof(ArchiveFileTypeInfo),
				typeof(ContentCreator),
				typeof(EmbeddedContentSource),
				typeof(Gender),
				typeof(GuestAppearanceType),
				typeof(ShowRundownAuthor),
				typeof(Host),
				typeof(Show),
				//typeof(Guest),
			};

			foreach (var seedableEntityType in seedableEntityTypes)
			{
				XConsole.WriteLine(
					$"  Discovered seedable entity type: {seedableEntityType.FormatName().SQuote()}", Swatch.Cyan);

				var dbContextType = typeof(CoreContext);
				var setMethod = dbContextType.GetMethod(
					"Set",
					new Type[] { });

				var genericMethod = setMethod
					.MakeGenericMethod(
						seedableEntityType);

				var dbSet = genericMethod.Invoke(context, null);

				var staticSet =
					seedableEntityType
						.GetFields(
							BindingFlags.Public | BindingFlags.Static)
						.Select(
							t => t.GetValue(null))
						.Where(
							t => t.GetType() == seedableEntityType);

				var extensionMethod = typeof(Enumerable)
					.GetMethod(
						nameof(Enumerable.Cast));

				var genericExtensionMethod = extensionMethod
					.MakeGenericMethod(
						seedableEntityType);

				var convertedStaticSet = genericExtensionMethod
					.Invoke(
						null,
						new object[] { staticSet });

				var addRangeMethod = typeof(DbSetExtensions)
					.GetMethod(
						"AddRangeWithSqlIdentity");

				var genericAddRangeMethod = addRangeMethod
					.MakeGenericMethod(
						seedableEntityType);

				var toArrayMethod = typeof(Enumerable)
					.GetMethod(
						nameof(Enumerable.ToArray));

				var toArrayGenericMethod = toArrayMethod
					.MakeGenericMethod(
						seedableEntityType);

				var enumeratedArray = toArrayGenericMethod
					.Invoke(
						null,
						new[] { convertedStaticSet });

				XConsole.Write($"  Inserting seed records... ", Swatch.Cyan);

				genericAddRangeMethod.Invoke(
					null,
					new[]
					{
						dbSet,
						enumeratedArray
					});

				XConsole.WriteLine($"Complete.", Swatch.Teal);

				XConsole.Write($"Saving changes to database... ", Swatch.Cyan);

				context.SaveChanges();

				XConsole.WriteLine($"Complete.", Swatch.Teal);
			}


			XConsole.WriteLine($"Complete.", Swatch.Teal);
			XConsole.WriteLine($"Database seeded successfully", Swatch.Teal);
		}
	}
}