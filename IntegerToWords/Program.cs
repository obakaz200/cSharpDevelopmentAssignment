using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToWords
{
    public class NumberToWord
        
    {
        public static string ab = "";
        public static string[] first19 = {"", "one", "two", "three", "four", "five", "six",
                                        "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                                              "seventeen", "eighteen", "nineteen"};
        public static string[] tens = {"", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty",
                                        "ninety"};
        public static void Main()
        {
            
            Display();
            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("Please input the number you wish to convert to words");
            bool success = int.TryParse(Console.ReadLine(), out int input);
            string c = input.ToString();
            if (success && input == 0)
            {
                Console.WriteLine("zero");
            }
            else if (success && input <= 19)
            {
                Console.WriteLine(First19(input));
            }
            else if (success && input >= 20 & input <= 99)
            {
                Console.WriteLine(Tens(input));
            }
            else if (success && input >= 100 & input <= 999)
            {
                Console.WriteLine(Hundreds(input));
            }
            else if (success && input >= 1000 & input <= 999999)
            {
                Console.WriteLine(Thousand(input));
            }
            else if (success && input >= 1000000 & input <= 999999999)
            {
                Console.WriteLine(Million(input));
            }
            
        }
        static string First19(int input)
        {
            if( input>0 && input<=19)
            {
                ab = first19[input];
            }
            return ab;
        }
        static string Tens(int input)
        {

            
            /*if ( input <= 19)
            {
                int firstDigit = input ;
                int secondDigit = input % 10;
                ab = first19[input];
                
            }*/
             if ( input >= 20 && input <= 99)
            {
                int firstDigit = input/10;
                int secondDigit = input % 10;
                ab= tens[firstDigit]+" "+first19[secondDigit];
            }
            return ab;
            
        }
        static string Hundreds(int input)
        {
            string a = input.ToString();
            if (a.Length==3)
            {
                int firstDigit = input / 100;
                int remainingDigit = input % 100;
                if (remainingDigit == 0)
                {
                    ab = first19[firstDigit] + " hundred";
                }
                else
                {
                    ab = first19[firstDigit] + " hundred and "+
                    Tens(remainingDigit);
                }
                
            }
            return ab;
        }
        static string Thousand(int input)
        {
            string a = input.ToString();
            if (a.Length == 4)
            {
                int firstDigit = input / 1000;
                int remainingDigit = input % 1000;
                if (remainingDigit == 0)
                {
                    ab= first19[firstDigit] + "thousand ";
                }
                else if (remainingDigit <=99)
                {
                    ab = first19[firstDigit] + "thousand and "+
                    Tens(remainingDigit);
                }
                else
                {
                    ab=first19[firstDigit] + "thousand, "+ Hundreds(remainingDigit);
                }

            }
            else if (a.Length == 5)
            {
                int firstDigit = input / 1000;
                int remainingDigit = input % 1000;
                int remainingDigit2 = input % 10000;
                if (remainingDigit == 0)
                {
                    ab = firstDigit+
                        " thousand ";
                }
                else if (remainingDigit <= 99)
                {
                   ab= Tens(firstDigit)+
                    " thousand and "+
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab=Tens(firstDigit)+
                        " thousand, "+
                        Hundreds(remainingDigit);
                }
                else if (firstDigit <= 19)
                {
                    ab=first19[firstDigit] + " thousand "+
                    Hundreds(remainingDigit);
                    
                }
                else if (firstDigit > 19 && firstDigit <=99)
                {

                    ab=Tens(firstDigit)+
                    " thousand, "+
                    Hundreds(remainingDigit);
                }

            }
            else if (a.Length == 6)
            {
                int firstDigit = input / 1000;
                int remainingDigit = input % 1000;
                if (remainingDigit == 0)
                {
                    ab= Hundreds(firstDigit)+
                    " thousand, ";
                }
                else if (remainingDigit <= 99)
                {
                    ab=Hundreds(firstDigit)+
                    "thousand and "+
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab=Hundreds(firstDigit)+
                    " thousand, "+
                    Hundreds(remainingDigit);
                }

            }
            return ab;
        }
        static string Million(int input)
        {
            string a = input.ToString();
            if (a.Length == 7)
            {
                int firstDigit = input / 1000000;
                int remainingDigit = input % 1000000;
                if (remainingDigit == 0)
                {
                    ab= first19[firstDigit] + " million ";
                }
                else if (remainingDigit <= 99)
                {
                    ab=first19[firstDigit] + " million and "+
                    Tens(remainingDigit);
                }
                
                else
                {
                   ab=first19[firstDigit] + " million, "+
                    Thousand(remainingDigit);
                }

            }
            else if (a.Length == 8)
            {
                int firstDigit = input / 1000000;
                int remainingDigit = input % 1000000;
                if (remainingDigit == 0)
                {
                    ab=Tens(firstDigit)+
                   " million, ";
                }
                else if (remainingDigit <= 99)
                {
                    ab= Tens(firstDigit)+
                    " million and "+
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab=Tens(firstDigit)+
                    " million, "+
                    Hundreds(remainingDigit);
                }
                else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                {
                    ab=Tens(firstDigit)+
                    " million, "+
                    Thousand(remainingDigit);
                }
                else if (firstDigit <= 19)
                {
                    ab=first19[firstDigit] + " million "+
                    Thousand(remainingDigit);

                }
                else if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab=Tens(firstDigit)+
                    " million, "+
                    Hundreds(remainingDigit);
                }
                else if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab=Hundreds(firstDigit)+
                    " million, "+
                    Thousand(remainingDigit);
                }

            }
            else if (a.Length == 9)
            {
                int firstDigit = input / 1000000;
                int remainingDigit = input % 1000000;
                if (remainingDigit == 0)
                {
                    ab=Hundreds(firstDigit)+
                    "million, ";
                }
                else if (remainingDigit <= 99)
                {
                    ab=Hundreds(firstDigit)+
                    "million and "+
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab = Hundreds(firstDigit) +
                    " million, " +
                    Hundreds(remainingDigit);
                }
                else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                {
                    ab=Hundreds(firstDigit)+
                    " million, "+
                    Thousand(remainingDigit);
                }
                else if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab= Tens(firstDigit)+
                    " million, "+
                    Hundreds(remainingDigit);
                }
                else if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab=Hundreds(firstDigit)+
                    " million, "+
                    Thousand(remainingDigit);
                }

            }
            return ab;
        }
    }
}