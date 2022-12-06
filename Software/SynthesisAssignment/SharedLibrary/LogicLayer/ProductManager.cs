using SharedLibrary.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.LogicLayer
{
    public class ProductManager
    {
        private List<Product> products;
        private ProductRepository productRepository = new ProductRepository();

        public ProductManager()
        {
            products = GetAllProducts();
        }
        public List<Product> Products { get { return products; } set { this.products = value; } }
        public List<Product> GetAllProducts()
        {
            return productRepository.GetProducts();
        }

        public void AddProduct(string name, string category, string subcategory, decimal price, string unit, string productImage)
        {
            productRepository.CreateProduct(name, category, subcategory, price, unit, productImage);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.UpdateProduct(product);
        }

        public Product GetProduct(int id)
        {
            return productRepository.GetProductByID(id);
        }

        public void DeleteProduct(Product product)
        {
            productRepository.DeleteProduct(product);
        }
    }
}
