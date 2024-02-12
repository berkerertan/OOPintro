using OOPintro.DataAccess.Abstracts;
using OOPintro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal:ICategoryDal
    {
        List<Category> categories = new List<Category>();
        public EfCategoryDal()
        {
            categories.Add(new Category { Id = 1, Name = "Sebzeler EF" });
            categories.Add(new Category { Id = 2, Name = "Meyveler EF" });
            categories.Add(new Category { Id = 3, Name = "Bakliyat EF" });

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
