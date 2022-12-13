using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class SubCategoryProductsModel : PageModel
    {
        public ProductManager ProductManager { get; set; }
        public List<Product> SubcategoryProducts { get; set; }
        public void OnGet(string name)
        {
            ProductManager = new ProductManager();
            SubcategoryProducts = ProductManager.GetProductsBySubcategory(name);
        }
    }
}
