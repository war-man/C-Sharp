using System;
using System.Collections.Generic;
using System.IO;

public static class Hyphen {
    public static char[] hyphen(char[] array) {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = '-';
        }
        return array;
    }
}

public static class FindCharacter {
    public static List<int> findCharacter(string result, char guessChar) {
        List<int> index = new List<int>();
        char[] array = result.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == guessChar)
            {
                index.Add(i);
            }
        }
        return index;
    }
}

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman Game!");
            Console.WriteLine("Your mission is to find the secret word");
            Console.WriteLine("You can guess infinitely");

            string pathToFileWord = args[0];
            string secretWord;
            List<string> listWord = new List<string>();

            StreamReader sr = new StreamReader(pathToFileWord);
            secretWord = sr.ReadLine();
            while (secretWord != null)
            {
                listWord.Add(secretWord);
                secretWord = sr.ReadLine();
            }

            Random r = new Random();

            string result = listWord[r.Next(0, listWord.Count)];
            char[] guessArray = new char[result.Length];
            guessArray = Hyphen.hyphen(guessArray);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Let the game begins!!!");
            Console.WriteLine("This word has " + result.Length + " characters");

            string guessString = String.Join("", guessArray);
            Console.WriteLine(guessString);
            
            Console.WriteLine("Please make your first guess");
            try
            {
                char guess = Convert.ToChar(Console.ReadLine());

                List<int> find;
                find = FindCharacter.findCharacter(result, guess);

                while (true)
                {
                    if (find.Count == 0) {
                        Console.WriteLine("No character " + "'" + guess + "'" + " in the word. Please guess again");
                        Console.WriteLine(String.Join("", guessArray));
                        guess = Convert.ToChar(Console.ReadLine());
                        find = FindCharacter.findCharacter(result, guess);
                    } else {
                        foreach (var item in find) {
                            guessArray[item] = guess;
                        }

                        if (String.Join("", guessArray) == result)
                        {
                            Console.WriteLine("CONGRATULATIONS!!! YOU WIN THE GAME");
                            Console.WriteLine("The secret word is: " + result);
                            break;
                        }

                        Console.WriteLine("Oh yeah!!! One step closer to glory");
                        Console.WriteLine(String.Join("", guessArray));
                        guess = Convert.ToChar(Console.ReadLine());
                        find = FindCharacter.findCharacter(result, guess);
                    }   
                } 
            }
            catch (FormatException f)
            {
            
                Console.WriteLine(f.Message);
            }
            
        }
    }
}
