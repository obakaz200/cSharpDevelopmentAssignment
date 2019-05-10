using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCostingPlatform
{
    public class RawMaterials
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long UnitOfMeasurement { get; set; }

        public RawMaterials()
        {

        }

        public RawMaterials(string name, string description, decimal price, long unitOfMeasurement)
        {
            Name = name;
            Description = description;
            Price = price;
            UnitOfMeasurement = unitOfMeasurement;
        }
        public override string ToString()
        {
            return $@"
Name of raw material: {Name}
Description: {Description}
Price: {Price}
Units: {UnitOfMeasurement}";
        }
    }
}
