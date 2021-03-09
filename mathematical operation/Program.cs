using System;
using System.Collections.Generic;

namespace mathematical_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            double result = 0;

            Console.WriteLine("Enter mathematical operation:");
            var operation = Console.ReadLine();
            try
            {
                var input = operation.Split(" ");

                List<string> elements = new List<string>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != "" && input[i] != null)
                    {
                        elements.Add(input[i]);
                    }
                }

                try
                {
                    if (elements[0].Length <= 6)
                    {
                        number1 = double.Parse(elements[0]);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("first number is longer that 6 characters");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Error.WriteLine("You did not provide data for first number. Please, try again");
                    Console.Error.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Number one was incorrectly entered! Please, try again");
                    Console.WriteLine(ex.Message);
                }
                try
                {

                    if (elements[2].Length <= 6)
                    {
                        number2 = double.Parse(elements[2]);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("first number is longer that 6 characters");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Error.WriteLine("You did not provide data for second number. Please, try again");
                    Console.Error.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Number two was incorrectly entered! Please, try again");
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    switch (elements[1])
                    {
                        case "-":
                            result = number1 - number2;
                            break;
                        case "+":
                            result = number1 + number2;
                            break;
                        case "*":
                            result = number1 * number2;
                            break;
                        case "/":
                            try
                            {
                                result = number1 / number2;
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("adsdas");
                                throw new DivideByZeroException("You try to devide by zero");
                            }

                            break;
                        default:
                            Console.WriteLine("You entered invalid operand. Try again later");
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Error.WriteLine("You did not provide operand. Please, try again");
                    Console.Error.WriteLine(ex.Message);
                }
                Console.WriteLine($"The result of {operation} operation is {result}");

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("You did not provide an input information. Please, try again");
                Console.Error.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
