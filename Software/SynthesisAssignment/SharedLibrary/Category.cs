﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }

        public Category() { }
        public Category(CategoryDTO categoryDTO)
        {
            Id = categoryDTO.Id;
            Name = categoryDTO.Name;
            ParentId = categoryDTO.ParentId;
        }
    }
}
