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
        public List<Category> SubCategoriesList { get; set; }
        public List<Category> CategoryList { get; set; }
        private ICategoryRepo categoryRepo;
        public CategoryManager(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
            this.CategoryList = GetAllCategories();
            this.SubCategoriesList = GetAllSubCategories();
            
        }
        public bool CreateCategory(string name, int? parent)
        {
            if(name == String.Empty)
            {
                throw new Exception("Category name is empty.");
            }
            if(GetCategoryByName(name) != null)
            {
                throw new Exception("Category of that name already exists.");
            }
            else 
            {
                categoryRepo.CreateCategory(name, parent);
                return true;
            }
        }
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            foreach(CategoryDTO categoryDTO in categoryRepo.GetCategories())
            {
                Category category = new Category(categoryDTO);
                categories.Add(category);
            }
            return categories;
        }
        public List<Category> GetSubCategories(int id)
        {
            List<Category> subcategories = new List<Category>();
            foreach (CategoryDTO categoryDTO in categoryRepo.GetSubCategories(id))
            {
                Category category = new Category(categoryDTO);
                subcategories.Add(category);
            }
            return subcategories;
        }

        public List<Category> GetAllSubCategories()
        {
            List<Category> subcategories = new List<Category>();
            foreach (CategoryDTO categoryDTO in categoryRepo.GetSubCategories())
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
                CategoryDTO categoryDTO = categoryRepo.GetCategoryByName(name);
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
                categoryRepo.UpdateCategory(id, name);
                return true;
            }
            return false;
        }
        public void UpdateProductSubCategory(string newname, string oldname)
        {
            if(oldname != String.Empty && newname != String.Empty)
            {
                categoryRepo.UpdateProductSubCategory(newname, oldname);
            }
        }
        public void UpdateProductCategory(string newname, string oldname)
        {
            if (oldname != String.Empty && newname != String.Empty)
            {
                categoryRepo.UpdateProductCategory(newname, oldname);
            }
        }
    }
}
