using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer.MockClasses
{
    public class MockProductRepo :IProductRepo
    {
        MockCategoryRepo mockCategory = new MockCategoryRepo();
        List<ProductDTO> _products = new List<ProductDTO>();
        public List<ProductDTO> GetProducts()
        {
            return _products.ToList();
        }
        public List<ProductDTO> GetAvailableProducts()
        {
            List<ProductDTO> availableProducts = new List<ProductDTO>();
            foreach(ProductDTO product in _products)
            {
                if(product.Availability == "Available")
                {
                    availableProducts.Add(product);
                }
            }
            return availableProducts.ToList();
        }
        public List<ProductDTO> GetProductsBySubcategory(string name)
        {
            List<ProductDTO> subcategoryProducts = new List<ProductDTO>();
            foreach (ProductDTO product in _products)
            {
                if (product.SubCategory.Name == name)
                {
                    subcategoryProducts.Add(product);
                }
            }
            return subcategoryProducts.ToList();
        }
        public void UpdateProduct(int id, string name, string category, string subcategory, decimal price, string unit, string productImage)
        {
            foreach (ProductDTO product in _products)
            {
                if (product.Id == id)
                {
                    product.Name = name;
                    product.Category = mockCategory.GetCategoryByName(category);
                    product.SubCategory = mockCategory.GetCategoryByName(subcategory);
                    product.ProductImage = productImage;
                    product.Price = price;
                    product.Unit = unit;
                }
            }
        }
        public ProductDTO GetProductByID(int ID)
        {
            _products.Add(new ProductDTO(1,"Ham", new CategoryDTO(), new CategoryDTO(), 2, "per 100g", "image.jpeg"));
            foreach (ProductDTO product in _products)
            {
                if (product.Id == ID)
                {
                    return product;
                }
            }
            return null;
        }

        public void CreateProduct(string name, string category, string subcategory, decimal price, string unit, string productImage)
        {
            ProductDTO product = new ProductDTO();
            product.Name = name;
            product.Category = mockCategory.GetCategoryByName(category);
            product.SubCategory = mockCategory.GetCategoryByName(subcategory);
            product.Price = price;
            product.Unit = unit;
            product.ProductImage = productImage;
            _products.Add(product);
        }

        public void ChangeStatusProduct(int id, string status)
        {
            foreach (ProductDTO product in _products)
            {
                if (product.Id == id)
                {
                    product.Availability = status;
                }
            }
        }
    }
}
