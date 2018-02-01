using System;
using System.Collections.Generic;

namespace CheckSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input one number at a time");
            Console.WriteLine("You must enter at least 2 numbers");
            Console.WriteLine("Type 'ok' to finish");

            try
            {
                List<int> numberList = new List<int>();
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input.ToLower() == "ok")
                    {
                        break;
                    }
                    numberList.Add(Convert.ToInt32(input));

                }

                List<int> check = new List<int>();
                if (numberList[0] < numberList[1]) {
                    for (int i = 0; i < numberList.Count-1; i++)
                    {
                        if (numberList[i] + 1 == numberList[i+1])
                        {
                            check.Add(0);   
                        } else {
                            check.Add(1);
                        }
                    } 
                } else {
                    for (int i = 0; i < numberList.Count-1; i++)
                    {
                        if (numberList[i] - 1 == numberList[i+1])
                        {
                            check.Add(0);   
                        } else {
                            check.Add(1);
                        }
                    } 
                }

                bool exist = check.Exists(el => el == 1);

                if (exist)
                {
                    Console.WriteLine("This is not a consecutive sequence");
                } else {
                    Console.WriteLine("This is a consecutive sequence");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter at least 2 integer numbers");
            }
            catch (ArgumentOutOfRangeException ar)
            {
                Console.WriteLine(ar.Message);
                Console.WriteLine("Please enter at least 2 integer numbers");
            }


        }
    }
}
