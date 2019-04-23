using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            String();
        }
        static void String()
        {
            string input = "";
            string reverse = "";
            Console.WriteLine("Type in your statement and press Enter");
            input = Console.ReadLine();
            Console.WriteLine("Your statement is {0}", input);
            int a;
            a = input.Length - 1;
            while (a >= 0)
            {
                reverse = reverse + input[a];
                a--;
            }
            Console.WriteLine("The reverse of your statement is>>> {0}", reverse);
            Console.WriteLine("Press any key if you want to find the reverse of another statement");
            Console.ReadKey();
            String();
            Console.ReadLine();
        }
    }
}
