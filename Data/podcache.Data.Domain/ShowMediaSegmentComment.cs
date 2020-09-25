﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace podcache.Data.Domain
{
	/// <summary>
	///		EF Core entity type representing a single comment attributed to a
	///		<see cref="ShowMediaSegmentContentTag"/>, the User, the Comment text, and optional
	///		time-keying.
	/// </summary>
	/// <code lang="sql">
	///		CREATE TABLE [dbo].[ShowMediaSegmentComments] (
	///			[ShowMediaSegmentCommentID]				INT						NOT NULL			IDENTITY(1, 1),
	///			[ShowMediaEntryID]								INT						NOT NULL,
	///			[Username]												NVARCHAR(200)	NOT NULL,
	///			[CommentText]											STRING				NOT NULL,
	///			[CommentTimeStampUtc]							DATETIME			NOT NULL,
	///			[CommentLastEditedTimeStampUtc]		DATETIME			NULL,
	///			[CommentTimeStart]								TIMESTAMP			NULL,
	///			[CommentTimeEnd]									TIMESTAMP			NULL,
	///			[PlaybackLength]									TIMESTAMP			NULL,
	/// 
	///			PRIMARY KEY([ShowMediaSegmentCommentID])
	///		)
	/// </code>
	public class ShowMediaSegmentComment
	{
		/// <summary>
		///		The entity ID, a unique <see cref="int"/> value, which is a SQL Server-generated column
		///		value, which is configured as an <code>IDENTITY(1, 1)</code>, and has a
		///		<code>PRIMARY KEY</code> with enforced uniqueness. 
		/// </summary>
		public int ShowMediaSegmentCommentID { get; set; }


		public int ShowMediaSegmentContentTagID { get; set; }
		[NotNull, ForeignKey("ShowMediaSegmentContentTagID")]
		public virtual ShowMediaSegmentContentTag ShowMediaSegmentContentTag { get; set; }


		public string Username { get; set; }

		public string CommentText { get; set; }

		public DateTime CommentTimeStampUtc { get; set; }

		public DateTime? CommentLastEditedTimeStampUtc { get; set; }

		public TimeSpan? CommentTimeStart { get; set; }

		public TimeSpan? CommentTimeEnd { get; set; }

		public TimeSpan? PlaybackLength { get; set; }
	}
}