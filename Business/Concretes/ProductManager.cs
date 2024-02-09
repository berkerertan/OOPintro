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
        ImProductDal productDal = new ImProductDal();

        public void Add(Product product)
        {
            //iş kuralları business rules
            
            productDal.Add(product);
        }
        public List<Product> GetProducts() 
        {
            return productDal.GetProducts();
        }
    }
}
