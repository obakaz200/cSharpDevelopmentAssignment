using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            CharDemo();
            Console.WriteLine(Left("Happy People", 3));
            Console.WriteLine(Right("Happy People", 3));
            Console.WriteLine(Mid("Happy People",6, 2));
            
            Console.ReadLine();
            //String.Split
            string postTags = "Politics, election, 2019 voters card, presidential Election";
            string[] seperators = new[] {"," , "_" };
            string[] b = postTags.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(b.Length + "Separate String found!");
            if (b.Length >0)
            {
                foreach (string item in b)
                {
                    Console.WriteLine($"#{item.Trim().ToUpper()}");
                }
               

            }
            //String.Join()
            string joinedString = String.Join(",", b);
            Console.WriteLine(joinedString);
            Console.ReadLine();

            //Replace string
            string c = "Happy People";
            string newReplacedString = c.Replace("pp", "$$");
            Console.WriteLine(newReplacedString);
            Console.ReadLine();

            //Contains
            bool contains = c.Contains("pp");   // true
            bool startswith = c.StartsWith("eople"); //false

            //Index
            int index = c.IndexOf("z");
            Console.WriteLine(contains);
            Console.WriteLine(startswith);
            Console.WriteLine(index);
            Console.ReadLine();


        }
        static string Left(string a, int b)
        {
            
            string c = a.Substring(0, b);
            return c;

        }
        static string  Right(string a, int b)
        {
            
            string c = a.Substring(a.Length - b, b);
            return c;

        }
        static string Mid(string a, int b, int d)
        {


            string c = a.Substring( b-1 , d);
            return c;

        }

        //Character Datatype : char or System.Char in CTS ()Common Type Specification)
       static void CharDemo()
        {
            char a = 'A';
            char b = 'B';
            string ab = a.ToString() + b.ToString();
            Console.WriteLine(ab);
            Console.ReadLine();
        }
    }
}
