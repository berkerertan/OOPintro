using OOPintro.DataAccess.Abstracts;
using OOPintro.DataAccess.Concretes.InMemory;
using OOPintro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.Bussiness.Concretes
{
    public class ProductManager
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            //iş kuralları business rules
            
            _productDal.Add(product);
        }
        public List<Product> GetProducts() 
        {
            return _productDal.GetProducts();
        }
    }
}
