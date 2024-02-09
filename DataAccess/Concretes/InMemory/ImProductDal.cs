using OOPintro.DataAccess.Abstracts;
using OOPintro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPintro.DataAccess.Concretes.InMemory
{
    public class ImProductDal : IProductDal
    {
        public List<Product> products = new List<Product>();

        public ImProductDal()
        {;
            products.Add(new Product { Id = 1, Name = " Elma", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 2, Name = " Armut", UnitPrice = 20, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 3, Name = " üzüm", UnitPrice = 30, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 4, Name = " incir", UnitPrice = 40, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 5, Name = " Kayısı", UnitPrice = 50, Description = "Kırmızı elma", DiscountRate = 10 });

        }
        public void Add(Product product)
        {
    
           products.Add(product);
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
