﻿using OOPintro.DataAccess.Abstracts;
using OOPintro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.DataAccess.Concretes.InMemory
{
    public class ImCategoryDal : ICategoryDal
    {

        List<Category> categories = new List<Category>();
        public ImCategoryDal()
        {
            categories.Add(new Category { Id = 1, Name = "Sebzeler" });
            categories.Add(new Category { Id = 2, Name = "Meyveler" });
            categories.Add(new Category { Id = 3, Name = "Bakliyat" });

        }
        public void Add(Category category)
        {
            categories.Add(category);
            
        }

        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
