using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.LogicLayer
{
    public class Product
    {
        
        public Product() { }

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
