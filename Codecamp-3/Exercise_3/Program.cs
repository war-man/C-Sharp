using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listWord = new List<string>(){"he","she","it","we","you","they"};
            var result = GetWord(listWord);
            if (result.Count == 0) {
                Console.WriteLine("null");
            } else {
                var lastWord = result[result.Count - 1];
                Console.WriteLine($"The last word is {lastWord}");
            }
        }

        public static List<string> GetWord(IEnumerable<string> words)
        {
            var result = words.Where(item => item.IndexOf('e') != -1).OrderBy(item => item).ToList();
            return result;
        }
    }
}
