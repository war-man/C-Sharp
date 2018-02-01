using System;

namespace LeastCommonMultiple
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

                int result;
                int i = 1;
                while (true) {
                    result = firstNum * i;
                    if (result%secondNum == 0) {
                        Console.WriteLine("Least Common Multiple is: " + result);
                        break;
                    }
                    i++;
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
