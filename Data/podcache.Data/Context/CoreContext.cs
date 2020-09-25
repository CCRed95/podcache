using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using podcache.Data.Core.Extensions;
using podcache.Data.Domain;
using podcache.Data.Maps;

namespace podcache.Data.Context
{
	public class CoreContext
		: IdentityDbContext<IdentityUser>
	{
		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ArchiveAlbum"/> entities. 
		/// </summary>
		public DbSet<ArchiveAlbum> ArchiveAlbums { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ArchiveFile"/> entities. 
		/// </summary>
		public DbSet<ArchiveFile> ArchiveFiles { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ArchiveFileTypeInfo"/> entities. 
		/// </summary>
		public DbSet<ArchiveFileTypeInfo> ArchiveFileTypeInfos { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ContentCreator"/> entities. 
		/// </summary>
		public DbSet<ContentCreator> ContentCreators { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="AudibleMediaItem"/> entities. 
		/// </summary>
		public DbSet<AudibleMediaItem> AudibleMediaItems { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="EmbeddedContentSource"/> entities. 
		/// </summary>
		public DbSet<EmbeddedContentSource> EmbeddedContentSources { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="Gender"/> entities. 
		/// </summary>
		public DbSet<Gender> Genders { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="Guest"/> entities. 
		/// </summary>
		public DbSet<Guest> Guests { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="GuestAppearance"/> entities. 
		/// </summary>
		public DbSet<GuestAppearance> GuestAppearances { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="GuestAppearanceType"/> entities. 
		/// </summary>
		public DbSet<GuestAppearanceType> GuestAppearanceTypes { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="Host"/> entities. 
		/// </summary>
		public DbSet<Host> Hosts { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="Show"/> entities. 
		/// </summary>
		public DbSet<Show> Shows { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ShowMediaSegmentContentTag"/> entities. 
		/// </summary>
		public DbSet<ShowMediaSegmentContentTag> ShowMediaSegmentContentTags { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ShowHost"/> entities. 
		/// </summary>
		public DbSet<ShowHost> ShowHosts { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ShowMediaEntry"/> entities. 
		/// </summary>
		public DbSet<ShowMediaEntry> ShowMediaEntries { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ShowRundown"/> entities. 
		/// </summary>
		public DbSet<ShowRundown> ShowRundowns { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ShowRundownAuthor"/> entities. 
		/// </summary>
		public DbSet<ShowRundownAuthor> ShowRundownAuthors { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="PatreonMediaPost"/> entities. 
		/// </summary>
		public DbSet<PatreonMediaPost> PatreonMediaPosts { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ShoutEngineMediaPost"/> entities. 
		/// </summary>
		public DbSet<ShoutEngineMediaPost> ShoutEngineMediaPosts { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ShowRundownCsvEntry"/> entities. 
		/// </summary>
		public DbSet<ShowRundownCsvEntry> ShowRundownCsvEntries { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="ShowRundownTag"/> entities. 
		/// </summary>
		public DbSet<ShowRundownTag> ShowRundownTags { get; set; }

		/// <summary>
		///	The database table <see cref="DbSet{TEntity}"/>, containing <see cref="UserCreatedPlaylist"/> entities. 
		/// </summary>
		public DbSet<UserCreatedPlaylist> UserCreatedPlaylists { get; set; }



		public CoreContext() : this(
			new DbContextOptionsBuilder<CoreContext>().Options)
		{
		}

		public CoreContext(
			DbContextOptions options)
				: base(options)
		{
		}


		protected override void OnConfiguring(
			DbContextOptionsBuilder optionsBuilder)
		{
			//todo should base call be moved back 
			var local = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=podcache;Integrated Security=True";
			optionsBuilder.UseSqlServer(local);

			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(
			ModelBuilder modelBuilder)
		{
			modelBuilder
				.HasDefaultSchema("dbo");

			base.OnModelCreating(modelBuilder);

			modelBuilder
				.WithConfiguration<ArchiveAlbum, ArchiveAlbumMap>()
				.WithConfiguration<ArchiveFile, ArchiveFileMap>()
				.WithConfiguration<ArchiveFileTypeInfo, ArchiveFileTypeInfoMap>()
				.WithConfiguration<ContentCreator, ContentCreatorMap>()
				.WithConfiguration<AudibleMediaItem, AudibleMediaItemMap>()
				.WithConfiguration<EmbeddedContentSource, EmbeddedContentSourceMap>()
				.WithConfiguration<Gender, GenderMap>()
				.WithConfiguration<Guest, GuestMap>()
				.WithConfiguration<GuestAppearance, GuestAppearanceMap>()
				.WithConfiguration<GuestAppearanceType, GuestAppearanceTypeMap>()
				.WithConfiguration<Host, HostMap>()
				.WithConfiguration<Show, ShowMap>()
				.WithConfiguration<ShowMediaSegmentContentTag, ShowMediaSegmentContentTagMap>()
				.WithConfiguration<ShowHost, ShowHostMap>()
				.WithConfiguration<ShowMediaEntry, ShowMediaEntryMap>()
				.WithConfiguration<ShowRundown, ShowRundownMap>()
				.WithConfiguration<ShowRundownAuthor, ShowRundownAuthorMap>()
				.WithConfiguration<PatreonMediaPost, PatreonMediaPostMap>()
				.WithConfiguration<ShoutEngineMediaPost, ShoutEngineMediaPostMap>()
				.WithConfiguration<ShowRundownTag, ShowRundownTagMap>()
				.WithConfiguration<UserCreatedPlaylist, UserCreatedPlaylistMap>();

			modelBuilder.Entity<GuestAppearance>(builder =>
			{
				builder
					.HasOne(t => t.ShowMediaEntry)
					.WithMany(t => t.GuestAppearances)
					.HasForeignKey(t => t.ShowMediaEntryID);
			});

			//modelBuilder.Entity<Guest>(builder =>
			//{
			//  builder.HasOne(t => t.ShowAppearances)
			//    .WithMany(t => t.)
			//    .HasForeignKey(t => t.ShowMediaEntryID);

			//});

			modelBuilder.Entity<ShowHost>(builder =>
			{
				builder.HasKey(t => new { t.ShowID, t.HostID });

				builder.HasOne(sh => sh.Show)
							 .WithMany(s => s.ShowHosts)
							 .HasForeignKey(sh => sh.ShowID);

				builder.HasOne(sh => sh.Host)
							 .WithMany(h => h.ShowHosts)
							 .HasForeignKey(sh => sh.HostID);
			});

			//modelBuilder.Entity<Guest>(builder =>
			//{
			//  builder.HasOne(t => t.ShowAppearances)
			//   .WithOne(t => t.)
			//   .HasForeignKey(t => t.ShowMediaEntryID);

			//});
		}
		// protected override void OnModelCreating(
		//    DbModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);

		//  modelBuilder
		//      .Configurations
		//      .AddFromAssembly(
		//        GetType()
		//          .Assembly);

		//    modelBuilder
		//      .Conventions
		//      .Add(new DataTypePropertyAttributeConvention());

		//  //  modelBuilder
		//		//.Entity<GuestAppearance>()
		//		//.HasRequired(t => t.ShowRundown)
		//		//.WithMany(t => t.GuestApperances)
		//		//.HasForeignKey(t => t.ShowRundownID);
		//}
	}
}
