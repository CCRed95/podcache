using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
	public class ShowMediaSegmentCommentMap 
		: IEntityTypeConfiguration<ShowMediaSegmentComment>
	{
		public void Configure(
			EntityTypeBuilder<ShowMediaSegmentComment> builder)
		{
			builder.ToTable("ShowMediaSegmentComments");

			builder.HasKey(t => t.ShowMediaSegmentCommentID);
			builder.Property(t => t.ShowMediaSegmentCommentID)
				.IsRequired()
				.ValueGeneratedOnAdd();


			builder.Property(t => t.Username)
				.IsRequired();

			builder.Property(t => t.CommentText)
				.IsRequired()
				.HasMaxLength(500);

			builder.Property(t => t.CommentTimeStampUtc)
				.IsRequired();
			
			builder.Property(t => t.CommentLastEditedTimeStampUtc)
				.IsOptional();

			builder.Property(t => t.CommentTimeStart)
				.IsOptional();

			builder.Property(t => t.CommentTimeEnd)
				.IsOptional();

			builder.Property(t => t.PlaybackLength)
				.IsOptional();
		}
	}
}
