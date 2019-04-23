using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = int.TryParse(Console.ReadLine(), out int a);
            if (success)
            BinaryToDecimal(a);
        }
        static void BinaryToDecimal(int a)
        {
            int binNum, decNum = 0, baseNum = 1, rem;
            
            binNum = a;

            while (a > 0)
            {
                rem = a % 10;
                decNum = decNum + rem * baseNum;
                a = a / 10;

                baseNum = baseNum * 2;
            }
            Console.Write("Binary Number: " + binNum);
            Console.Write("\nDecimal: " + decNum);
            Console.ReadLine();
        }
    }
}
    
