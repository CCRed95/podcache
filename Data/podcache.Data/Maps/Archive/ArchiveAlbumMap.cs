using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
  public class ArchiveAlbumMap
    : IEntityTypeConfiguration<ArchiveAlbum>
  {
    public void Configure(
      EntityTypeBuilder<ArchiveAlbum> builder)
    {
      builder.ToTable("ArchiveAlbums");

      builder.HasKey(t => t.ArchiveAlbumID);
      builder.Property(t => t.ArchiveAlbumID)
        .IsRequired()
        .ValueGeneratedOnAdd();

      builder.Property(t => t.Identifier)
        .IsRequired()
        .HasMaxLength(200);

      builder.Property(t => t.Description)
        .IsOptional()
        .HasMaxLength(500);

      builder.Property(t => t.DatePublished)
        .IsRequired();

      builder.Property(t => t.YearNumber)
        .IsRequired();

      builder.Property(t => t.MonthNumber)
        .IsRequired();

      builder.Ignore(t => t.AlbumFileContentsUrl);
    }
  }
}
