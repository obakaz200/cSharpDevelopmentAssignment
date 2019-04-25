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
            bool success = long.TryParse(Console.ReadLine(), out long input);
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
            else if (success && input >= 1000000000 & input <= 999999999999)
            {
                Console.WriteLine(Billion(input));
            }
            else if (success && input >= 1000000000000 & input <= 999999999999999)
            {
                Console.WriteLine(Trillion(input));
            }

        }
        static string First19(long input)
        {
            if( input>0 && input<=19)
            {
                ab = first19[input];
            }
            return ab;
        }
        static string Tens(long input)
        {

            
            /*if ( input <= 19)
            {
                int firstDigit = input ;
                int secondDigit = input % 10;
                ab = first19[input];
                
            }*/
             if ( input >= 20 && input <= 99)
            {
                long firstDigit = input/10;
                long secondDigit = input % 10;
                ab= tens[firstDigit]+" "+first19[secondDigit];
            }
            return ab;
            
        }
        static string Hundreds(long input)
        {
            string a = input.ToString();
            if (a.Length==3)
            {
                long firstDigit = input / 100;
                long remainingDigit = input % 100;
                if (remainingDigit == 0)
                {
                    ab = first19[firstDigit] + " hundred";
                }
                else if (remainingDigit <= 19)
                {
                    ab = first19[firstDigit] + " hundred and " +
                    First19(remainingDigit);
                }
                else
                {
                    ab = first19[firstDigit] + " hundred and "+
                    Tens(remainingDigit);
                }
                
            }
            return ab;
        }
        static string Thousand(long input)
        {
            string a = input.ToString();
            if (a.Length == 4)
            {
                long firstDigit = input / 1000;
                long remainingDigit = input % 1000;
                if (remainingDigit == 0)
                {
                    ab= first19[firstDigit] + " thousand ";
                }
                else if (remainingDigit > 0 && remainingDigit <= 19)
                {
                    ab = first19[firstDigit] + " thousand and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit >19 && remainingDigit <=99)
                {
                    ab = first19[firstDigit] + "thousand and "+
                    Tens(remainingDigit);
                }
                else if (remainingDigit > 100 && remainingDigit <= 999)
                {
                    ab=first19[firstDigit] + "thousand, "+ Hundreds(remainingDigit);
                }

            }
            else if (a.Length == 5)
            {
                long firstDigit = input / 1000;
                long remainingDigit = input % 1000;
               
                
                if (firstDigit <= 19)
                {
                    ab = first19[firstDigit];
                 }
                else if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab = Tens(firstDigit) +
                    " thousand, " + Hundreds(remainingDigit);

                }
                 if (remainingDigit == 0)
                {
                    ab = Tens(firstDigit) +
                        " thousand ";
                }
                 else if (remainingDigit > 0 && remainingDigit <= 19)
                {
                    ab = Tens(firstDigit) +
                     " thousand and " +
                     First19(remainingDigit);
                }
                else if (remainingDigit > 19 && remainingDigit <= 99)
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
                

            }
            else if (a.Length == 6)
            {

                long firstDigit = input / 1000;
                long remainingDigit = input % 1000;
                if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab = Hundreds(firstDigit) +
                    " thousand, ";
                }
                  if (remainingDigit == 0)
                {
                    ab= Hundreds(firstDigit)+
                    " thousand, ";
                }
                else if (remainingDigit > 0 &&  remainingDigit <=19)
                {
                    ab = Hundreds(firstDigit) +
                    " thousand and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit > 19 && remainingDigit <= 99)
                {
                    ab=Hundreds(firstDigit)+
                    " thousand and "+
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
        static string Million(long input)
        {
            string a = input.ToString();
            if (a.Length == 7)
            {
                long firstDigit = input / 1000000;
                long remainingDigit = input % 1000000;
                if (remainingDigit == 0)
                {
                    ab= first19[firstDigit] + " million ";
                }
                else if (remainingDigit <= 19)
                {
                    ab = first19[firstDigit] + " million and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit>19 && remainingDigit <= 99)
                {
                    ab=first19[firstDigit] + " million and "+
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab = first19[firstDigit] +
                    " million, " +
                    Hundreds(remainingDigit);
                }
                else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                {
                    ab = first19[firstDigit] +
                    " million, " +
                    Thousand(remainingDigit);
                }

                else
                {
                   ab=first19[firstDigit] + " million, "+
                    Thousand(remainingDigit);
                }

            }
            else if (a.Length == 8)
            {
                long firstDigit = input / 1000000;
                long remainingDigit = input % 1000000;
                 if (firstDigit <= 19)
                {
                    ab = first19[firstDigit];

                }
                else if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab = Tens(firstDigit) +
                    " million, ";
                }
                else if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab = Hundreds(firstDigit) +
                    " million, ";
                }
                 if (remainingDigit == 0)
                {
                    ab=Tens(firstDigit)+
                   " million, ";
                }
                else if (remainingDigit <= 19)
                {
                    ab = Tens(firstDigit) +
                    " million and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit >19 && remainingDigit <= 99)
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
                

            }
            else if (a.Length == 9)
            {
                long firstDigit = input / 1000000;
                long remainingDigit = input % 1000000;
                 if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab = Tens(firstDigit) +
                    " million, " ;
                }
                else if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab = Hundreds(firstDigit) +
                    " million, ";
                }

                 if (remainingDigit == 0)
                {
                    ab=Hundreds(firstDigit)+
                    " million, ";
                }
                else if (remainingDigit <= 19)
                {
                    ab = Hundreds(firstDigit) +
                    " million and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit >19 &&remainingDigit <= 99)
                {
                    ab=Hundreds(firstDigit)+
                    " million and "+
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
                
            }
            return ab;
        }
        static string Billion(long input)
        {
            string a = input.ToString();
            if (a.Length == 10)
            {
                long firstDigit = input / 1000000000;
                long remainingDigit = input % 1000000000;
                if (remainingDigit == 0)
                {
                    ab = first19[firstDigit] + " billion ";
                }
                else if (remainingDigit <= 19)
                {
                    ab = first19[firstDigit] + " billion and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit >19 && remainingDigit <= 99)
                {
                    ab = first19[firstDigit] + " billion and " +
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab = first19[firstDigit] +
                    " billion, " +
                    Hundreds(remainingDigit);
                }
                else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                {
                    ab = first19[firstDigit] +
                    " billion, " +
                    Thousand(remainingDigit);
                }
                else if (remainingDigit >= 1000000 && remainingDigit <= 999999999)
                {
                    ab = first19[firstDigit] +
                    " billion, " +
                    Million(remainingDigit);
                }

                else
                {
                    ab = first19[firstDigit] + " billion, " +
                     Million(remainingDigit);
                }

            }
            else if (a.Length == 11)
            {
                long firstDigit = input / 1000000000;
                long remainingDigit = input % 1000000000;
                if (firstDigit <= 19)
                {
                    ab = first19[firstDigit] + " billion " ;

                }
                else if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab = Tens(firstDigit) +
                    " billion, ";
                   
                }
                
                if (remainingDigit == 0)
                {
                    ab = Tens(firstDigit) +
                   " billion, ";
                }
                else if (remainingDigit <= 19)
                {
                    ab = Tens(firstDigit) +
                    " billion and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit>19 && remainingDigit <= 99)
                {
                    ab = Tens(firstDigit) +
                    " billion and " +
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab = Tens(firstDigit) +
                    " billion, " +
                    Hundreds(remainingDigit);
                }
                else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                {
                    ab = Tens(firstDigit) +
                    " billion, " +
                    Thousand(remainingDigit);
                }
                else if (remainingDigit >= 1000000 && remainingDigit <= 999999999)
                {
                    ab = Hundreds(firstDigit) +
                    " billion, " +
                    Million(remainingDigit);
                }
                

            }
            else if (a.Length == 12)
            {
                long firstDigit = input / 1000000000;
                long remainingDigit = input % 1000000000;
                 if (firstDigit <= 19)
                {
                    ab = first19[firstDigit] + " billion ";

                }
                else if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab = Tens(firstDigit) +
                    " billion, " ;
                }
                else if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab = Hundreds(firstDigit) +
                    " billion, " ;
                }
                 if (remainingDigit == 0)
                {
                    ab = Hundreds(firstDigit) +
                    " billion, ";
                }
                else if (remainingDigit <= 19)
                {
                    ab = Hundreds(firstDigit) +
                    " billion and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit >19 && remainingDigit <= 99)
                {
                    ab = Hundreds(firstDigit) +
                    " billion and " +
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab = Hundreds(firstDigit) +
                    " billion, " +
                    Hundreds(remainingDigit);
                }
                else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                {
                    ab = Hundreds(firstDigit) +
                    " billion, " +
                    Thousand(remainingDigit);
                }
                else if (remainingDigit >= 1000000 && remainingDigit <= 999999999)
                {
                    ab = Hundreds(firstDigit) +
                    " billion, " +
                    Million(remainingDigit);
                }
                else if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab = Tens(firstDigit) +
                    " billion, " +
                   Million(remainingDigit);
                }
                else if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab = Hundreds(firstDigit) +
                    " billion, " +
                    Million(remainingDigit);
                }
            }
            return ab;
        }
        static string Trillion(long input)
        {
            string a = input.ToString();
            if (a.Length == 13)
            {
                long firstDigit = input / 1000000000000;
                long remainingDigit = input % 1000000000000;
                if (remainingDigit == 0)
                {
                    ab = first19[firstDigit] + " trillion ";
                }
                else if (remainingDigit <= 19)
                {
                    ab = first19[firstDigit] + " trillion and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit > 19 && remainingDigit <= 99)
                {
                    ab = first19[firstDigit] + " trillion and " +
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab = first19[firstDigit] +
                    " trillion, " +
                    Hundreds(remainingDigit);
                }
                else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                {
                    ab = first19[firstDigit] +
                    " trillion, " +
                    Thousand(remainingDigit);
                }
                else if (remainingDigit >= 1000000 && remainingDigit <= 999999999)
                {
                    ab = first19[firstDigit] +
                    " trillion, " +
                    Million(remainingDigit);
                }
                else if (remainingDigit >= 1000000000 && remainingDigit <= 999999999999)
                {
                    ab = first19[firstDigit] +
                    " trillion, " +
                    Billion(remainingDigit);
                }

                else
                {
                    ab = first19[firstDigit] + " trillion, " +
                     Billion(remainingDigit);
                }

            }
            else if (a.Length == 14)
            {
                long firstDigit = input / 1000000000000;
                long remainingDigit = input % 1000000000000;
                if (firstDigit <= 19)
                {
                    ab = first19[firstDigit] + " trillion ";
                   

                }
                else if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab = Tens(firstDigit) +
                    " trillion, ";
                    
                }
                else if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab = Hundreds(firstDigit) +
                    " trillion, ";
                    
                }
                 if (remainingDigit == 0)
                {
                    ab = Tens(firstDigit) +
                   " trillion, ";
                }
                else if (remainingDigit <= 19)
                {
                    ab = Tens(firstDigit) +
                    " trillion and " +
                    First19(remainingDigit);
                }
                else if (remainingDigit > 19 && remainingDigit <= 99)
                {
                    ab = Tens(firstDigit) +
                    " trillion and " +
                    Tens(remainingDigit);
                }
                else if (remainingDigit >= 100 && remainingDigit <= 999)
                {
                    ab = Tens(firstDigit) +
                    " trillion, " +
                    Hundreds(remainingDigit);
                }
                else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                {
                    ab = Tens(firstDigit) +
                    " trillion, " +
                    Thousand(remainingDigit);
                }
                else if (remainingDigit >= 1000000 && remainingDigit <= 999999999)
                {
                    ab = Tens(firstDigit) +
                    " trillion, " +
                    Million(remainingDigit);
                }
                else if (remainingDigit >= 1000000000 && remainingDigit <= 999999999999)
                {
                    ab = Tens(firstDigit) +
                    " trillion, " +
                    Billion(remainingDigit);
                }
                 

            }
            else if (a.Length == 15)
            {
                long firstDigit = input / 1000000000000;
                long remainingDigit = input % 1000000000000;
                if (firstDigit > 19 && firstDigit <= 99)
                {

                    ab = Tens(firstDigit) +
                    " trillion, " ;
                }
                else if (firstDigit > 99 && firstDigit <= 999)
                {

                    ab = Hundreds(firstDigit) +
                    " trillion, " ;
                }
                
                     if (remainingDigit == 0)
                    {
                        ab = Hundreds(firstDigit) +
                        " trillion, ";
                    }
                    else if (remainingDigit <= 19)
                    {
                        ab = Hundreds(firstDigit) +
                        " trillion and " +
                        First19(remainingDigit);
                    }
                    else if (remainingDigit > 19 && remainingDigit <= 99)
                    {
                        ab = Hundreds(firstDigit) +
                        " trillion and " +
                        Tens(remainingDigit);
                    }
                    else if (remainingDigit >= 100 && remainingDigit <= 999)
                    {
                        ab = Hundreds(firstDigit) +
                        " trillion, " +
                        Hundreds(remainingDigit);
                    }
                    else if (remainingDigit >= 1000 && remainingDigit <= 999999)
                    {
                        ab = Hundreds(firstDigit) +
                        " trillion, " +
                        Thousand(remainingDigit);
                    }
                    else if (remainingDigit >= 1000000 && remainingDigit <= 999999999)
                    {
                        ab = Hundreds(firstDigit) +
                        " trillion, " +
                        Million(remainingDigit);
                    }
                    else if (remainingDigit >= 1000000000 && remainingDigit <= 999999999999)
                    {
                        ab = Hundreds(firstDigit) +
                        " trillion, " +
                        Billion(remainingDigit);
                    }
                
                 

            }
            return ab;
        }

       
    }
}