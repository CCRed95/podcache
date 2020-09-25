using System.Runtime.CompilerServices;
using Ccr.Std.Core.Extensions;

namespace podcache.Data.Domain
{
	public partial class GuestAppearanceType
	{
	  public int GuestAppearanceTypeID { get; set; }

		public string AppearanceTypeName { get; set; }


		public static GuestAppearanceType Define(
			[CallerMemberName] string memberName = "")
		{
			return new GuestAppearanceType(
				memberName.Replace("_", " "));
		}

		
		private GuestAppearanceType() { }

		public GuestAppearanceType(
			string appearanceTypeName) 
				: this()
		{
			appearanceTypeName.IsNotNull(nameof(appearanceTypeName));

			AppearanceTypeName = appearanceTypeName;
		}

		private GuestAppearanceType(
			int guestAppearanceTypeID,
			string appearanceTypeName)
				: this(appearanceTypeName)
		{
			GuestAppearanceTypeID = guestAppearanceTypeID;
		}
	}
}
