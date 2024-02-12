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
using static System.Collections.Specialized.BitVector32;

namespace OOPintro.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {


        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(CreateCategoryRequest category)
        {
            //iş kuralları business rules
            Category categoryToCreate = new();
            categoryToCreate.Name = category.Name;
            _categoryDal.Add(categoryToCreate);
        }
        public List<GetAllCategoryResponse> GetCategory()
        {
            List<GetAllCategoryResponse> category = new();
            foreach (var item in _categoryDal.GetCategories())
            {
                GetAllCategoryResponse getAllCategoryResponse = new();
                getAllCategoryResponse.Id= item.Id;
                getAllCategoryResponse.Name= item.Name;
                category.Add(getAllCategoryResponse);
            }
            return category;
        }
    }
}
