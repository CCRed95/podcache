using System;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace podcache.Data.Domain
{
	/// <summary>
	///		EF Core entity type representing a single comment attributed to a
	///		<see cref="ShowMediaSegmentRating"/>, the User, the Rating value, and time tracking.
	/// </summary>
	/// <code lang="sql">
	///		CREATE TABLE [dbo].[ShowMediaSegmentComments] (
	///			[ShowMediaSegmentRatingID]				INT						NOT NULL			IDENTITY(1, 1),
	///			[ShowMediaSegmentContentTagID]		INT						NOT NULL,
	///			[Username]												NVARCHAR(200)	NOT NULL,
	///			[RatingTimeStampUtc]							DATETIME			NOT NULL,
	///			[CommentTimeStampUtc]							DATETIME			NOT NULL,
	///			[RatingLastEditedTimeStampUtc]		DATETIME			NULL,
	///			[RatingValue]											DOUBLE				NOT NULL,
	/// 
	///			PRIMARY KEY([ShowMediaSegmentCommentID])
	///		)
	/// </code>
	public class ShowMediaSegmentRating
	{
		/// <summary>
		///		The entity ID, a unique <see cref="int"/> value, which is a SQL Server-generated column
		///		value, which is configured as an <code>IDENTITY(1, 1)</code>, and has a
		///		<code>PRIMARY KEY</code> with enforced uniqueness. 
		/// </summary>
		public int ShowMediaSegmentRatingID { get; set; }


		public int ShowMediaSegmentContentTagID { get; set; }
		[NotNull, ForeignKey("ShowMediaSegmentContentTagID")]
		public virtual ShowMediaSegmentContentTag ShowMediaSegmentContentTag { get; set; }


		public string Username { get; set; }

		public DateTime RatingTimeStampUtc { get; set; }

		public DateTime? RatingLastEditedTimeStampUtc { get; set; }

		public double RatingValue { get; set; }
	}
}