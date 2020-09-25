using System;

namespace podcache.Data.Domain
{
	public class MediaPost
	{
		public int EpisodeNumber { get; set; }

		public string Title { get; set; }

		public string Summary { get; set; }

		public string Body { get; set; }

		public DateTimeOffset DateTime { get; set; }

		public string FilePath { get; set; }
	}
}