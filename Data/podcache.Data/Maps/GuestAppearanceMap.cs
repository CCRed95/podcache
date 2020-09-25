using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
  public class GuestAppearanceMap
    : IEntityTypeConfiguration<GuestAppearance>
  {
    public void Configure(
      EntityTypeBuilder<GuestAppearance> builder)
    {
      builder.ToTable("GuestAppearances");

      builder.HasKey(t => t.GuestAppearanceID);
      builder.Property(t => t.GuestAppearanceID)
             .IsRequired()
             .ValueGeneratedOnAdd();
			
			builder.Property(t => t.GuestID)
        .IsOptional();

      builder.Property(t => t.ShowMediaEntryID)
        .IsOptional();

      builder.Property(t => t.SegmentTimeStart)
        .IsOptional();

      builder.Property(t => t.SegmentTimeEnd)
        .IsOptional();
    }
  }
}