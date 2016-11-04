using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnagramCodeKata
{
    class Program
    {
        /* 
         * Given a file containing one word per line, print out all the combinations of words that are anagrams; 
         * each line in the output contains all the words from the input that are anagrams of each other.
         */

        static void Main(string[] args)
        {
            var start = DateTime.Now;
            var words = File.ReadAllLines("wordlist.txt").ToList();

            var anagramsDictionary = new Dictionary<string, string>();

            foreach (var currentWord in words)
            {
                var anagramString = currentWord;
                var sortedAnagramString = anagramString.SortedLetters();

                if (anagramsDictionary.ContainsKey(sortedAnagramString))
                {
                    anagramsDictionary[sortedAnagramString] = anagramsDictionary[sortedAnagramString] + " " + anagramString;
                }
                else
                {
                    anagramsDictionary.Add(sortedAnagramString, anagramString);
                }
            }
            
            foreach (var keyValuePair in anagramsDictionary.Where(x => x.Value.Contains(" ")))
            {
                Console.WriteLine(keyValuePair.Value);
            }

            var stop = DateTime.Now;
            Console.WriteLine($"{start - stop}");

            Console.ReadKey();
        }
    }
}
