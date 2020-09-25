using Ccr.Colorization.Mappings;
using podcache.Data.Context;
using static Ccr.Terminal.ExtendedConsole;

namespace podcache.Terminal
{
	public class DatabaseInitializeCommand
		: TerminalCommand<string>
	{
		public override string CommandName => "initialize-database";

		public override string ShortCommandName => "init-db";


		public override void Execute(
			string arg)
		{
			XConsole.WriteLine($"Creating Entity Framework Database Context.", Swatch.Cyan);

			using var context = new CoreContext();

			XConsole.WriteLine($"Ensuring database is deleted...", Swatch.Cyan);

			var deleteResult = context.Database.EnsureDeleted();

			if (deleteResult)
				XConsole.WriteLine($"  Database deleted successfully.", Swatch.Teal);
			else
				XConsole.WriteLine($"  Database already does not exist.", Swatch.Teal);

			XConsole.WriteLine($"Creating database structure and schema...", Swatch.Cyan);

			var createResult = context.Database.EnsureCreated();

			if (!createResult)
			{
				XConsole.WriteLine($"  Database creation failed.", Swatch.Red);
				return;
			}

			XConsole
				.WriteLine($"  Database created successfully", Swatch.Teal)
				.WriteLine($"	 Database information:", Swatch.LightBlue)
				.WriteLine($"    {context.Database}", Swatch.LightBlue);
		}
	}

}