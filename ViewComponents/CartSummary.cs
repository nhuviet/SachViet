using Microsoft.AspNetCore.Mvc;
using SachViet.Models;

namespace SachViet.ViewComponents
{
    public class CartSummary : ViewComponent
    {
        private MyCart cart;
        public CartSummary(MyCart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
