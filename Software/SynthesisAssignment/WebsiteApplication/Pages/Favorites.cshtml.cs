using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class FavoritesModel : PageModel
    {
        public ProductManager _productManager { get; set; }
        public UserManager userManager { get; set; }
        public int? UserID { get; set; }
        public User user { get; set; }
        public List<Product> Favorites { get; set; }
        public FavoriteManager FavoriteManager { get; set; }

        public void OnGet()
        {
            Favorites = new List<Product>();
            _productManager = new ProductManager();
            UserRepository userRepository = new UserRepository();
            FavoriteManager = new FavoriteManager();
            userManager = new UserManager();
            if (HttpContext.Session.Get("UserID") != null)
            {
                UserID = HttpContext.Session.GetInt32("UserID");
                Favorites = FavoriteManager.GetAllFavorites((int)UserID);
            }
        }

        public void OnPostRemove()
        {
            Favorites = new List<Product>();
            _productManager = new ProductManager();
            userManager = new UserManager();
            FavoriteManager = new FavoriteManager();
            if (HttpContext.Session.Get("UserID") != null)
            {

                UserID = HttpContext.Session.GetInt32("UserID");
                Favorites = FavoriteManager.GetAllFavorites((int)UserID);            
                int id = Convert.ToInt32(Request.Form["id"]);
                FavoriteManager.RemoveFavorite(id, (int)UserID);
            }
        }
    }
}
