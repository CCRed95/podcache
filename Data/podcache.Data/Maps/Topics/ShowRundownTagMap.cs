using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
	public class ShowRundownTagMap
		: IEntityTypeConfiguration<ShowRundownTag>
	{
		/// <inheritdoc />
		public void Configure(
			EntityTypeBuilder<ShowRundownTag> builder)
		{
			builder.ToTable("ShowRundownTags");

			builder.HasKey(t => t.ShowRundownTagID);
			builder.Property(t => t.ShowRundownTagID)
				.IsRequired()
				.ValueGeneratedOnAdd();
			
			builder.Property(t => t.ShowRundownTagKind)
				.IsRequired()
				.HasMaxLength(500);

			builder.HasIndex(t => t.ShowRundownTagKind)
				.HasName("UIX_ShowRundownTag_ShowRundownTagKind")
				.IsUnique();
		}
	}

	//public partial class ShowRundownTagKind 
	//	: ISeedableEntity
	//{
	//	public ShowRundownTagKind Person

	//}

	//public partial class ShowRundownTagKind
	//{
	//	public int ShowRundownTagKindID { get; set; }

	//	public string ShowRundownTagName { get; set; }
	//}
}

