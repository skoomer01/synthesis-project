using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class SubcategoryProductsModel : PageModel
    {
        public List<Category> Subcategories { get; set; }
        public CategoryManager _categoryManager { get; set; }
        public void OnGet(int id)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            _categoryManager = new CategoryManager(categoryRepository);
            Subcategories = _categoryManager.GetSubCategories(id);           
        }
    }
}
