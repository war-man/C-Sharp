using System;

namespace Class_Exercise_2
{
    abstract class Footballer
    {
        public string Name { get; set; } = "Michael";
        public int YearOfBirth { get; set; } = 1990;
        public string PlaceOfBirth { get; set; } = "London";

        protected Footballer() {}

        protected Footballer(string name, int year) 
        {
            this.Name = name;
            this.YearOfBirth = year;
        }

        protected Footballer(string name, int year, string place) 
        {
            this.Name = name;
            this.YearOfBirth = year;
            this.PlaceOfBirth = place;
        }
        
    }

    class Defender: Footballer
    {
        public string Position { get; set; }
        public string Club { get; set; }
        public int Matches { get; set; }

        public Defender(string position, string club, int matches):base()
        {
            this.Position = position;
            this.Club = club;
            this.Matches = matches;
        } 

        public Defender(string name, int yearOfBirth, 
                        string position, string club, int matches):base(name, yearOfBirth)
        {
            this.Position = position;
            this.Club = club;
            this.Matches = matches;
        }        

        public Defender(string name, int yearOfBirth, string placeOfBirth, 
                        string position, string club, int matches):base(name, yearOfBirth, placeOfBirth)
        {
            this.Position = position;
            this.Club = club;
            this.Matches = matches;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Defender nesta = new Defender("Nesta", 1990, "Milan", "Centreback", "AC Milan", 500);
            Console.WriteLine(nesta.Name);
            Console.WriteLine(nesta.YearOfBirth);
            Console.WriteLine(nesta.PlaceOfBirth);
            Console.WriteLine(nesta.Position);
            Console.WriteLine(nesta.Club);
            Console.WriteLine(nesta.Matches);

            Console.WriteLine("----------------------------------------------------------------");
            
            Defender vidic = new Defender("Vidic", 1992, "Centreback", "Man Utd", 986);
            Console.WriteLine(vidic.Name);
            Console.WriteLine(vidic.YearOfBirth);
            Console.WriteLine(vidic.PlaceOfBirth);
            Console.WriteLine(vidic.Position);
            Console.WriteLine(vidic.Club);
            Console.WriteLine(vidic.Matches);

            Console.WriteLine("----------------------------------------------------------------");
            
            Defender gary = new Defender("Fullback", "Man Utd", 589);
            Console.WriteLine(gary.Name);
            Console.WriteLine(gary.YearOfBirth);
            Console.WriteLine(gary.PlaceOfBirth);
            Console.WriteLine(gary.Position);
            Console.WriteLine(gary.Club);
            Console.WriteLine(gary.Matches);
        }
    }
}
