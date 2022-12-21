using DataLayer;
using DataLayer.MockClasses;
using LogicLayer;

namespace UnitTests
{
    [TestClass]
    public class ProductManagerTest
    {
        [TestMethod]
        private IProductRepo CreateTestRepo()
        {
            return new MockProductRepo();
        }

        [TestMethod]
        public void AddProductSuccess()
        {
            ProductManager productManager = new ProductManager(CreateTestRepo());

            bool resultTrue = productManager.AddProduct("Ham", "Meat", "Pork", "2.33", "per 100g", "image.jpeg");
            Assert.IsTrue(resultTrue);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddProductFillAllBlanksException()
        {

            ProductManager productManager = new ProductManager(CreateTestRepo());

            bool throwExceptionBlank = productManager.AddProduct("", "Meat", "Pork", "2.33", "per 100g", "image.jpeg");
            Assert.ThrowsException<Exception>(() => throwExceptionBlank);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddProductDecimalException()
        {
            ProductManager productManager = new ProductManager(CreateTestRepo());
            bool throwExceptionDecimal = productManager.AddProduct("Ham", "Meat", "Pork", "notdecimal", "per 100g", "image.jpeg");

            Assert.ThrowsException<Exception>(() => throwExceptionDecimal);
        }

        [TestMethod]
        public void UpdateProductSuccess()
        {
            ProductManager productManager = new ProductManager(CreateTestRepo());
            bool resultTrue = productManager.UpdateProduct(1,"Ham", "Meat", "Pork", "2.33", "per 100g", "image.jpeg");

            Assert.IsTrue(resultTrue);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UpdateProductFillAllBlanksException()
        {
            ProductManager productManager = new ProductManager(CreateTestRepo());
            bool throwExceptionBlank = productManager.UpdateProduct(1, "", "Meat", "Pork", "2.33", "per 100g", "image.jpeg");

            Assert.ThrowsException<Exception>(() => throwExceptionBlank);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UpdateProductDecimalException()
        {
            ProductManager productManager = new ProductManager(CreateTestRepo());
            bool throwExceptionDecimal = productManager.UpdateProduct(1, "Ham", "Meat", "Pork", "notdecimal", "per 100g", "image.jpeg");

            Assert.ThrowsException<Exception>(() => throwExceptionDecimal);
        }

        [TestMethod]
        public void GetProductByID()
        {
            ProductManager productManager = new ProductManager(CreateTestRepo());
            int id = 1;
            Product product = productManager.GetProduct(id);

            Assert.IsNotNull(product);
        }

        [TestMethod]
        public void UpdateStatusSuccess()
        {
            ProductManager productManager = new ProductManager(CreateTestRepo());
            int id = 1;
            bool isTrue = productManager.UpdateStatusProduct(id, "Unavailable");

            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        public void UpdateStatusFail()
        {
            ProductManager productManager = new ProductManager(CreateTestRepo());
            int id = 1;
            bool isTrue = productManager.UpdateStatusProduct(id, "");

            Assert.IsFalse(isTrue);
        }
    }
}