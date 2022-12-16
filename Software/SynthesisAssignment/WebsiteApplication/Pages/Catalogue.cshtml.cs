using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class CatalogueModel : PageModel
    {
        public ProductManager ProductManager { get; set; }
        public UserManager userManager { get; set; }
        public List<Product> Products { get; set; }
        public int? UserId { get; set; }

        public void OnGet()
        {
            ProductManager = new ProductManager();
            Products = ProductManager.Products;
        }

        public IActionResult OnPostFavorite(int id)
        {
            ProductManager = new ProductManager();
            UserRepository userRepository = new UserRepository();
            userManager = new UserManager();
            if (HttpContext.Session.Get("UserID") != null)
            {
                UserId = HttpContext.Session.GetInt32("UserID");
                User user = userManager.GetUserByID(UserId);
                FavoriteManager favoriteManager = new FavoriteManager();
                if (favoriteManager.IsAlreadyFavorite(id, (int)UserId) == true)
                {
                    favoriteManager.AddFavorite(id, (int)UserId);
                }
            }
            Products = ProductManager.Products;
            return Page();
        }
    }
}
