using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    public class NumberChecker
    {
        public static int Main()
        {
            Console.WriteLine(IntCheck());
            Console.ReadLine();
            return 0;
        }
        static string IntCheck()
        {
            double a;
            Console.WriteLine("Input a valid number and press enter ");
            bool success = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine(success ? a % 2 == 1 ? "The number you entered is odd" : "The number you entered is even" : "Enter a valid number");
            Console.WriteLine("Press any key if you want to find the parity of another number");
            Console.ReadKey();
            IntCheck();
            return "";
        }
    }
}
