using podcache.Data.Core.EntityFrameworkCore;

namespace podcache.Data.Domain
{
  public partial class Gender
	  : ISeedableEntity
  {
    public static readonly Gender Unset 
	    = new Gender(1, "U", "Unset");

    public static readonly Gender Male
	    = new Gender(2, "M", "Male");

    public static readonly Gender Female 
	    = new Gender(3, "F", "Female");
  }
}