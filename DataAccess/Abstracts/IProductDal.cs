using OOPintro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.DataAccess.Abstracts
{
    public interface IProductDal
    {
        void Add(Product product);
        List<Product> GetProducts();
    }
}
