using System.ComponentModel.DataAnnotations.Schema;
using Ccr.Std.Core.Extensions;
using JetBrains.Annotations;

namespace podcache.Data.Domain
{
  public class ShowHost
  {
    public int ShowHostID { get; set; }

    public int ShowID { get; set; }
    [ForeignKey("ShowID")]
    public Show Show { get; set; }

    public int HostID { get; set; }
    [ForeignKey("HostID")]
    public Host Host { get; set; }



    public ShowHost()
    {
    }

    public ShowHost(
      [NotNull] Show show,
      [NotNull] Host host)
				: this()
    {
      show.IsNotNull(nameof(show));
      host.IsNotNull(nameof(host));

      ShowID = show.ShowID;
      HostID = host.HostID;
    }
	}
}