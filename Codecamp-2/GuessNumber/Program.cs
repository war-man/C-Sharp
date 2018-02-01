using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess Number game");
            Console.WriteLine("Your mission is to find the correct number");
            Console.WriteLine("You can guess as many times as you like");
            Console.WriteLine("Let the game begins!!!!!");
            Console.WriteLine("--------------------------------------------------------");
            
            try
            {
                int input = Int32.Parse( Console.ReadLine() );
                Random rnd = new Random();
                int result = rnd.Next(-100,100);
                int countGuess = 1;
        
                while (input != result) {
                    countGuess++;
                    if (input > result) {
                        Console.WriteLine("Please choose a smaller number");
                        input = Int32.Parse( Console.ReadLine() );
                    } else {
                        Console.WriteLine("Please choose a bigger number");
                        input = Int32.Parse( Console.ReadLine() );
                    }
                }
                
                Console.WriteLine("Congratulations!!!");
                Console.WriteLine("You needed " + countGuess + " guess(es) to complete the game");          
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You must enter an integer number");
            }

        }
    }
}
