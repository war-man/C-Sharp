using System;

namespace Polymorphism
{
    static class Calculator
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine($"First Add function result: {a+b}");
        }

        public static void Add(float a, float b)
        {
            Console.WriteLine($"Second Add function result: {a+b}");
        }
    }
}