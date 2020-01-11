using BookRequests.Desktop.Models;
using System.Data.Entity;

namespace BookRequests.Desktop
{
    public class BookContext : DbContext
    {
        public BookContext() : base("name=BookDBConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookRequest> BookRequests { get; set; }

    }
}
