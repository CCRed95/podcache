namespace podcache.Data.API.Infrastructure
{
	public class DomainFragment
		: IUriFragment
	{
		private string _domain;


		public string Domain
		{
			get => _domain;
			set => _domain = value.Trim(' ', '/', '\\');
		}

		public UrlBuilder Builder
		{
			get => new UrlBuilder(this);
		}


		public DomainFragment(
			string domain)
		{
			Domain = domain;
		}



		public string GetFragment(bool start, bool end)
		{
			var fragment = Domain;
			if (start)
			{
			}
			if (end)
			{
				fragment += "/";
			}
			return fragment;
		}
	}
}