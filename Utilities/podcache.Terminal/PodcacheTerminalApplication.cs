using System.Collections.Generic;

namespace podcache.Terminal
{
	public class PodcacheTerminalApplication
		: TerminalApplication
	{
		public override string ApplicationName => "podcache terminal";

		public override string VersionNumber => "1.0.0.0";


		public override IReadOnlyList<TerminalCommandBase> TerminalCommands { get; }
			= new List<TerminalCommandBase>
			{
				new DatabaseInitializeCommand(),
				new DatabaseSeedCommand(),
				new SeedArchiveFilesCommand()
			};


		public PodcacheTerminalApplication(
			string[] args)
			: base(args)
		{
		}
	}
}