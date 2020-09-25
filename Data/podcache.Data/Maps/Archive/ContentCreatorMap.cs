using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
  public class ContentCreatorMap
    : IEntityTypeConfiguration<ContentCreator>
  {
    public void Configure(
      EntityTypeBuilder<ContentCreator> builder)
    {
      builder.ToTable("ContentCreators");

      builder.HasKey(t => t.ContentCreatorID);
      builder.Property<int>(t => t.ContentCreatorID)
        .IsRequired()
        .ValueGeneratedOnAdd();

      builder.Property<string>(t => t.ContentCreatorName)
        .IsRequired()
        .HasMaxLength(50);
    }
  }
}
