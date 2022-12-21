using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer.MockClasses
{
    public class MockCategoryRepo : ICategoryRepo
    {
        List<CategoryDTO> _categories = new List<CategoryDTO>();
        List<CategoryDTO> _subcategories = new List<CategoryDTO>();
        public void CreateCategory(string name, int? parent)
        {
            CategoryDTO category = new CategoryDTO();
            category.Name = name;
            category.ParentId = parent;
            if(parent != null)
            {
                _subcategories.Add(category);
            }
            else
            {
                _categories.Add(category);
            }           
        }

        public List<CategoryDTO> GetCategories()
        {
            return _categories;
        }

        public CategoryDTO GetCategoryByName(string name)
        {
            foreach(CategoryDTO category in _categories)
            {
                if(category.Name == name)
                {
                    return category;
                }
            }

            foreach (CategoryDTO category in _subcategories)
            {
                if (category.Name == name)
                {
                    return category;
                }
            }
            return null;
        }

        public List<CategoryDTO> GetSubCategories()
        {
            return _subcategories;
        }

        public List<CategoryDTO> GetSubCategories(int id)
        {
            List<CategoryDTO> subcategories = new List<CategoryDTO>();
            foreach (CategoryDTO category in _categories)
            {
                if (category.ParentId == id)
                {
                    subcategories.Add(category);
                }
            }
            return subcategories;
        }

        public void UpdateCategory(int id, string name)
        {
            foreach(CategoryDTO c in _categories)
            {
                if(c.Id == id)
                {
                    c.Name = name;
                }
            }
            foreach (CategoryDTO c in _subcategories)
            {
                if (c.Id == id)
                {
                    c.Name = name;
                }
            }
        }

        public void UpdateProductCategory(string newname, string oldname)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductSubCategory(string newname, string oldname)
        {
            throw new NotImplementedException();
        }
    }
}
