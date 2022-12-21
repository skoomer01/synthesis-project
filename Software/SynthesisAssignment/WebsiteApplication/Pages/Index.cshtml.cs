using DataLayer;
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
        public AdvertisementManager AdvertisementManager { get; set; }
        public ProductManager ProductManager { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            UserRepository userRepository = new UserRepository();
            UserManager = new UserManager(userRepository);
            ProductRepository productRepository = new ProductRepository();
            AdvertisementRepo advertisementRepo = new AdvertisementRepo();
            AdvertisementManager = new AdvertisementManager(advertisementRepo, productRepository);
            if (HttpContext.Session.Get("UserID") != null)
            {
                UserID = HttpContext.Session.GetInt32("UserID");
            }
        }
    }
}