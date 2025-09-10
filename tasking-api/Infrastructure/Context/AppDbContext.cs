using Microsoft.EntityFrameworkCore;
using tasking_api.Main.Models;

namespace tasking_api.Infrastructure.Context
{
    public sealed class AppDbContext : DbContext
    {
        public DbSet<Board> Boards => Set<Board>();
        public DbSet<BoardTask> BoardTasks => Set<BoardTask>();
        public DbSet<User> Users => Set<User>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Board configuration
            modelBuilder.Entity<Board>(entity =>
            {
                entity.HasKey(b => b.Id);
                entity.Property(b => b.Id).ValueGeneratedOnAdd();
                entity.Property(b => b.Name).IsRequired().HasMaxLength(200);
                entity.Property(b => b.Description).HasMaxLength(1000);
                entity.Property(b => b.OwnerId).IsRequired();
                
                // One-to-many relationship: Board has many BoardTasks
                entity.HasMany(b => b.Tasks)
                      .WithOne()
                      .HasForeignKey(t => t.BoardId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // BoardTask configuration  
            modelBuilder.Entity<BoardTask>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();
                entity.Property(t => t.Name).IsRequired().HasMaxLength(200);
                entity.Property(t => t.Description).HasMaxLength(1000);
                entity.Property(t => t.BoardId).IsRequired();
                entity.Property(t => t.Deadline);
            });

            // User configuration
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).ValueGeneratedOnAdd();
                entity.Property(u => u.Username).IsRequired().HasMaxLength(50);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(100);
                entity.Property(u => u.PasswordHash).IsRequired().HasMaxLength(255);
                entity.Property(u => u.CreatedAt).IsRequired();
                entity.Property(u => u.LastLoginAt);
                
                // Unique constraints
                entity.HasIndex(u => u.Username).IsUnique();
                entity.HasIndex(u => u.Email).IsUnique();
            });

            // Apply any additional configurations from assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        // IUnitOfWork pattern
        public new Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) 
            => base.SaveChangesAsync(cancellationToken);
    }
}
