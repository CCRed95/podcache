using System;

namespace podcache.Data.Domain
{
	public class ShowRundownCsvEntry
	{
		public int ShowRundownCsvEntryID { get; set; }

		public string AuthorName { get; set; }

		public string LongText { get; set; }

		public string Title { get; set; }

		public DateTime DateTime { get; set; }

		public DateTime? DateTimeEnd { get; set; }
	}
}
