using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.Business.Dtos.Requests
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountRate { get; set; }
    }
}
