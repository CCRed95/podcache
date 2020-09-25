// ReSharper disable VirtualMemberCallInConstructor
using Ccr.Std.Core.Extensions;
using JetBrains.Annotations;

namespace podcache.Data.Domain
{
  public partial class Gender
  {
    public int GenderID { get; set; }

    public string Abbreviation { get; set; }

    public string GenderName { get; set; }


    public Gender() { }
    
    public Gender(
      [NotNull] string abbreviation,
      [NotNull] string genderName)
				: this()
    {
      abbreviation.IsNotNull(nameof(abbreviation));
      genderName.IsNotNull(nameof(genderName));

      Abbreviation = abbreviation;
      GenderName = genderName;
    }

    private Gender(
      int genderID,
      [NotNull] string abbreviation,
      string genderName)
				: this(
					abbreviation,
					genderName)
    {
      GenderID = genderID;
    }
  }
}