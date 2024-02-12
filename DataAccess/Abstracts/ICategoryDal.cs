using OOPintro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        public void Add(Category category);
        public List<Category> GetCategories();
    }
}
