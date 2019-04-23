using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base2
{
    class Base2
    {
        static void Main(string[] args)
        { 
        
            Console.WriteLine(Binary(120));
            Console.ReadLine();
        }

        static string Binary(int a)
        {
            int remainder;
            string base2 = "";
        startHere:
            if (a > 0)
            {
                remainder = a % 2;
                a = a / 2;
                base2 = remainder.ToString() + base2;
            }
            else
            {
                return base2;
            }
            goto startHere;



        }

    }
}
