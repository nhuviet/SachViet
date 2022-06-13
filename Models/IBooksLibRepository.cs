using System.Linq;

namespace SachViet.Models
{
    public interface IBooksLibRepository
    {
        IQueryable<Book> Books { get; }
        void SaveBook(Book b);
        void CreateBook(Book b);
        void DeleteBook(Book b);
    }
}