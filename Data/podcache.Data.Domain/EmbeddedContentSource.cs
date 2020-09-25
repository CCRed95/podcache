using System.Runtime.CompilerServices;
using Ccr.Std.Core.Extensions;
using JetBrains.Annotations;

namespace podcache.Data.Domain
{
  ////[EntityConfigurator(typeof(EmbeddedContentSourceMap))]
  public partial class EmbeddedContentSource
  {
    public int EmbeddedContentSourceID { get; set; }

    public string EmbeddedContentSourceName { get; set; }


		public static EmbeddedContentSource Define(
	    [CallerMemberName] string memberName = "")
    {
	    return new EmbeddedContentSource(
		    memberName.Replace("_", " "));
    }


		private EmbeddedContentSource() { }

    public EmbeddedContentSource(
      [NotNull] string embeddedContentSourceName)
				: this()
    {
      embeddedContentSourceName.IsNotNull(nameof(embeddedContentSourceName));

      EmbeddedContentSourceName = embeddedContentSourceName;
    }

    private EmbeddedContentSource(
      int embeddedContentSourceID,
      string embeddedContentSourceName)
				: this(
					embeddedContentSourceName)
    {
      EmbeddedContentSourceID = embeddedContentSourceID;
    }
  }
}
