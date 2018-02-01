using System;

namespace Polymorphism
{
    public abstract class Footballer
    {
        public abstract void duty(string duty);
    }

    public class Defender: Footballer
    {
        public string Name { get; set; }

        public Defender(string name)
        {
            this.Name = name;
        }
        
        public override void duty(string duty)
        {
            Console.WriteLine($"{this.Name} duty is: {duty}");
        }
    }

    public class Midfielder: Footballer
    {
        public string Name { get; set; }

        public Midfielder(string name)
        {
            this.Name = name;
        }

        public override void duty(string duty)
        {
            Console.WriteLine($"{this.Name} duty is: {duty}");
        }
    }
}