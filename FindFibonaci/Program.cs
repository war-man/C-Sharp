using System;
using System.Collections.Generic;

namespace FindFibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the position you want to find in the Fibonaci order");
            int position = Convert.ToInt32(Console.ReadLine());
            List<int> fibonaciNumbers = new List<int>(){0,1};
            int i = 0;
            if (position == 0) {
                Console.WriteLine("Invalid input. Must be greater than 0");
            } else if (position == 1) {
                Console.WriteLine("Fibonaci number: " + fibonaciNumbers[0]);
            } else if (position == 2) {
                Console.WriteLine("Fibonaci number: " + fibonaciNumbers[1]); 
            } else {
                while (fibonaciNumbers.Count < position) {
                    int newNumber = fibonaciNumbers[i] + fibonaciNumbers[i+1];
                    fibonaciNumbers.Add(newNumber);
                    i++;
                }
                Console.WriteLine("Fibonaci number: " + fibonaciNumbers[position-1]);
            }
        }
    }
}
