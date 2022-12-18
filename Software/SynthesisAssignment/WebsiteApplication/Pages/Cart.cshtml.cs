using LogicLayer;
using WebsiteApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class CartModel : PageModel
    {
        public List<OrderProduct>? cart { get; set; }
        public decimal Total { get; set; }
        [BindProperty]
        public OrderProduct OrderProduct { get; set; }
        public void OnGet()
        {
            cart = HttpContext.Session.GetObjectFromJson("cart");
            if (cart is null)
            {
                cart = new List<OrderProduct>();
                OrderProduct = new OrderProduct();
            }
            else
            {
                foreach (OrderProduct product in cart)
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
                cart = new List<OrderProduct>();
                OrderProduct orderProduct = new OrderProduct(productManager.GetProduct(Convert.ToInt32(id)), 1);
                cart.Add(orderProduct);
                SessionHepler.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = Exists(id);
                if (index == -1)
                {
                    OrderProduct orderProduct = new OrderProduct(productManager.GetProduct(Convert.ToInt32(id)), quantity: 1);
                    cart.Add(orderProduct);
                }
                else
                {
                    cart.ElementAt(index).Quantity++;
                    cart.ElementAt(index).Price = cart.ElementAt(index).Quantity * cart.ElementAt(index).Product.Price;
                }
                SessionHepler.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("Cart");
        }

        public IActionResult OnGetDelete(string id)
        {
            cart = SessionHepler.GetObjectFromJson(HttpContext.Session, "cart");
            int index = Exists(id);
            cart.RemoveAt(index);//zice ca e out of collection indexul lol
            SessionHepler.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        private int Exists(string id)
        {
            List<OrderProduct> cart = SessionHepler.GetObjectFromJson(HttpContext.Session, "cart");
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart.ElementAt(i).Product.Id == Convert.ToInt32(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
