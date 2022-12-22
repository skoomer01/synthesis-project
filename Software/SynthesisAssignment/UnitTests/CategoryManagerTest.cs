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
    public class CategoryManagerTest
    {
        [TestMethod]
        private ICategoryRepo CreateTestRepo()
        {
            return new MockCategoryRepo();
        }

        [TestMethod]
        public void CreateCategorySuccess()
        {
            CategoryManager categoryManager = new CategoryManager(CreateTestRepo());
            bool isTrue = categoryManager.CreateCategory("Meat", null);

            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateSubCategoryFail()
        {
            CategoryManager categoryManager = new CategoryManager(CreateTestRepo());
            bool throwex = categoryManager.CreateCategory("", 1);

        }


        [TestMethod]
        public void UpdateCategorySuccess()
        {
            CategoryManager categoryManager = new CategoryManager(CreateTestRepo());
            bool isTrue = categoryManager.UpdateCategory(1, "Cheese");

            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        public void UpdateCategoryFail()
        {
            CategoryManager categoryManager = new CategoryManager(CreateTestRepo());
            bool isFalse = categoryManager.UpdateCategory(1, "");

            Assert.IsFalse(isFalse);
        }
    }
}
