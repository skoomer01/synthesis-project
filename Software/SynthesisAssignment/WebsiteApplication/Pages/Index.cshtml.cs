using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class IndexModel : PageModel
    {
        public int? UserID { get; set; }
        public string Username { get; set; }
        public UserManager UserManager { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            UserManager = new UserManager();
            if (HttpContext.Session.Get("UserID") != null)
            {

                UserID = HttpContext.Session.GetInt32("UserId");
            }
        }
    }
}