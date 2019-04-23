using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuizApp
{
    class Program
    {

        static int result = 0;
        static string q1 = @"
1. What is the capital of Nigeria?

A. Lagos
B. Ikeja
C. Abuja
D. Port Harcourt
";
        static string q2 = @"
2. How old is Nigeria?

A. 55 years
B. 60 years
C. 58 years
D. 59 years
";
        static string q3 = @"
3. In what year did Nigeria become a republic?

A. 1960
B. 1961
C. 1962
D. 1963
";
        static string q4 = @"
4. Which of these countries is not in Africa?

A. Tunisia
B. Seychelles
C. Morocco
D. None of the above
";
        static string q5 = @"
5. Which of these musicians sang the song titled 'Shape of you'

A. Justin Bieber
B. Usher
C. Bruno Mars
D. Ed Sheeran
";
        static string q6 = @"
6. What is the capital of Canada?

A. Toronto
B. Ottawa
C. Edmonton
D. Victoria
";
        static string q7 = @"
7. In what season did the son of Lyanna Stark in Game of Thrones die?

A. Season 3
B. Season 4
C. Season 5
D. Season 6
";
        static string q8 = @"
8. Which of the following statements is not true?

A. Arsenal FC is based in London.
B. Chelsea FC have never won the Champions League.
C. Manchester City are the defending champions of the English Premier League.
D. Old trafford is a stadium in Manchester.
";
        static string q9 = @"
9. If the base of a triangle is 10 and its height is 15, what is the area of the triangle?

A. 150
B. 75
C. 25
D. 50
";
        static string q10 = @"
10. Which book has this quote 'Please sir, I want some more' and who wrote it?

A. Oliver Twist, Charles Darwin
B. Harry Potter, J. K. Rowling
C. Oliver Twist, Charles Dickens
D. How the Grinch stole christmas, Dr Seus
"; 
        
        static void Main(string[] args)
        {
            DataInput();
            ReadLine();
        }
        static void DataInput()
        {
            
            WriteLine("Please input your name and press enter");
            string name = ReadLine();
            name = name.ToUpper();
            WriteLine("Please input your address and press enter");
            string address = ReadLine();
            incorrect:
            WriteLine("Please input your age and press enter");
            bool success = int.TryParse(ReadLine(), out int age);
            if (success)
                { goto startquiz;
            }
            else
                {
                WriteLine("You input an invalid age");
                    goto incorrect;
                }
            startquiz:
            WriteLine("The quiz you are about to write consists of 10 questions");
            WriteLine("Each question contains 4 options (A-D) ");
            WriteLine("Please input the option of your choice and press enter");
            WriteLine("Only one option is accepted");
            WriteLine("Goodluck");
            notright:
            WriteLine("Please press 1 then enter to start the quiz");
            bool good = int.TryParse(ReadLine(), out int start);
            if (good && start==1)
                 {
                    goto begin;
                 }
            else
                {
                    WriteLine("You input an invalid character");
                    goto notright;
                }
            
            begin:
            stop1:
            WriteLine(q1);
            string a1 = ReadLine();
            a1= a1.ToUpper();
            if (a1 == "A"|| a1 =="B" || a1 == "D")
            {
                goto q2;
            }
           
            else if (a1 == "C")
            {
                
                result = result + 1;
                goto q2;
            }
           
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop1;
             }
            q2:
            stop2:
            WriteLine(q2);
            string a2 = ReadLine();
            a2 = a2.ToUpper();
            if (a2 == "A"|| a2=="B" || a2=="D")
            {
                goto q3;
            }
            else if (a2 == "C")
            {
                result = result + 1;
                goto q3;
            }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop2;
            }
            q3:
            stop3:
            WriteLine(q3);
            string a3 = ReadLine();
            a3 = a3.ToUpper();
            if (a3 == "A"|| a3=="B"||a3=="C")
            {
                goto q4;
            }
             else if (a3 == "D")
            {
                result = result + 1;
                goto q4;
            }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop3;
            }
            q4:
            stop4:
            WriteLine(q4);
            string a4 = ReadLine();
            a4 = a4.ToUpper();
            if (a4 == "A"|| a4=="B"||a4=="C")
            {
                goto q5;
            }
            else if (a4 == "D")
            {
                result = result + 1;
                goto q5;
            }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop4;
            }
            q5:
            stop5:
            WriteLine(q5);
            string a5 = ReadLine();
            a5 = a5.ToUpper();
            if (a5 == "A"||a5=="B"||a5=="C")
            {
                goto q6;
            }
            else if (a5 == "D")
            {
                result = result + 1;
                goto q6;
            }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop5;
            }
            q6:
            stop6:
            WriteLine(q6);
            string a6 = ReadLine();
            a6 = a6.ToUpper();
            if (a6 == "A"|| a6=="C"||a6=="D")
            {
                goto q7;
            }
            else if (a6 == "B")
            {
                result = result + 1;
                goto q7;
            }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop6;
            }
         q7:
         stop7:
            WriteLine(q7);
            string a7 = ReadLine();
            a7 = a7.ToUpper();
            if (a7 == "A"|| a7=="B"|| a7=="D")
            {
                goto q8;
            }
            else if (a7 == "C")
            {
                result = result + 1;
                goto q8;
            }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop7;
            }
        q8:
        stop8:
            WriteLine(q8);
            string a8 = ReadLine();
            a8 = a8.ToUpper();
            if (a8 == "A"|| a8=="C"|| a8=="D")
            {
                goto q9;
            }
            else if (a8 == "B")
            {
                result = result + 1;
                goto q9;
            }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop8;
            }
        q9:
        stop9:
            WriteLine(q9);
            string a9 = ReadLine();
            a9 = a9.ToUpper();
            if (a9 == "A" || a9=="C"||a9=="D")
            {
                goto q10;
            }
            else if (a9 == "B")
            {
                result = result + 1;
                goto q10;
            }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop9;
            }
        q10:
        stop10:
            WriteLine(q10);
            string a10 = ReadLine();
            a10 = a10.ToUpper();
            if (a10 == "A"|| a10=="B"||a10=="D")
            {
                goto result1;
            }
            else if (a10 == "C")
            {
                result = result + 1;
                goto result1;
             }
            else
            {
                WriteLine("Please input an option from A-D");
                goto stop10;
            }
        result1:
            result = (result * 100) / 10;
            WriteLine($"Dear {name}, your score is {result}%");
            answers:
            WriteLine("Press 1 then enter to display the correct answers");
            bool nice = int.TryParse(Console.ReadLine(), out int f);
            if (nice && f==1)
            {
                WriteLine("Here are the questions and correct answers");
                WriteLine(q1);
                WriteLine($"You selected: {a1}, the correct answer is C. Press enter");
                ReadLine();
                goto right2;
                right2:
                WriteLine(q2);
                WriteLine($"You selected: {a2}, the correct answer is C. Press ener");
                ReadLine();
                goto right3;
            right3:
                WriteLine(q3);
                WriteLine($"You selected: {a3}, the correct answer is D. Press ener");
                ReadLine();
                goto right4;
            right4:
                WriteLine(q4);
                WriteLine($"You selected: {a4}, the correct answer is D. Press ener");
                ReadLine();
                goto right5;
            right5:
                WriteLine(q5);
                WriteLine($"You selected: {a5}, the correct answer is D. Press ener");
                ReadLine();
                goto right6;
            right6:
                WriteLine(q6);
                WriteLine($"You selected: {a6}, the correct answer is B. Press ener");
                ReadLine();
                goto right7;
            right7:
                WriteLine(q7);
                WriteLine($"You selected: {a7}, the correct answer is C. Press ener");
                ReadLine();
                goto right8;
            right8:
                WriteLine(q8);
                WriteLine($"You selected: {a8}, the correct answer is B. Press ener");
                ReadLine();
                goto right9;
            right9:
                WriteLine(q9);
                WriteLine($"You selected: {a9}, the correct answer is B. Press ener");
                ReadLine();
                goto right10;
            right10:
                WriteLine(q10);
                WriteLine($"You selected: {a10}, the correct answer is C.");
                ReadLine();
            }
            else
            {
                WriteLine("You input an ivalid character");
                goto answers;
            }
         }
    }
}
