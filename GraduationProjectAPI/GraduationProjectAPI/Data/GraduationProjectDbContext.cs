using Microsoft.EntityFrameworkCore;
using GraduationProjectAPI.Model;
using GraduationProjectAPI.Data;

namespace GraduationProjectAPI.Data
{
    public class GraduationProjectDbContext : DbContext
    {
        public GraduationProjectDbContext(DbContextOptions<GraduationProjectDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookLibrary> BookLibraries { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }
        public DbSet<Buybook> Buybooks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameUser> GameUsers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Model.Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<UserReference> UserReferences { get; set; }
        public DbSet<Writer> Writers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Follow>()
                .HasOne(m => m.follow)
                .WithMany(m => m.follow)
                .HasForeignKey(m => m.followId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Follow>()
                .HasOne(x => x.followed)
                .WithMany(x => x.followed)
                .HasForeignKey(x => x.followedId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
