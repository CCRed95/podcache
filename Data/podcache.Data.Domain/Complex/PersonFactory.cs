using System.Text.RegularExpressions;

namespace podcache.Data.Domain
{
  public class PersonFactory
  {
    private static readonly Regex _nameRegex
      = new Regex(
        @"\A(?<first>[\w.]*)\b[^\w]*(?<middle>[\w\s.]*?)?(?<last>[\w.\']*)\Z");


    public static TPersonType CreatePerson<TPersonType>(
      string fullName)
        where TPersonType
        : Person,
          new()
    {
      var match = _nameRegex.Match(fullName);

      var person = new TPersonType
      {
	      FirstName = match.Groups["first"].Value,
	      MiddleName = match.Groups["middle"]?.Value,
	      LastName = match.Groups["last"]?.Value
      };
      
      return person;
    }
  }
}
