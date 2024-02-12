using OOPintro.Business.Abstracts;
using OOPintro.Business.Dtos.Requests;
using OOPintro.Business.Dtos.Responses;
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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(CreateProductRequest product)
        {
            //iş kuralları business rules
            //mapping ->> automapper
            Product productToCreate = new Product();
            productToCreate.Description = product.Description;
            productToCreate.UnitPrice = product.UnitPrice;
            productToCreate.Name = product.Name;
            productToCreate.DiscountRate = product.DiscountRate;
            _productDal.Add(productToCreate);
        }

        public List<GetAllProductResponse> GetProducts()
        {
            List<GetAllProductResponse> products = new List<GetAllProductResponse>();
            foreach (var item in _productDal.GetProducts())
            {
                GetAllProductResponse getAllProductResponse = new();
                getAllProductResponse.UnitPrice = item.UnitPrice;
                getAllProductResponse.Description = item.Description;
                getAllProductResponse.Name = item.Name;
                getAllProductResponse.Id = item.Id;
                getAllProductResponse.DiscountRate = item.DiscountRate;
                products.Add(getAllProductResponse);
            }

            return products;
        }
    }
}
