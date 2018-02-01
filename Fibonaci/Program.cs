using System;
using System.Collections.Generic;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonaciNumbers = new List<int>(){0,1};
            int i = 0;
            while (fibonaciNumbers.Count < 10) {
                int newNumber = fibonaciNumbers[i] + fibonaciNumbers[i+1];
                fibonaciNumbers.Add(newNumber);
                i++;
            }

            foreach (int item in fibonaciNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
