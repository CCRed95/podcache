namespace podcache.Data.Domain.Extensions
{
	public static class GuestBuilderExtensions
	{
		public static Guest IsMale(
			this Guest @this)
		{
			@this.GenderID = 2;
			return @this;
		}

		public static Guest IsFemale(
			this Guest @this)
		{
			@this.GenderID = 3;
			return @this;
		}
	}
}