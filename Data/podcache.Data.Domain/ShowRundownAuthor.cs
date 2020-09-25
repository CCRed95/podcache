using System.Runtime.CompilerServices;
using Ccr.Std.Core.Extensions;
using JetBrains.Annotations;

namespace podcache.Data.Domain
{
	public partial class ShowRundownAuthor
  {
	  public int ShowRundownAuthorID { get; set; }

		public string AuthorName { get; set; }



		public static ShowRundownAuthor Define(
			[CallerMemberName] string memberName = "")
		{
			return new ShowRundownAuthor(
				memberName.Replace("_", " "));
		}


		private ShowRundownAuthor() { }

		public ShowRundownAuthor(
			[NotNull] string authorName)
		    : this()
		{
			authorName.IsNotNull(nameof(authorName));

			AuthorName = authorName;
		}

		private ShowRundownAuthor(
			int showRundownAuthorID,
			[NotNull] string memberName = "")
		    : this(
		      memberName.Replace('_', ' '))
		{
			ShowRundownAuthorID = showRundownAuthorID;
		}
	}
}
