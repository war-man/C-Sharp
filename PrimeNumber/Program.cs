using System;
using System.Collections.Generic;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            try
            {
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                List<int> remaiderList = new List<int>();
                int i = 2;
                while (i < inputNumber) {
                    remaiderList.Add(inputNumber%i);
                    i++;
                }

                if (remaiderList.FindIndex(x => x == 0) != -1) {
                    Console.WriteLine("Not a prime number");
                } else {
                    Console.WriteLine("This is a prime number");
                }
            }
            catch (System.FormatException f)
            {
                Console.WriteLine("You must enter a number");
                Console.WriteLine(f.Message);
            }
        }
    }
}
