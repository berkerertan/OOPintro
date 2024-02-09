using OOPintro.DataAccess.Concretes.InMemory;
using OOPintro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.Business.Concretes
{
    public class CategoryManager
    {
        ImCategoryDal categoryDal = new ImCategoryDal();

        public void Add(Category category)
        {
            //iş kuralları business rules

            categoryDal.Add(category);
        }
        public List<Category> GetCategory()
        {
            return categoryDal.GetCategories();
        }
    }
}
