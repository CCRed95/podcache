using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
  public class ArchiveFileTypeInfoMap
    : IEntityTypeConfiguration<ArchiveFileTypeInfo>
  {
    public void Configure(
      EntityTypeBuilder<ArchiveFileTypeInfo> builder)
    {
      builder.ToTable("ArchiveFileTypeInfos");

      builder.HasKey(t => t.ArchiveFileTypeInfoID);
      builder.Property<int>(t => t.ArchiveFileTypeInfoID)
        .IsRequired()
        .ValueGeneratedOnAdd();

      builder.Property<string>(t => t.Extension)
        .IsRequired()
        .HasMaxLength(20);

      builder.Property<string>(t => t.Description)
        .IsRequired()
        .HasMaxLength(200);
    }
  }
}
