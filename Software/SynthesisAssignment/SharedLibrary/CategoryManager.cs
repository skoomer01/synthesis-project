using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class CategoryManager
    {
        CategoryRepository categoryRepository = new CategoryRepository();


        public void CreateCategory(string name, int? parent)
        {
            categoryRepository.CreateCategory(name, parent);
        }
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            foreach(CategoryDTO categoryDTO in categoryRepository.GetCategories())
            {
                Category category = new Category(categoryDTO);
                categories.Add(category);
            }
            return categories;
        }
        public List<Category> GetSubCAtegories(int id)
        {
            List<Category> subcategories = new List<Category>();
            foreach (CategoryDTO categoryDTO in categoryRepository.GetSubCategories(id))
            {
                Category category = new Category(categoryDTO);
                subcategories.Add(category);
            }
            return subcategories;
        }
        public void DeleteCategory(int id)
        {
            categoryRepository.DeleteCategory(id);
        }

    }
}
