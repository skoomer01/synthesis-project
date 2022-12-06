using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class ProductManager
    {
        private List<Product> products;
        private ProductRepository productRepository = new ProductRepository();

        public ProductManager()
        {
            products = GetAllProducts();
        }
        public List<Product> Products { get { return products; } set { products = value; } }
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            foreach(ProductDTO productDTO in productRepository.GetProducts())
            {
                Product product = new Product(productDTO);
                products.Add(product);
            }
            return products;
        }

        public void AddProduct(string name, string category, string subcategory, decimal price, string unit, string productImage)
        {
            productRepository.CreateProduct(name, category, subcategory, price, unit, productImage);
        }

        public void UpdateProduct(int id, string name, string category, string subcategory, decimal price, string unit, string productImage)
        {
            productRepository.UpdateProduct(id, name, category, subcategory, price, unit, productImage);
        }

        public Product GetProduct(int id)
        {
            Product product = new Product(productRepository.GetProductByID(id));
            return product;
        }

        public void DeleteProduct(int id)
        {
            productRepository.DeleteProduct(id);
        }
    }
}
