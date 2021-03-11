using Microsoft.AspNetCore.Mvc;
using AmazonProj.Models;

//A Component that will assist in displaying the cart summary along the navbar on our pages
namespace AmazonProj.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}