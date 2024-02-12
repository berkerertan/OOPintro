using OOPintro.Business.Dtos.Requests;
using OOPintro.Business.Dtos.Responses;
using OOPintro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.Business.Abstracts
{
    public interface ICategoryService
    {
        public void Add(CreateCategoryRequest category);
        public List<GetAllCategoryResponse> GetCategory();
    }
}
