using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class OverviewModel : PageModel
    {
        public ProductManager ProductManager { get; set; }
        public Product Product { get; set; }
        public void OnGet(int id)
        {
            ProductRepository productRepository = new ProductRepository();
            ProductManager = new ProductManager(productRepository);
            Product = ProductManager.GetProduct(id);

        }
    }
}
