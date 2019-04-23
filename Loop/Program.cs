using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            while(a<10)
            {
                a++;
                Console.WriteLine(a);
            };

            Console.WriteLine();


            int b = 0;
            do
            {
                b++;
                Console.WriteLine(b);
            } while (b<10);

            Console.WriteLine();

            int c = 1;
            while (c<=9)
            {
                c = c+2;
                Console.WriteLine(c);
            };
             int d = 1;
             do
             {
                 d = d+2 ;
                 Console.WriteLine(d);
             } while (d < 10);



             /*Console.WriteLine(NumWhile());
             Console.WriteLine();
             Console.WriteLine(NumDo());
             Console.WriteLine();
             Console.WriteLine(OddWhile());
             Console.WriteLine();
             Console.WriteLine(OddDo());
             Console.WriteLine();
             Console.WriteLine(EvenWhile());
             Console.WriteLine();
             Console.WriteLine(EvenDo());*/
            Console.ReadLine();
        }
        static int NumWhile()
        {
            int i = 0;
            while (i<=10)
            {
                i++;
                Console.WriteLine(i);
                if (i == 10) break;
            }
            return 0;
        }
        static int NumDo()
        {
            int i = 0;
            do

            {
                i++;
                Console.WriteLine(i);
                if (i == 10) break;
            } while (i<=10);
            return 0;
        }
        static int OddWhile()
        {
            int i = -1;
            while (i<=10)
            {
                i += 2;
                Console.WriteLine(i);
                if (i == 9) break;
            }

            return 0;
        }
        static int OddDo()
        {
            int i = -1;
            do
            {
                i += 2;
                Console.WriteLine(i);
                if (i == 9) break;
            } while (i<=10);
            return 0;
        }

        static int EvenWhile()
        {
            int i = 0;
            while (i <= 10)
            {
                i += 2;
                Console.WriteLine(i);
                if (i == 10) break;
            }

            return 0;
        }
        static int EvenDo()
        {
            int i = 0;
            do
            {
                i += 2;
                Console.WriteLine(i);
                if (i == 10) break;
            } while (i <= 10);
            return 0;
        }
    }
}
