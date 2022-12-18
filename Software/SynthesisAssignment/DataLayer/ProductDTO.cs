using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductDTO
    {
        public ProductDTO() { }

        public ProductDTO(int id, string name, CategoryDTO category, CategoryDTO subCategory, decimal price, string unit, string productImage)
        {
            Id = id;
            Name = name;
            Category = category;
            SubCategory = subCategory;
            Price = price;
            Unit = unit;
            ProductImage = productImage;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryDTO Category { get; set; }
        public CategoryDTO SubCategory { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string ProductImage { get; set; }
    }
}
