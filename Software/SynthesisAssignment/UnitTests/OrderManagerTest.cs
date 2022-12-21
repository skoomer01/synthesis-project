using DataLayer.MockClasses;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;

namespace UnitTests
{
    [TestClass]
    public class OrderManagerTest
    {
        [TestMethod]
        private IOrderRepo CreateTestRepo()
        {
            return new MockOrderRepo();
        }

        [TestMethod]
        public void AddOrderSuccess()
        {
            OrderManager orderManager = new OrderManager(CreateTestRepo());
            DateTime dateTime = DateTime.Now;
            List<OrderProduct> orderPoducts = new List<OrderProduct>();
            OrderProduct orderProduct = new OrderProduct();
            Category category = new Category();
            category.Id = 1;
            category.Name = "Meat";
            Category subcategory = new Category();
            subcategory.Id = 2;
            subcategory.Name = "Pork";
            subcategory.ParentId = 1;
            Product product = new Product();
            product.Id = 3;
            product.Name = "Ham";
            product.Price = 2;
            product.Unit = "Grams";
            product.Category = category;
            product.SubCategory = subcategory;
            orderProduct.Product = product;
            orderProduct.Quantity = 1;
            orderProduct.Price = 2;
            orderPoducts.Add(orderProduct);
            
            bool isTrue = orderManager.AddOrder(1, dateTime, EnumOrderStatus.Delivered, 20, orderPoducts, "Radu", "radu@mail.com", "11234AB");

            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        public void AddOrderFail()
        {
            OrderManager orderManager = new OrderManager(CreateTestRepo());
            DateTime dateTime = DateTime.Now;

            bool isFalse = orderManager.AddOrder(1, dateTime, EnumOrderStatus.Delivered, 20, null, "Radu", "radu@mail.com", "11234AB");

            Assert.IsFalse(isFalse);
        }

        [TestMethod]
        public void UpdateStatusSuccess()
        {
            OrderManager orderManager = new OrderManager(CreateTestRepo());

            bool isTrue = orderManager.UpdateOrderStatus(1, "Preparing");

            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        public void UpdateStatusFail()
        {
            OrderManager orderManager = new OrderManager(CreateTestRepo());

            bool isFalse = orderManager.UpdateOrderStatus(1, "");

            Assert.IsFalse(isFalse);
        }
    }
}
