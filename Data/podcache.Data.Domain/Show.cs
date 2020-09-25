using System.Collections.Generic;
using System.Linq;
using Ccr.Std.Core.Extensions;
using JetBrains.Annotations;

// ReSharper disable VirtualMemberCallInConstructor
namespace podcache.Data.Domain
{
  public partial class Show
	{
	  public int ShowID { get; set; }

		public string ShowName { get; set; }


		public virtual ICollection<ShowHost> ShowHosts { get; set; }
		
    
		private Show() { }

		public Show(
			[NotNull] string showName)
		    : this()
		{
			showName.IsNotNull(nameof(showName));
			ShowName = showName;
		}

		public Show(
			string showName,
			params Host[] hosts)
			: this(
				showName)
		{
			ShowHosts = hosts
				.Select(
					host => new ShowHost(
						this,
						host))
				.ToHashSet();
		}

		private Show(
			int showID,
			string showName,
			params Host[] hosts)
		    : this(
		      showName)
		{
			ShowID = showID;
		  ShowHosts = hosts
		    .Select(
          host => new ShowHost(
            this,
            host))
          .ToHashSet();
		}
	}
}
