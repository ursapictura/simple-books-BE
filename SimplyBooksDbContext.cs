using Microsoft.EntityFrameworkCore;
using SimplyBooks.Data;
using SimplyBooks.Models;

    public class SimplyBooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }

       public SimplyBooksDbContext(DbContextOptions<SimplyBooksDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(BookData.Books);
            modelBuilder.Entity<Author>().HasData(AuthorData.Authors);
            modelBuilder.Entity<User>().HasData(UserData.Users);


            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);
        }
    }
