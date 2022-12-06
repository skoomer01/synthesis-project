using SharedLibrary.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.LogicLayer
{
    public  class CategoryManager
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public void CreateCategory(string name, int? parent)
        {
            categoryRepository.CreateCategory(name, parent);
        }
        public List<Category> GetAllCategories()
        {
            return categoryRepository.GetCategories();
        }
        public List<Category> GetSubCAtegories(int id)
        {
            return categoryRepository.GetSubCategories(id);
        }
        public void DeleteCategory(Category category)
        {
            categoryRepository.DeleteCategory(category);
        }

    }
}
