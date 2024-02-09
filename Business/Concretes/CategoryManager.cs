using OOPintro.DataAccess.Abstracts;
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


        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            //iş kuralları business rules

            _categoryDal.Add(category);
        }
        public List<Category> GetCategory()
        {
            return _categoryDal.GetCategories();
        }
    }
}
