using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Ccr.Std.Core.Extensions;
using JetBrains.Annotations;

namespace podcache.Data.Domain
{
  public class ArchiveAlbum
  {
   public int ArchiveAlbumID { get; set; }

    [NotNull]
    public string Identifier { get; set; }

    public int? ContentCreatorID { get; set; }
    [CanBeNull, ForeignKey("ContentCreatorID")]
    public virtual ContentCreator ContentCreator { get; set; }

    public string Description { get; set; }

    public DateTime DatePublished { get; set; }

    public int YearNumber { get; set; }

    public int MonthNumber { get; set; }

    [NotMapped]
    public string AlbumFileContentsUrl
    {
      get => $"https://www.archive.org/download/{Identifier}/";
    }

    public virtual ICollection<ArchiveFile> ArchiveFiles { get; set; }



    private ArchiveAlbum()
    {
	    ArchiveFiles = new HashSet<ArchiveFile>();
    }

		public ArchiveAlbum(
		  [NotNull] string identifier,
		  [NotNull] ContentCreator contentCreator,
		  string description,
		  DateTime datePublished,
		  int yearNumber,
		  int monthNumber)
				: this()
	  {
		  identifier.IsNotNull(nameof(identifier));
      contentCreator.IsNotNull(nameof(contentCreator));

		  Identifier = identifier;
		  ContentCreatorID = contentCreator.ContentCreatorID;
		  Description = description;
		  DatePublished = datePublished;
		  YearNumber = yearNumber;
		  MonthNumber = monthNumber;
	  }
	}
}



//[NotMapped]
//private readonly Func<ArchiveAlbum, IEnumerable<ArchiveFile>> _archiveAlbumFilesScraper;
//[NotMapped]
//private ArchiveFile[] _archiveFiles;

// Func<ArchiveAlbum, IEnumerable<ArchiveFile>> archiveAlbumFilesScraper)


// _archiveAlbumFilesScraper = archiveAlbumFilesScraper;

//ArchiveFiles = _archiveAlbumFilesScraper(this)
// .ToArray();