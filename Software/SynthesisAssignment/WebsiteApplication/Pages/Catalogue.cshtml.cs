using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class CatalogueModel : PageModel
    {
        public ProductManager ProductManager { get; set; }
        public List<Product> Products { get; set; }


        public void OnGet()
        {
            ProductManager = new ProductManager();
            Products = ProductManager.Products;
        }
    }
}
