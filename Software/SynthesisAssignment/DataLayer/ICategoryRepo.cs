using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ICategoryRepo
    {
        public List<CategoryDTO> GetCategories();
        public List<CategoryDTO> GetSubCategories();
        public List<CategoryDTO> GetSubCategories(int id);
        public void UpdateCategory(int id, string name);
        public void UpdateProductSubCategory(string newname, string oldname);
        public void UpdateProductCategory(string newname, string oldname);
        public CategoryDTO GetCategoryByName(string name);
        public void CreateCategory(string name, int? parent);
    }
}
