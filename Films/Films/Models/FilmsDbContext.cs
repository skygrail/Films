using Microsoft.EntityFrameworkCore;

namespace Films.Models
{
    public class FilmsDbContext : DbContext
    {
        public FilmsDbContext(DbContextOptions<FilmsDbContext> options):base(options)
        {
            
        }

        public DbSet<Categoryies> Categoryies { get; set; }

        public DbSet<Chats> Chats { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Companies> Companies { get; set; }

        public DbSet<Contries> Contries { get; set; }

        public DbSet<Facts> Facts { get; set; }

        public DbSet<Film> Film { get; set; }

        public DbSet<Messages> Messages { get; set; }

        public DbSet<Party> Party { get; set; }

        public DbSet<Users> Users { get; set; }
      
        public DbSet<UsersFilms> UsersFilms { get; set; }

        public DbSet<UsersLogins> UsersLogins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasOne(a => a.UsersLogins)
                .WithOne(b => b.User)
                .HasForeignKey<UsersLogins>(b => b.ID);
        }
    }
}
