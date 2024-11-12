using Microsoft.EntityFrameworkCore;


namespace MyVersionControl.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<Commit> Commits { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Modification> Modifications { get; set; }
        public DbSet<PullRequest> PullRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Repository>()
                .HasIndex(r => r.Title)
                .IsUnique();

            modelBuilder.Entity<Repository>()
                .HasOne(r => r.Owner)
                .WithMany(u => u.Repositories)
                .HasForeignKey(r => r.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Repository>()
                .HasMany(r => r.Contributors)
                .WithMany(u => u.ContributedRepositories)
                .UsingEntity(j => j.ToTable("RepositoryContributors"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
