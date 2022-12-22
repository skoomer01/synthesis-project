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
        List<ProductDTO> _products = new List<ProductDTO>();
        public List<ProductDTO> GetProducts()
        {
            return _products;
        }
        public List<ProductDTO> GetAvailableProducts()
        {
            return null;
        }
        public List<ProductDTO> GetProductsBySubcategory(string name)
        {
            return null;
        }
        public void UpdateProduct(int id, string name, string category, string subcategory, decimal price, string unit, string productImage)
        {

        }
        public ProductDTO GetProductByID(int ID)
        {
            ProductDTO result = new ProductDTO(); 
            CategoryDTO category = new CategoryDTO();
            CategoryDTO subcategory = new CategoryDTO();
            result.Category = category;
            result.SubCategory= subcategory;
            return result;
        }

        public void CreateProduct(string name, string category, string subcategory, decimal price, string unit, string productImage)
        {

        }

        public void ChangeStatusProduct(int id, string status)
        {

        }
    }
}
