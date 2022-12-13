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

        public List<Product> GetProductsBySubcategory(string name)
        {
            List<Product> products = new List<Product>();
            foreach (ProductDTO productDTO in productRepository.GetProductsBySubcategory(name))
            {
                Product product = new Product(productDTO);
                products.Add(product);
            }
            return products;
        }

        public bool AddProduct(string name, string category, string subcategory, string price, string unit, string productImage)
        {
            if (name != String.Empty &&
                    price != String.Empty &&
                    unit != String.Empty &&
                    category != String.Empty &&
                    subcategory != String.Empty)
            {
                decimal tryPrice;
                if (Decimal.TryParse(price, out tryPrice))
                {
                    productRepository.CreateProduct(name, category, subcategory,Convert.ToDecimal(price), unit, productImage);
                    return true;
                }
                else
                {
                    throw new Exception("Invalid price format. Should be in 0,00 format.");
                }

            }
            else { throw new Exception("Please fill in all blanks."); }
            
        }

        public bool UpdateProduct(int id, string name, string category, string subcategory, string price, string unit, string productImage)
        {
            if (name != String.Empty &&
                    category != String.Empty &&
                    subcategory != String.Empty &&
                    price != String.Empty &&
                    unit != String.Empty)
            {
                decimal tryPrice;
                if (Decimal.TryParse(price, out tryPrice))
                {
                    productRepository.UpdateProduct(id, name, category, subcategory, Convert.ToDecimal(price), unit, productImage);
                    return true;
                }
                else
                {
                    throw new Exception("The price should be in format 0,00.");
                }

            }
            else { throw new Exception("Please fill in all fields."); }
            
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
