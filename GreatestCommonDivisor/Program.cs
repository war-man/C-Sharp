using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input the first number");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the second number");
                int secondNum = Convert.ToInt32(Console.ReadLine());

                int result = firstNum;
                while (true) {
                    if (firstNum%result == 0 && secondNum%result == 0) {
                        Console.WriteLine("Greatest Common Divisor is: " + result);
                        break;
                    }
                    result--;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You must enter a number");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
