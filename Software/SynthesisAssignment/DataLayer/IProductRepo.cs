using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IProductRepo
    {
        public List<ProductDTO> GetProducts();
        public List<ProductDTO> GetProductsBySubcategory(string name);
        public void UpdateProduct(int id, string name, string category, string subcategory, decimal price, string unit, string productImage);
        public ProductDTO GetProductByID(int ID);
        public void CreateProduct(string name, string category, string subcategory, decimal price, string unit, string productImage);
        public void ChangeStatusProduct(int id, string status);
        public List<ProductDTO> GetAvailableProducts();
    }
}
