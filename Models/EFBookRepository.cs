
namespace mission11_benZapata4_6.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookContext _context;
        public EFBookRepository(BookContext temp) {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
