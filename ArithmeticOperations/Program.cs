using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = new Operations();
            tryagain:
            Console.WriteLine("How many numbers do you want to find details about or work with?");
            bool success = int.TryParse(Console.ReadLine(), out int input);
            
            if (success && input >=2)
            {
                double[] numbers = new double[input];
                for (int i = 0; i < input; i++)
                {
                    start:
                    Console.WriteLine($"Input number{i + 1}");
                    bool success1 = double.TryParse(Console.ReadLine(), out double userInput);
                    if (success1)
                    {
                        numbers[i] = userInput;
                    }
                    else
                    {
                        Console.WriteLine("Please input a valid number");
                        goto start;
                    }
                }

                Calculate calculate = operations.AddNumbers;
                calculate += operations.MultiplyNumbers;
                calculate += operations.SubtractNumbers;
                calculate += operations.DivideNumbers;
                calculate(numbers);
                
                
            }
            else
            {
                Console.WriteLine("Your input is invalid");
                goto tryagain;
            }
            
            Console.ReadLine();
        }
    }
    public delegate double Calculate(params double[] numbers);

    public class Operations
    {
     
         static double result;
        public double AddNumbers(params double[] numbers)
        {
            Console.WriteLine($"The sum of all the numbers is {numbers.Sum()}");
            return numbers.Sum();
        }
        public double MultiplyNumbers(params double[] numbers)
        {
            result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = result * numbers[i];
            }
            Console.WriteLine($"The mulitplication of all the numbers is {result}");
            return result;
        }
        public double SubtractNumbers(params double[] numbers)
        {
            result = numbers[0];
            for (int i= 1; i<numbers.Length; i++)
            {
                result = result-numbers[i];
            }
            Console.WriteLine($"The subtraction of all the numbers is {result}");
            return result;
        }
        public double DivideNumbers(params double[] numbers)
        {
            result = numbers[0];
           
            if (numbers[0] == 0 && !numbers.Contains(0))
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    result = result / numbers[i];
                }
                Console.WriteLine($"The division of all the numbers is {result}");
            }
            else if (numbers[0] == 0)
                {
                for (int i = 1; i < numbers.Length; i++)
                {
                    result = result / numbers[i];
                }
                Console.WriteLine($"The division of all the numbers is {result}");
            }
            else 
            {
                Console.WriteLine("The division of all the numbers is Infinity");
            }
            return result;
        }
    }
}
