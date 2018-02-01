using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToInput = args[0];
            string pathToOutput = args[1];
            string line;
            List<string> list = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(pathToInput);
                line = sr.ReadLine();
                while (line != null) {
                    list.Add(line);
                    line = sr.ReadLine();
                }
                
                sr.Close();

                StreamWriter sw = new StreamWriter(pathToOutput);
                Regex regex = new Regex(@"[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*");
                
                //int m = 0;
                foreach(var item in list) {
                    Match match = regex.Match(item);
                    if (match.Success) {
                        string[] result = regex.Split(item);
                        Console.WriteLine(result[0] + "- " + match.Value);
                        sw.WriteLine(result[0] + "- " + match.Value);
                        //Console.WriteLine(match.Value);
                    }
                }

                sw.Close();
            }
            catch (Exception ex)
            {
            
                Console.WriteLine(ex.Message);
            }
        }
    }
}
