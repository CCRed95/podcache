using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using podcache.Data.Core.EntityFrameworkCore;

namespace podcache.Data.Domain
{
	public partial class Host
		: ISeedableEntity
	{
		[UsedImplicitly]
		private class HostFactory
		{
			public static Host Create(
				int hostID,
				[NotNull] Gender gender,
				string twitterHandle = null,
				string websiteUrl = null,
				[CallerMemberName] string callerMemberName = "")
			{
				var fullname = callerMemberName.Replace("_", " ");
				var name = PersonFactory.CreatePerson<PersonImpl>(fullname);

				var entity = new Host
				{
					HostID = hostID,
					GenderID = gender.GenderID,
					TwitterHandle = twitterHandle,
					WebsiteUrl = websiteUrl,
					FirstName = name.FirstName,
					MiddleName = name.MiddleName,
					LastName = name.LastName
				};

				return entity;
			}
		}


		public static Host Gregg_Hughes = HostFactory.Create(
			1,
			Gender.Male,
			"@opieradio");

		public static Host Anthony_Cumia = HostFactory.Create(
			2,
			Gender.Male,
			"@AnthonyCumiaxyz",
			"https://www.compoundmedia.com/");

		public static Host Jim_Norton = HostFactory.Create(
			3,
			Gender.Male,
			"@JimNorton",
			"http://jimnorton.com/");

		public static Host Ron_Bennington = HostFactory.Create(
			4,
			Gender.Male,
			"@BenningtonShow",
			"http://theronandfezshow.com/");

		public static Host Fez_Whatley = HostFactory.Create(
			5,
			Gender.Male,
			"@Fezshitter",
			"http://theronandfezshow.com/");

		public static Host Ricky_Gervais = HostFactory.Create(
			6,
			Gender.Male,
			"@rickygervais",
			"http://rickygervais.com/");

		public static Host Stephen_Merchant = HostFactory.Create(
			7,
			Gender.Male,
			"@stephenmerchant",
			"http://stephenmerchant.com/");

		public static Host Karl_Pilkington = HostFactory.Create(
			8,
			Gender.Male,
			"@karlpilkington");

		public static Host Colin_Quinn = HostFactory.Create(
			9,
			Gender.Male,
			"@iamcolinquinn");

		public static Host Nick_Mullen = HostFactory.Create(
			10,
			Gender.Male,
			"@nickmullen");

		public static Host Stavros_Halkias = HostFactory.Create(
			11,
			Gender.Male,
			"@stavvybaby",
			"https://www.stavvy.biz/");

		public static Host Adam_Friedland = HostFactory.Create(
			12,
			Gender.Male,
			"@AdamFriedland",
			"http://www.adamfriedland.com/");
	}
}