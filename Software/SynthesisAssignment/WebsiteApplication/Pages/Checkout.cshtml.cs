using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebsiteApplication.Models;

namespace WebsiteApplication.Pages
{
    public class CheckoutModel : PageModel
    {
        [BindProperty]
        public BillingAdress BillingAdress { get; set; }
        public List<OrderProduct> cart { get; set; } 
        public decimal Total { get; set; }
        public void OnGet() { }
        public void OnGetCheckout(decimal total)
        {
            cart = HttpContext.Session.GetObjectFromJson("cart");
            Total = total;  
        }

        public IActionResult OnPostOrder(decimal total)
        {
            if(ModelState.IsValid)
            {
                Order order = new Order(HttpContext.Session.GetObjectFromJson("cart"), total);
                OrderManager orderManager = new OrderManager();
                orderManager.AddOrder(order.OrderDate, order.EnumOrderStatus, order.Total, order.Products, BillingAdress.Name, BillingAdress.Email, BillingAdress.PostalCode);
                return RedirectToPage("Index");
            }
            else
            {
                cart = HttpContext.Session.GetObjectFromJson("cart");
                Total = total;
                ModelState.AddModelError("WrongCredentials", "Invalid creditentials for the billing address");
            }
            return Page();
        }
    }
}
