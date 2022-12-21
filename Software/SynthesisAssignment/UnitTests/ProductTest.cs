using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ConstructorTestDTO()
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            CategoryDTO subcategoryDTO = new CategoryDTO();
            ProductDTO productDTO = new ProductDTO(1, "Ham", categoryDTO, subcategoryDTO, 1, "g", null);

            Assert.AreEqual(1, productDTO.Id);
            Assert.AreEqual("Ham", productDTO.Name);
            Assert.AreEqual(categoryDTO, productDTO.Category);
            Assert.AreEqual(subcategoryDTO, productDTO.SubCategory);
            Assert.AreEqual(1, productDTO.Price);
            Assert.AreEqual("g", productDTO.Unit);
            Assert.IsNull(productDTO.ProductImage);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            CategoryDTO subcategoryDTO = new CategoryDTO();
            ProductDTO productDTO = new ProductDTO(1, "Ham", categoryDTO, subcategoryDTO, 1, "g", null);

            Product product = new Product(productDTO);

            Assert.AreEqual(1, product.Id);
            Assert.AreEqual("Ham", product.Name);
            Assert.AreEqual(1, product.Price);
            Assert.AreEqual("g", product.Unit);
            Assert.IsNull(product.ProductImage);
        }
    }
}
