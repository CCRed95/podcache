using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
  public class ShowMediaSegmentContentTagMap
    : IEntityTypeConfiguration<ShowMediaSegmentContentTag>
  {
    public void Configure(
      EntityTypeBuilder<ShowMediaSegmentContentTag> builder)
    {
      builder.ToTable("ShowMediaSegmentContentTags");

      builder.HasKey(t => t.ShowMediaSegmentContentTagID);
      builder.Property(t => t.ShowMediaSegmentContentTagID)
	      .IsRequired()
	      .ValueGeneratedOnAdd();
      
      builder.Property(t => t.SegmentTimeStart)
        .IsRequired();

      builder.Property(t => t.SegmentTimeEnd)
        .IsOptional();
    }
  }
}