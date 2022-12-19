using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace WebsiteApplication.Pages
{
    public class SubCategoryProductsModel : PageModel
    {
        public ProductManager ProductManager { get; set; }
        public List<Product> SubcategoryProducts { get; set; }
        public UserManager userManager { get; set; }
        public int? UserId { get; set; }
        public void OnGet(string name)
        {
            if(name != null)
            {
                ProductRepository productRepository = new ProductRepository();
                ProductManager = new ProductManager(productRepository);
                SubcategoryProducts = ProductManager.GetProductsBySubcategory(name);
            }
            else { SubcategoryProducts = new List<Product>(); }
            
        }
        public IActionResult OnPostFavorite(int id, string name)
        {
            ProductRepository productRepository = new ProductRepository();
            ProductManager = new ProductManager(productRepository);
            UserRepository userRepository = new UserRepository();
            userManager = new UserManager(userRepository);
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
            SubcategoryProducts = ProductManager.GetProductsBySubcategory(name);
            return Page();
        }
    }
}
