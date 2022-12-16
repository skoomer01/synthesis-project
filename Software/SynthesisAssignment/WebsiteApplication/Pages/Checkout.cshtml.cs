using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebsiteApplication.Models;

namespace WebsiteApplication.Pages
{
    public class CheckoutModel : PageModel
    {
        public List<Product> cart { get; set; } 
        public void OnGet()
        {
            ProductManager productManager = new ProductManager();
            cart = HttpContext.Session.GetObjectFromJson("cart");
            if (cart == null)
            {
                cart = new List<Product>();
                SessionHepler.SetObjectAsJson(HttpContext.Session, "cart", cart);
                if(cart.Count > 0)
                {

                }
            }
        }
    }
}
