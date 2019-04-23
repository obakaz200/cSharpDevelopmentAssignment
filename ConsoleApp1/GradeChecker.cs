using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GradeChecker
    {
        public static int Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Display();
            Console.ReadLine();
            return 0;
        }
        static void Display()
        {
            Console.WriteLine("Input your name and press Enter");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Input your score and press Enter");
            bool success = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("{0}, your score is {1} and your grade is>>>", name, a);
            Console.WriteLine(success ? IntCheck(a).ToString() : "Enter a valid number");
            Console.WriteLine("Press any key if you want to find the grade of another individual");
            Console.ReadKey();
            Display();
            
        }
        static string IntCheck(int a)

        {
            return
            (a >= 80 && a <= 100) ? "A" :
            (a >= 65 && a <= 79) ? "AB" :
            (a >= 55 && a <= 64) ? "B" :
            (a >= 45 && a <= 54) ? "C" :
            (a >= 35 && a <= 44) ? "CD" :
            (a >= 25 && a <= 34) ? "D" :
            (a >= 15 && a <= 24) ? "E" :
            (a >= 0 && a <= 14) ? "F" : "Type a Valid number between 0 and 100";

            
        }
    }
}
