using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {};
            List<int> squares = new List<int>() {};
            var result = TestForSquares(numbers, squares);
            Console.WriteLine(result);
        }

        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            var squareResult = numbers.Select(num => num*num).ToList();
            var squareList = squares.ToList();
            bool checkResult = squareResult.SequenceEqual(squareList);
            return checkResult;
        }
    }
}
