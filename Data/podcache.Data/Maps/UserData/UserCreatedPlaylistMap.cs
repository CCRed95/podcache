using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using podcache.Data.Domain;

namespace podcache.Data.Maps
{
	public class UserCreatedPlaylistMap
		: IEntityTypeConfiguration<UserCreatedPlaylist>
	{
		/// <inheritdoc />
		public void Configure(
			EntityTypeBuilder<UserCreatedPlaylist> builder)
		{
			builder.ToTable("UserCreatedPlaylists");

			builder.HasKey(t => t.UserCreatedPlaylistID);
			builder.Property(t => t.UserCreatedPlaylistID)
				.IsRequired()
				.ValueGeneratedOnAdd();
			
			builder.Property(t => t.UserCreatedPlaylistName)
				.IsRequired()
				.HasMaxLength(500);

			builder.Property(t => t.UserName)
				.IsRequired();
		}
	}
}
