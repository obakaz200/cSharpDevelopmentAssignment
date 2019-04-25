using System;
using UtilityFunctions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
            Display2();
            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("Please input the number you wish to convert to words");
            bool success = long.TryParse(Console.ReadLine(), out long input);
            string c = input.ToString();
            if (success && input == 0)
            {
                Console.WriteLine("zero");
            }
            else if (success && input <= 19)
            {
                Console.WriteLine(Util.NumberToWord.First19(input));
            }
            else if (success && input >= 20 & input <= 99)
            {
                Console.WriteLine(Util.NumberToWord.Tens(input));
            }
            else if (success && input >= 100 & input <= 999)
            {
                Console.WriteLine(Util.NumberToWord.Hundreds(input));
            }
            else if (success && input >= 1000 & input <= 999999)
            {
                Console.WriteLine(Util.NumberToWord.Thousand(input));
            }
            else if (success && input >= 1000000 & input <= 999999999)
            {
                Console.WriteLine(Util.NumberToWord.Million(input));
            }
            else if (success && input >= 1000000000 & input <= 999999999999)
            {
                Console.WriteLine(Util.NumberToWord.Billion(input));
            }
            else if (success && input >= 1000000000000 & input <= 999999999999999)
            {
                Console.WriteLine(Util.NumberToWord.Trillion(input));
            }

        }
        static void Display2()
        {
            Console.WriteLine("What base do you want to convert from?");
            bool success = long.TryParse(Console.ReadLine(), out long numbase);
            if (success && numbase <= 10)
            {
                Console.WriteLine("What base do you want to convert to?");
                bool good = long.TryParse(Console.ReadLine(), out long numbase2);
                if (good && numbase2 <= 9 || numbase >= 11 && numbase <= 16)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    int res =(int) Util.BaseToBase.BaseToDec(a, numbase);
                    Console.WriteLine(Util.BaseToBase.DecToBase(res, numbase2));
                    Console.ReadLine();
                }
                else if (good && numbase2 == 10)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    Console.WriteLine(Util.BaseToBase.BaseToDec(a, numbase));
                }
                else if (good && numbase2>= 11 && numbase2 <= 16)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    int b =(int) (Util.BaseToBase.BaseToDec(a, numbase));
                    Console.WriteLine(Util.BaseToBase.DecToHexa(b, numbase2));
                }
            }
            else if (success && numbase >= 11 && numbase <= 16)
            {
                Console.WriteLine("What base do you want to convert to?");
                bool good = int.TryParse(Console.ReadLine(), out int numbase2);
                if (good && numbase2 <= 9 || numbase >= 11 && numbase <= 16)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    int res =(int) (Util.BaseToBase.HexaToDec(a, numbase));
                    Console.WriteLine(Util.BaseToBase.DecToBase(res, numbase2));
                    Console.ReadLine();
                }
                else if (good && numbase2 == 10)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    Console.WriteLine(Util.BaseToBase.BaseToDec(a, numbase));
                }
            }

        }
    }
}
