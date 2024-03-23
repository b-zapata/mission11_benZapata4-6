namespace mission11_benZapata4_6.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
