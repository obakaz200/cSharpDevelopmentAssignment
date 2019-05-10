using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCostingPlatform
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public long UnitsInStock { get; set; }

        
        public Product(string name, string description, decimal costPrice, decimal sellingPrice, long unitsInStock)
        {
            Name = name;
            Description = description;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            UnitsInStock = unitsInStock;
        }

        public class Category 
        {
            public string CategoryName { get; set; }
            public string CategoryDescription { get; set; }

            public Category(string categoryname, string description) 
            {
                CategoryName = categoryname;
                CategoryDescription = description;
            }
            public override string ToString()
            {
                return $@"
Product category: {CategoryName}
Description: {CategoryDescription}";

            }

        }
        public override string ToString()
        {
            return $@"Name of product: {Name}
Description: {Description}
Price: {SellingPrice}
Units: {UnitsInStock}";
        }
    }
}
