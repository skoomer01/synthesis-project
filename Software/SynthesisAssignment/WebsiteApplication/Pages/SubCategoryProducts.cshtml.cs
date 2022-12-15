using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
                ProductManager = new ProductManager();
                SubcategoryProducts = ProductManager.GetProductsBySubcategory(name);
            }
            else { SubcategoryProducts = new List<Product>(); }
            
        }
        public IActionResult OnPostFavorite()
        {
            ProductManager = new ProductManager();
            UserRepository userRepository = new UserRepository();
            userManager = new UserManager();
            if (HttpContext.Session.Get("UserID") != null)
            {
                UserId = HttpContext.Session.GetInt32("UserID");
                int id = Convert.ToInt32(Request.Form["id"]);
                User user = userManager.GetUserByID(UserId);
                FavoriteManager favoriteManager = new FavoriteManager();
                int productID = Convert.ToInt32(Request.Form["id"]);
                if (favoriteManager.IsAlreadyFavorite(productID, (int)UserId) == true)
                {
                    favoriteManager.AddFavorite(productID, (int)UserId);
                }
            }
            return Page();
        }
    }
}
