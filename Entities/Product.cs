using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro.Entities
{
    public class Product
    {
        //Constructor
        //overloading
        public Product()
        {
            
        }
        public Product(int ıd, string name, string description, double unitPrice)
        {
            Id = ıd;
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
        }

        //property
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountRate { get; set; }
        public double DiscountedPrice => UnitPrice - (UnitPrice * DiscountRate / 100);
        public Category Category { get; set; }
    }
}
