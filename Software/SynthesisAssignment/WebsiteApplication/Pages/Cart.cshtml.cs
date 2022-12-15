using LogicLayer;
using WebsiteApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class CartModel : PageModel
    {
        public List<Product>? cart { get; set; }
        public decimal Total { get; set; }
        [BindProperty]
        public Dictionary<int, int> productsQuantity { get; set; }
        public void OnGet()
        {
            cart = HttpContext.Session.GetObjectFromJson("cart");
            if (cart is null)
            {
                cart = new List<Product>();
            }
            else
            {
                foreach (Product product in cart)
                {
                    Total += product.Price;
                }
            }
        }

        public IActionResult OnGetCart(string id)
        {
            ProductManager productManager = new ProductManager();
            cart = HttpContext.Session.GetObjectFromJson("cart");
            if (cart == null)
            {
                cart = new List<Product>();
                int x = Int32.Parse(id);
                cart.Add(productManager.GetProduct(x));
                SessionHepler.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = Exists(cart, id);
                if (index == -1)
                {
                    int x = Int32.Parse(id);
                    cart.Add(productManager.GetProduct(x));
                }
                SessionHepler.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("Cart");
        }

        public IActionResult OnGetDelete(string id)
        {
            cart = SessionHepler.GetObjectFromJson(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHepler.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        private int Exists(List<Product> cart, string id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Id == Convert.ToInt32(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
