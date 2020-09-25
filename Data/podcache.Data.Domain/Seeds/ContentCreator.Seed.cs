using podcache.Data.Core.EntityFrameworkCore;

namespace podcache.Data.Domain
{
	public partial class ContentCreator
		: ISeedableEntity
	{
		public static readonly ContentCreator Opie_and_Anthony 
			= new ContentCreator(
				1,
				"Opie and Anthony");

		public static readonly ContentCreator Ron_and_Fez
			= new ContentCreator(
				2,
				"Ron and Fez");

		public static readonly ContentCreator Ricky_Gervais
			= new ContentCreator(
				3,
				"Ricky Gervais");

		public static readonly ContentCreator Cumtown
			= new ContentCreator(
				4,
				"Cumtown");
	}
}