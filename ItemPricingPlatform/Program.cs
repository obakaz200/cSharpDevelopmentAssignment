using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemCostingPlatform;


namespace ItemPricingPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(d());
            RawMaterials raw = new RawMaterials("Butter","Substance applied to bread or used for baking", 200.50m, 5);
            Product a = new Product("Cake","Sweet and delicious consummable for special occassions",1500, 4000, 1);
            Product.Category b = new Product.Category("Pasteries", "Cake", "Sweet and delicious consummable for special occassions", 1500, 4000, 1) ;
            Console.WriteLine(raw);
            Console.WriteLine();
            Console.WriteLine(b);
            Console.ReadLine();
            

        }
        static RawMaterials d()
        {
            RawMaterials raw = new RawMaterials();
            raw.Name = "Flour";
            raw.Description = "";
            raw.Price = 200;
            raw.UnitOfMeasurement = 5;
            return raw;
        }
    }
}
