using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class ReceiptModel : PageModel
    {
        public UserManager userManager { get; set; }
        public int? UserID { get; set; }
        public User user { get; set; }
        public List<Order> orders { get; set; }
        public OrderManager orderManager { get; set; }
        public void OnGet()
        {
            UserRepository userRepository = new UserRepository();
            userManager = new UserManager(userRepository);
            if (HttpContext.Session.Get("UserID") != null)
            {
                UserID = HttpContext.Session.GetInt32("UserID");
                user = userManager.GetUserByID(UserID);
                OrderRepository orderRepository = new OrderRepository();
                orderManager = new OrderManager(orderRepository);
                orders = orderManager.GetUserOrders((int)UserID);
            }
        }
    }
}
