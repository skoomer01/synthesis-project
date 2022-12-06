using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Product
    {

        public Product() { }
        public Product(ProductDTO productDTO)
        {
            Id = productDTO.Id;
            Name = productDTO.Name; 
            Category = new Category(productDTO.Category);
            SubCategory = new Category(productDTO.SubCategory);
            Price = productDTO.Price;
            Unit = productDTO.Unit;
            ProductImage = productDTO.ProductImage;
        }
        [DisplayName("Identification number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Category")]
        public Category Category { get; set; }
        [DisplayName("Sub-Category")]
        public Category SubCategory { get; set; }
        [DisplayName("Price")]
        public decimal Price { get; set; }
        [DisplayName("Unit")]
        public string Unit { get; set; }
        [DisplayName("Image Link")]
        public string ProductImage { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Category.Name}, {SubCategory.Name}, {Price}, {Unit}, {ProductImage} ";
        }
    }
}
