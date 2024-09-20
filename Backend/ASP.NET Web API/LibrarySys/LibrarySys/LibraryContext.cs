using LibrarySys.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarySys
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasKey(b => b.Code); // Ensure 'Code' is the primary key

            modelBuilder.Entity<Book>().HasData(
                new Book { Code = "JK-45", Title = "Harry Potter", Author = "J.K Rowling", Stock = 1 },
                new Book { Code = "SHR-1", Title = "A Study in Scarlet", Author = "Arthur Conan Doyle", Stock = 1 },
                new Book { Code = "TW-11", Title = "Twilight", Author = "Stephenie Meyer", Stock = 1 },
                new Book { Code = "HOB-83", Title = "The Hobbit, or There and Back Again", Author = "J.R.R. Tolkien", Stock = 1 },
                new Book { Code = "NRN-7", Title = "The Lion, the Witch and the Wardrobe", Author = "C.S. Lewis", Stock = 1 }
            );

            modelBuilder.Entity<Borrowing>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Borrowing>()
                .HasOne(b => b.Book)
                .WithMany()
                .HasForeignKey(b => b.BookCode);

            modelBuilder.Entity<Borrowing>()
                .HasOne(b => b.Member)
                .WithMany()
                .HasForeignKey(b => b.MemberCode);

            modelBuilder.Entity<Member>()
                .HasKey(m => m.Code);

            modelBuilder.Entity<Member>()
                .HasData(
                    new Member { Code = "M001", Name = "Angga" },
                    new Member { Code = "M002", Name = "Ferry" },
                    new Member { Code = "M003", Name = "Putri" }
                );
        }
    }
}
