using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
	public class ShowMap
		: IEntityTypeConfiguration<Show>
	{
	  public void Configure(
      EntityTypeBuilder<Show> builder)
	  {
	    builder.ToTable("Shows");

	    builder.HasKey(t => t.ShowID);
	    builder.Property(t => t.ShowID)
	           .IsRequired()
             .ValueGeneratedOnAdd();
      
	    builder.Property(t => t.ShowName)
	           .IsRequired()
	           .HasMaxLength(300);
    }
  }
}
