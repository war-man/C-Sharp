using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(1.5f , 2.4f);

            Defender maldini = new Defender("maldini");
            maldini.duty("defend the goal");

            Midfielder pirlo = new Midfielder("pirlo");
            pirlo.duty("Pass the ball");
        }
    }
}
