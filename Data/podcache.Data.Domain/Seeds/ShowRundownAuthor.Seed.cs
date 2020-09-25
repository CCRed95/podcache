using podcache.Data.Core.EntityFrameworkCore;

namespace podcache.Data.Domain
{
  public partial class ShowRundownAuthor
    : ISeedableEntity
  {
	  public static ShowRundownAuthor Unknown 
		  = new ShowRundownAuthor(
			  1,
			  "Unknown");

    public static ShowRundownAuthor Melinda
	    = new ShowRundownAuthor(
		    2,
				"Melinda");

		public static ShowRundownAuthor Struff
			= new ShowRundownAuthor(
				3,
				"Struff");

		public static ShowRundownAuthor Happy_Typing_Girl
			= new ShowRundownAuthor(
				4,
				"Happy Typing Girl");

		public static ShowRundownAuthor Audible
			= new ShowRundownAuthor(
				5,
				"Audible");

		public static ShowRundownAuthor CCRed95
			= new ShowRundownAuthor(
				6,
				"CCRed95");
	}
}