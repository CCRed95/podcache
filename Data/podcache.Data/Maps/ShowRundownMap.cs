using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
  public class ShowRundownMap
    : IEntityTypeConfiguration<ShowRundown>
  {
    public void Configure(
      EntityTypeBuilder<ShowRundown> builder)
    {
      builder.ToTable("ShowRundowns");

      builder.HasKey(t => t.ShowRundownID);
      builder.Property(t => t.ShowRundownID)
        .IsRequired()
        .ValueGeneratedOnAdd();

      builder.Property(t => t.ShowRundownName)
        .HasMaxLength(200)
        .IsRequired();

      builder.Property(t => t.ShowRundownContent)
        .HasMaxLength(500)
        .IsOptional();

      builder.Property(t => t.AirDate)
        .IsRequired();

      builder.Property(t => t.DetailsUrl)
        .IsRequired();
    }
  }
}
