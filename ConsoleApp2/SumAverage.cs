using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    class SumAverage
    {
        static void Main(string[] args)
        {
            NumberRequest();
            ReadLine();
        }
      
        static void NumberRequest()
        {
            Console.WriteLine("How many numbers do you want to add?");
            bool success = int.TryParse(Console.ReadLine(), out int a);
            if (success && a >= 2)
            {
                Add(a);
            }

        }
        static double Add(int a)
        {
            int i = 0;
            double sum = 0.0;
        starthere:
            i = i + 1;
            WriteLine($"Input Number {i}");
            bool trues = int.TryParse(Console.ReadLine(), out a);
            
            
                sum = sum + a;
                return sum;
            
            if (i < a) goto starthere;

            return 0;
        }
            
            
            
        
    }
}
