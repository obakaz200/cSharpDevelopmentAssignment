using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseToBase
{
    class BaseToBase
    {
        static void Main(string[] args)
        {
            Display();
            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("What base do you want to convert from?");
            bool success = int.TryParse(Console.ReadLine(), out int numbase);
            if (success && numbase <= 10)
            {
                Console.WriteLine("What base do you want to convert to?");
                bool good = int.TryParse(Console.ReadLine(), out int numbase2);
                if (good && numbase2 <= 9 || numbase == 16)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    int res = (BaseToDec(a, numbase));
                    Console.WriteLine(DecToBase(res, numbase2));
                    Console.ReadLine();
                }
                else if (good && numbase2 == 10)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    Console.WriteLine(BaseToDec(a, numbase));
                }
                else if (good && numbase2 == 16)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    int b = (BaseToDec(a, numbase));
                    Console.WriteLine(DecToHexa(b));
                }
            }
            else if (success && numbase == 16)
            {
                Console.WriteLine("What base do you want to convert to?");
                bool good = int.TryParse(Console.ReadLine(), out int numbase2);
                if (good && numbase2 <= 9 || numbase == 16)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    int res = (HexaToDec(a));
                    Console.WriteLine(DecToBase(res, numbase2));
                    Console.ReadLine();
                }
                else if (good && numbase2 == 10)
                {
                    Console.WriteLine("What is the number you want to covert");
                    string a = Console.ReadLine();
                    Console.WriteLine($"{a} from base{numbase} to base{numbase2} is");
                    Console.WriteLine(BaseToDec(a, numbase));
                }
            }

            
        }
        static int BaseToDec(string a, int numbase)
        {
            int res = 0;
            int x = 0;
            char[] charArr = a.ToCharArray();
            int n = charArr.Length;
            int chars = 0;
           
                while (n >= 0 && x < charArr.Length)
                {
                    chars = int.Parse(charArr[x].ToString());
                    res = chars * ((int)Math.Pow(numbase, n-1) )+ res;//Converts characters to integers
                    x++;
                    n--;
                 }
            return res;
        }
        static string DecToBase(int res, int numbase2)
        {

            double remainder;
            string basen = "";
        
            while (res > 0)
            {
                remainder = res % numbase2;
                res = res / numbase2;
                basen = remainder.ToString() + basen;
            }
          
            
                return basen;
        
     
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
                deci += values * (int)Math.Pow(16, n - 1);
                n--;
            }
            return deci;
        }
        static string DecToHexa(int a)
        {
            string c = a.ToString().ToUpper();
            string hexMap = "0123456789abcdef".ToUpper();
            int remainder;
            string basen = "";
            string index="";
            for (int i=0; i<c.Length; i++)
            {
                string value = c.Substring(i, 1);
                int values = hexMap.IndexOf(value);
                while (a > 0)
                {
                    remainder = a % 16;
                    index += hexMap[remainder].ToString();
                   
                    a = a / 16;
                    
                    basen = remainder.ToString() + basen;
                 }
            }
            return basen;
        }
    }
}
