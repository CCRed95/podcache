using podcache.Data.Core.EntityFrameworkCore;

namespace podcache.Data.Domain
{
  public partial class EmbeddedContentSource
    : ISeedableEntity
  {
    public static EmbeddedContentSource Archive
	    = new EmbeddedContentSource(
		    1,
		    "Archive");

    public static EmbeddedContentSource YouTube
	    = new EmbeddedContentSource(
		    2,
				"YouTube");

		public static EmbeddedContentSource ShoutEngine
			= new EmbeddedContentSource(
				3,
				"ShoutEngine");

		public static EmbeddedContentSource Patreon
			= new EmbeddedContentSource(
				4,
				"Patreon");
	}
}