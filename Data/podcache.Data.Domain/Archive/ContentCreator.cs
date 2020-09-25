using System.Runtime.CompilerServices;

namespace podcache.Data.Domain
{
  public partial class ContentCreator
  {
    public int ContentCreatorID { get; set; }

    public string ContentCreatorName { get; set; }


		
		public static ContentCreator Define(
	    [CallerMemberName] string memberName = "")
    {
			return new ContentCreator(
				memberName.Replace("_", " "));
    }


		public ContentCreator()
		{
		}

		public ContentCreator(
			string contentCreatorName)
				: this()
		{
			ContentCreatorName = contentCreatorName;
		}

		public ContentCreator(
      int contentCreatorID,
      string contentCreatorName) 
        : this(
	        contentCreatorName)
    {
      ContentCreatorID = contentCreatorID;
    }
  }
}
