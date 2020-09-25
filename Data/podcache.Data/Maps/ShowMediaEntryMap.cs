using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
	public class ShowMediaEntryMap
		: IEntityTypeConfiguration<ShowMediaEntry>
	{
    public void Configure(
      EntityTypeBuilder<ShowMediaEntry> builder)
	  {
	    builder.ToTable("ShowMediaEntries");

	    builder.HasKey(t => t.ShowMediaEntryID);
	    builder.Property(t => t.ShowMediaEntryID)
	      .IsRequired()
	      .ValueGeneratedOnAdd();

			builder.Property(t => t.AirDate)
	      .IsRequired();

			//builder.HasOne(t => t.Show)
			//	.WithOne(t => t.)

      builder.Property(t => t.Title)
        .IsRequired()
        .HasMaxLength(400);

			builder.Property(t => t.Subtitle)
			  .IsOptional()
			  .HasMaxLength(1000);

			builder.Property(t => t.ShowIdentifier)
				.IsOptional()
				.HasMaxLength(100);

			builder.Property(t => t.EmbeddedContentSourceUrl)
	      .IsOptional()
	      .HasMaxLength(1000);

      builder.HasIndex(t => t.Title)
        .HasName("UIX_ShowMediaEntry_Title")
        .IsUnique();

      builder.HasIndex(t => t.ShowIdentifier)
	      .HasName("UIX_ShowMediaEntry_ShowIdentifier")
	      .IsUnique();
		}
	}
}
