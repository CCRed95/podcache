using podcache.Data.Core.EntityFrameworkCore;

namespace podcache.Data.Domain
{
  public partial class GuestAppearanceType
		: ISeedableEntity
  {
	  public static GuestAppearanceType Studio_Appearance
			= new GuestAppearanceType(
				1,
				"Studio Appearance");

    public static GuestAppearanceType Phone_Appearance
	    = new GuestAppearanceType(
		    2,
		    "Phone Appearance");
	}
}