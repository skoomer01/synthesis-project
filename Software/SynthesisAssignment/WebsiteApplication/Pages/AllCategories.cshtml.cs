using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class AllCategoriesModel : PageModel
    {
        public CategoryManager CategoryManager { get; set; }
        public List<Category> Categories { get; set; }
        public void OnGet()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            CategoryManager = new CategoryManager(categoryRepository);
            Categories = CategoryManager.GetAllCategories();
        }
    }
}
