using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace podcache.Data.Domain
{
	/// <summary>
	///		EF Core entity type representing a time-keyed segment of a <see cref="ShowMediaEntry"/>
	///		entity. This time-keyed segment of media represents a cataloged bit, segment, guest
	///		appearance, line, joke, etc.
	/// </summary>
	/// <code lang="sql">
	///		CREATE TABLE [dbo].[ShowMediaSegmentContentTags] (
	///			[ShowMediaSegmentContentTagID]		INT						NOT NULL			IDENTITY(1, 1),
	///			[ShowMediaEntryID]								INT						NOT NULL,
	///			[SegmentTimeStart]								TIMESTAMP			NOT NULL,
	///			[SegmentTimeEnd]									TIMESTAMP			NULL,
	///			[PlaybackLength]									TIME					NULL,
	///			[AverageRating]										FLOAT					NULL,
	///			[NumberOfRatings]									INT						NOT NULL,
	/// 
	///			PRIMARY KEY([ShowMediaSegmentContentTagID])
	///		)
	/// </code>
	public class ShowMediaSegmentContentTag
  {
		/// <summary>
		///		The entity ID, a unique <see cref="int"/> value, which is a SQL Server-generated column
		///		value, which is configured as an <code>IDENTITY(1, 1)</code>, and has a
		///		<code>PRIMARY KEY</code> with enforced uniqueness. 
		/// </summary>
		public int ShowMediaSegmentContentTagID { get; set; }


    public int ShowMediaEntryID { get; set; }
    [NotNull, ForeignKey("ShowMediaEntryID")]
    public virtual ShowMediaEntry ShowMediaEntry { get; set; }
    

    public TimeSpan SegmentTimeStart { get; set; }

    public TimeSpan? SegmentTimeEnd { get; set; }

		public TimeSpan PlaybackLength { get; set; }


	  public virtual HashSet<ShowMediaSegmentComment> MediaSegmentComments { get; set; }

	  public virtual HashSet<ShowMediaSegmentRating> ShowMediaSegmentRatings { get; set; }
	}
}




///// <code lang="sql">
/////		CREATE TABLE [dbo].[ShowMediaSegmentContentTags] (
/////			[ShowMediaSegmentContentTagID]		INT							NOT NULL		IDENTITY,
/////			[ItemTypeClassification]					NVARCHAR(100),
/////			[Title]														NVARCHAR(250)		NOT NULL,
/////			[By]															NVARCHAR(50),
/////			[NarratedBy]											NVARCHAR(50),
/////			[FullShowMetadataUrl]							NVARCHAR(250)		NOT NULL,
/////			[PlaybackLength]									TIME(7),
/////			[AirDate]													DATE						NOT NULL,
/////			[AverageRating]										FLOAT,
/////			[NumberOfRatings]									INT							NOT NULL,
/////			PRIMARY KEY([ShowMediaSegmentContentTagID])
/////		)
///// </code>