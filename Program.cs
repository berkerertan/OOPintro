using OOPintro.Business.Concretes;
using OOPintro.Bussiness.Concretes;
using OOPintro.DataAccess.Abstracts;
using OOPintro.DataAccess.Concretes.EntityFramework;
using OOPintro.DataAccess.Concretes.InMemory;
using OOPintro.Entities;

namespace OOPintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "laptop";
            product1.Description = " aşırı guclu laptop";
            product1.UnitPrice = 500000;
            product1.DiscountRate = 10;


            Product product2 = new Product(2, "GSM", "Samsung bişey", 70000);

            ProductManager productManager = new ProductManager(EfProductDal());
            productManager.Add(product1);

            foreach (var product in productManager.GetProducts())
            {
                Console.WriteLine(product.Name);
            }

            Category category1 = new Category();
            category1.Id = 6;
            category1.Name = "Tropik";

            CategoryManager categoryManager = new CategoryManager(EfCategoryDal());
            categoryManager.Add(category1);

            foreach (var item in categoryManager.GetCategory())
            {
                Console.WriteLine(item.Name);
            }


        }


    }
}
