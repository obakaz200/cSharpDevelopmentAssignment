using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP.HrModule
{
   public class Dog
    {
        public string Name { get; set; } 
        public string Breed { get; set; } 
        public string Color { get; set; } 
        public int Age { get; set; } 
        public int Height { get; set; }
        public int Weight { get; set; }

        public void Bark()
        {
            Console.WriteLine("This dog barks to ward off dangerous individuals");
            Console.Beep(100, 4000);
        }
        public void Run()
        {
            Console.WriteLine("This dog can run fast");
        }
        public void Bite()
         {
            Console.WriteLine("This dog has good teeth for biting dangerous individuals");
        }
        public void WaggleTail()
        {
            Console.WriteLine("This dog has a tail it waggles");
        }
        
        public void RollOver()
        {
            Console.WriteLine("This dog can roll over for your amusement");
        }
        public override string ToString()
        {
            return $"Name:{Name}";
        }
    }
}



