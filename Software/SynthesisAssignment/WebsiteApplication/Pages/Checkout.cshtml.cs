using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebsiteApplication.Models;

namespace WebsiteApplication.Pages
{
    public class CheckoutModel : PageModel
    {
        public List<OrderProduct> cart { get; set; } 
        public decimal Total { get; set; }
        public void OnGet()
        {
            cart = HttpContext.Session.GetObjectFromJson("cart");
            foreach (OrderProduct product in cart)
            {
                Total += product.Price;
            }
        }

        public IActionResult OnPostOrder()
        {
            Order order = new Order(HttpContext.Session.GetObjectFromJson("cart"), Total);
            OrderManager orderManager = new OrderManager();
            orderManager.AddOrder(order.OrderDate, order.EnumOrderStatus, order.Total, order.Products);
            return RedirectToPage("Receipt");
        }
    }
}
