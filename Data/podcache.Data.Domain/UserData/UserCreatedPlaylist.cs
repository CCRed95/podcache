using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity;

namespace podcache.Data.Domain
{
	public class UserCreatedPlaylist
	{
		public int UserCreatedPlaylistID { get; set; }

		public string UserCreatedPlaylistName { get; set; }

		public string UserName { get; set; }
		[NotNull, ForeignKey("AspNetUsers.UserName")]
		public virtual IdentityUser AspNetUser { get; set; }


		public virtual ICollection<ShowMediaEntry> ShowMediaEntries { get; set; }

		//public int ShowMediaEntryID { get; set; }
		//[NotNull, ForeignKey("ShowMediaEntryID")]
		//public virtual  ShowMediaEntry { get; set; }
	}
}