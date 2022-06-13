using System.Linq;

namespace SachViet.Models
{
    public class EFBooksLibRepository : IBooksLibRepository
    {
        private BooksLibDbContext context;
        public EFBooksLibRepository(BooksLibDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Book> Books => context.Books;

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }
    }
}