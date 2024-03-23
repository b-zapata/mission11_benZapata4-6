using Microsoft.EntityFrameworkCore;

namespace mission11_benZapata4_6.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        public DbSet<Book> Books { get; set;}
    }
}
