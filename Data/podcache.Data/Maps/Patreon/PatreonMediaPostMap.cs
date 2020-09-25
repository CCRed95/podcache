using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
	public class PatreonMediaPostMap
		: IEntityTypeConfiguration<PatreonMediaPost>
	{
		public void Configure(
			EntityTypeBuilder<PatreonMediaPost> builder)
		{
			builder.ToTable("PatreonMediaPosts");

			builder.HasKey(t => t.PatreonMediaPostID);
			builder.Property(t => t.PatreonMediaPostID)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(t => t.Title)
				.IsRequired()
				.HasMaxLength(300);

			builder.Property(t => t.Summary)
				.IsRequired()
				.HasMaxLength(200);

			builder.Property(t => t.Body)
				.IsRequired()
				.HasMaxLength(200);

			builder.Property(t => t.DateTime)
				.IsRequired();

			builder.Property(t => t.FilePath)
				.IsRequired()
				.HasMaxLength(400);
		}
	}
}
