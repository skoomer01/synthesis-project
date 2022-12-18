using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }

        public CategoryDTO()
        {

        }

        public CategoryDTO(int id, string name, int? parentId)
        {
            Id = id;
            Name = name;
            ParentId = parentId;
        }
    }
}
