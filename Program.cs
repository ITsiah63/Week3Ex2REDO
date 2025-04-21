using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Ex2REDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Application");
            
                //declare user variables
                double num1;
                double num2;
                double input;


                //asking user to input numbers used in operation
                Console.WriteLine("What is the first Number?");
                num1 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("What is the second Number?");
                num2 = Convert.ToDouble(Console.ReadLine());
                
                //listing options for user to operate with their numbers
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1-Addition");
                Console.WriteLine("2-Subtraction");
                Console.WriteLine("3-Multiplication");
                Console.WriteLine("4-Division");
                
            //asks user to input their option
                Console.WriteLine("Choose an operation (1-4)");
                input = Convert.ToDouble(Console.Read());
            
                //processing what user input and the equation
                if (input == 1)
                {
                    double addition = (num1 + num2);
                    Console.WriteLine("The result of addition is: " + addition);
                }
                else if (input == 2)
                {
                    double subtraction = (num1 - num2);
                    Console.WriteLine("The result of subtraction is: " + subtraction);
                }
                else if (input == 3)
                {
                    double multiplication = (num1 * num2);
                    Console.WriteLine("The result of multiplaction is: " + multiplication);
                }
                else if (input == 4)
                {
                    double division = (num1 / num2);
                    Console.WriteLine("The result of division is: " + division);
                }
                Console.Read();
            
        }
    }
}
