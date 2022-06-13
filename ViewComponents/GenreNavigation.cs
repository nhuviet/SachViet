using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SachViet.Models;

namespace SachViet.ViewComponents
{
    public class GenreNavigation : ViewComponent
    {
        private IBooksLibRepository repository;
        public GenreNavigation(IBooksLibRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData?.Values["genre"];
            return View(repository.Books
                .Select(x => x.Genre)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}