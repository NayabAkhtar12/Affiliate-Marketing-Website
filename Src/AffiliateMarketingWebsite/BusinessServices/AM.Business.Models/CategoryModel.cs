﻿using AM.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Business.Models
{
    public class CategoryModel
    {
        public CategoryModel() {

            Category = new List<CategoryModel>();
        }
        public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Img { get; set; }= string.Empty;
        public ICollection<CategoryModel> Category { get; set; } //collection navigation property

        //public ICollection<Product> Product { get; set; } //collection navigation property
    }
}
