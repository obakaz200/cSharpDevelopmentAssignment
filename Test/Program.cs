using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    public class NumberChecker
    {
        public static void Main()
        {
            
            Console.WriteLine(IntCheck(9));
            Console.ReadLine();
            
        }
        static bool IntCheck(double a)
        {
          return a % 2 == 1 ? true : false;
         }
        static void Display()
        {
            Console.WriteLine("Input a valid number and press enter ");
            bool success = double.TryParse(Console.ReadLine(), out double a);
            
        }
    }
}
