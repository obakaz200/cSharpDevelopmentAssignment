using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The duration till Christmas is {0} Months and {1} days",Months(Days()), Days2(Days()));
            
            Console.ReadLine();
        }
        static int Days()
        {
            DateTime currentDate =  DateTime.Today;
            DateTime christmas = new DateTime(2019,12,25);
            int daysTillChristmas = christmas.Subtract(currentDate).Days;
            TimeSpan ss = new TimeSpan();
            

            return daysTillChristmas ;
        }
        static int Months(int a)
        {
            a = a / 30;
            
            return a;
        }
        static int Days2(int a)
        {
            int b = a % 30;

            return b;
        }
        
    }
}
