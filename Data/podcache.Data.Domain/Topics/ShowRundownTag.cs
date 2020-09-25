namespace podcache.Data.Domain
{
	public class ShowRundownTag
	{
		public int ShowRundownTagID { get; set; }

		//public int? ShowRundownTagKindID { get; set; }
		//[ForeignKey("ShowRundownTagKindID")]
		public string ShowRundownTagKind { get; set; }

	}

	//public partial class ShowRundownTagKind 
	//	: ISeedableEntity
	//{
	//	public ShowRundownTagKind Person

	//}

	//public partial class ShowRundownTagKind
	//{
	//	public int ShowRundownTagKindID { get; set; }

	//	public string ShowRundownTagName { get; set; }
	//}
}

