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
        public OrderProduct OrderProduct { get; set; }
        public decimal Total { get; set; }
        public UserManager userManager { get; set; }
        public int? UserID { get; set; }
        public User user { get; set; }
        public void OnGet() { }
        public void OnGetCheckout(decimal total)
        {
            cart = HttpContext.Session.GetObjectFromJson("cart");
            foreach (OrderProduct product in cart)
            {
                Total += product.Price;
            }
            
        }

        public IActionResult OnPostOrder(decimal total)
        {
            if (ModelState.IsValid)
            {
                UserRepository userRepository = new UserRepository();
                userManager = new UserManager(userRepository);
                if (HttpContext.Session.Get("UserID") != null)
                {
                    UserID = HttpContext.Session.GetInt32("UserID");
                    cart = HttpContext.Session.GetObjectFromJson("cart");
                    foreach (OrderProduct product in cart)
                    {
                        Total += product.Price;
                    }
                    Order order = new Order((int)UserID,cart, BillingAdress.Name, BillingAdress.PostalCode, BillingAdress.Email, Total);
                    OrderRepository orderRepository = new OrderRepository();
                    OrderManager orderManager = new OrderManager(orderRepository);
                    orderManager.AddOrder(order.UserId,order.OrderDate, order.EnumOrderStatus, order.Total, order.Products, order.Name, order.Email, order.PostalCode);
                    HttpContext.Session.Remove("cart");
                    return RedirectToPage("Index");
                }
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
