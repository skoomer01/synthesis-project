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
        public void CreateCategory(string name, int? parent)
        {
                    
        }

        public List<CategoryDTO> GetCategories()
        {
            return _categories;
        }

        public CategoryDTO GetCategoryByName(string name)
        {
           
            return null;
        }

        public List<CategoryDTO> GetSubCategories()
        {
            return _categories;
        }

        public List<CategoryDTO> GetSubCategories(int id)
        {
            return _categories;
        }

        public void UpdateCategory(int id, string name)
        {
            
        }

        public void UpdateProductCategory(string newname, string oldname)
        {


        }

        public void UpdateProductSubCategory(string newname, string oldname)
        {

        }
    }
}
