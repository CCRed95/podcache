using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
	public class ShowRundownCsvEntryMap
		: IEntityTypeConfiguration<ShowRundownCsvEntry>
	{
		/// <inheritdoc />
		public void Configure(
			EntityTypeBuilder<ShowRundownCsvEntry> builder)
		{
			builder.ToTable("ShowRundownCsvEntries");

			builder.HasKey(t => t.ShowRundownCsvEntryID);
			builder.Property(t => t.ShowRundownCsvEntryID)
				.IsRequired()
				.ValueGeneratedOnAdd();
			
			builder.Property(t => t.AuthorName)
				.IsOptional();

			builder.Property(t => t.LongText)
				.IsOptional();
			
			builder.Property(t => t.Title)
				.IsOptional();

			builder.Property(t => t.DateTime)
				.IsOptional();

			builder.Property(t => t.DateTimeEnd)
				.IsOptional();
		}
	}
}
