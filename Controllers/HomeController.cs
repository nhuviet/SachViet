using SachViet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SachViet.Models.ViewModels;

namespace SachViet.Controllers
{
    public class HomeController : Controller
    {
        private IBooksLibRepository repository;
        public int PageSize = 4;
        public HomeController(IBooksLibRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(string genre, int bookPage = 1) => View
        (
            new BooksListViewModel
            {
                Books = repository.Books
                                  .Where(p => genre == null || p.Genre == genre)
                                  .OrderBy(p => p.BookID)
                                  .Skip((bookPage - 1) * PageSize)
                                  .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = bookPage,
                    ItemsPerPage = PageSize,
                    TotalItems = genre == null ? repository.Books.Count() : repository.Books.Where(e => e.Genre == genre).Count()
                },
                CurrentGenre = genre
            }
        );
    }
}
