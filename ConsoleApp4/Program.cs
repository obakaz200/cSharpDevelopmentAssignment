using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Base2
    {
        static void Main(string[] args)
        {

            Console.WriteLine(HexaToDec("AE"));
            Console.ReadLine();
        }

        static int HexaToDec(string a)
        {
            string hexMap = "0123456789abcdef".ToUpper();
            string numb = a.ToUpper();
            int deci = 0;
            int n = a.Length;
           
            for (int i = 0; i < a.Length; i++)
            {
                string value = numb.Substring(i, 1);
                int values = hexMap.IndexOf(value);
                 deci += values *(int) Math.Pow(16, n - 1);
                n--;
            }
            return deci;
        }
    }
}
