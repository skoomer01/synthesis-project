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
            Discount = productDTO.Discount;
            Availability = productDTO.Availability;
        }
        [DisplayName("Identification number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public Category Category { get; set; }
        [DisplayName("Category")]
        public string CategoryName { get { return Category.Name; } }
        public Category SubCategory { get; set; }
        [DisplayName("Sub-category")]
        public string SubCategoryName { get { return SubCategory.Name; } }
        [DisplayName("Price")]
        public decimal Price { get; set; }
        public int Discount { get; set; }
        [DisplayName("Unit")]
        public string Unit { get; set; }
        [DisplayName("Image Link")]
        public string ProductImage { get; set; }
        [DisplayName("Availability")]
        public string Availability { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Name}, {Category.Name}, {SubCategory.Name}, {Price}, {Unit}, {ProductImage} ";
        }
    }
}
