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
        private CategoryRepository categoryRepository = new CategoryRepository();
        public List<Category> SubCategoriesList { get; set; }
        public List<Category> CategoryList { get; set; }
        public CategoryManager()
        {
            this.CategoryList = GetAllCategories();
            this.SubCategoriesList = GetAllSubCategories();
        }
        public void CreateCategory(string name, int? parent)
        {
            if(GetCategoryByName(name) != null)
            {
                throw new Exception("Category of that name already exists.");
            }
            else { categoryRepository.CreateCategory(name, parent);}
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
        public List<Category> GetSubCategories(int id)
        {
            List<Category> subcategories = new List<Category>();
            foreach (CategoryDTO categoryDTO in categoryRepository.GetSubCategories(id))
            {
                Category category = new Category(categoryDTO);
                subcategories.Add(category);
            }
            return subcategories;
        }

        public List<Category> GetAllSubCategories()
        {
            List<Category> subcategories = new List<Category>();
            foreach (CategoryDTO categoryDTO in categoryRepository.GetSubCategories())
            {
                Category category = new Category(categoryDTO);
                subcategories.Add(category);
            }
            return subcategories;
        }

        public Category GetCategoryByName(string name)
        {
            if(name == String.Empty!)
            {
                CategoryDTO categoryDTO = categoryRepository.GetCategoryByName(name);
                if (categoryDTO != null)
                {
                    Category c = new Category(categoryDTO);
                    return c;
                }
            }
            return null;
        }

        public bool UpdateCategory(int id, string name)
        {
            if(name != String.Empty)
            {
                categoryRepository.UpdateCategory(id, name);
                return true;
            }
            return false;
        }
        public void UpdateProductSubCategory(string newname, string oldname)
        {
            if(oldname != String.Empty && newname != String.Empty)
            {
                categoryRepository.UpdateProductSubCategory(newname, oldname);
            }
        }
        public void UpdateProductCategory(string newname, string oldname)
        {
            if (oldname != String.Empty && newname != String.Empty)
            {
                categoryRepository.UpdateProductCategory(newname, oldname);
            }
        }
    }
}
