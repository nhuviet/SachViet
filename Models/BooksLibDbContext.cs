using Microsoft.EntityFrameworkCore;

namespace SachViet.Models
{
    public class BooksLibDbContext : DbContext
    {
        public BooksLibDbContext(DbContextOptions<BooksLibDbContext>options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
