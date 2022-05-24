using AkinTestEF.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AkinTestEF.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasData(
                    new Student { StudentId = 1, FirstName = "Akin", LastName = "Ozkan" },
                    new Student { StudentId = 2, FirstName = "Sagar", LastName = "Bhanadari" },
                    new Student { StudentId = 3, FirstName = "Fatih", LastName = "Ozer" },
                    new Student { StudentId = 4, FirstName = "Florian", LastName = "Esprit" }
                );

            modelBuilder.Entity<Book>()
                .HasData
                (
                new Book { BookId = 1, Title = " In Search of Lost Time", Published = new DateTime(1913, 02, 01), StudentId = 1 },
                new Book { BookId = 2, Title = "Ulysses", Published = new DateTime(1904, 06, 16), StudentId = 1 },
                new Book { BookId = 3, Title = " Don Quixote", Published = new DateTime(1605, 01, 01), StudentId = 2 },
                new Book { BookId = 4, Title = " One Hundred Years of Solitude", Published = new DateTime(1967, 01, 14), StudentId = 3 }
                );

            modelBuilder.Entity<Author>()
              .HasData
              (
              new Author { AuthorId = 1, Name = "Marcel", SurName = "Proust" },
              new Author { AuthorId = 2, Name = "James", SurName = "Joyce" },
              new Author { AuthorId = 3, Name = "Miguel", SurName = "Cervantes" },
              new Author { AuthorId = 4, Name = "Gabriel Garcia", SurName = "Marquez" }
              );

            modelBuilder.Entity<AuthorBook>()
               .HasData
               (
               new AuthorBook { AuthorBookId = 1, AuthorId = 1, BookId = 1 },
               new AuthorBook { AuthorBookId = 2, AuthorId = 2, BookId = 2 },
               new AuthorBook { AuthorBookId = 3, AuthorId = 3, BookId = 3 },
               new AuthorBook { AuthorBookId = 4, AuthorId = 4, BookId = 4 },
               new AuthorBook { AuthorBookId = 5, AuthorId = 3, BookId = 4 }
               );

            
            modelBuilder.Entity<AuthorBook>()
                .HasKey(ab => new { ab.BookId, ab.AuthorId });
           
            modelBuilder.Entity<AuthorBook>()
                .HasOne<Book>(ab => ab.Book)
                .WithMany(b => b.AuthorBooks)
                .HasForeignKey(b => b.BookId);

            modelBuilder.Entity<AuthorBook>()
              .HasOne<Author>(ab => ab.Author)
              .WithMany(b => b.AuthorBooks)
              .HasForeignKey(b => b.AuthorId);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
    }
}
