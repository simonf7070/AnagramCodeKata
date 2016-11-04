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
            var words = File.ReadAllLines("wordlist.txt").ToList();

            var anagrams = new List<string>();
            foreach (var currentWord in words)
            {
                string anagramString = currentWord;

                foreach (var wordToTest in words)
                {
                    if (currentWord != wordToTest && currentWord.IsAnagramOf(wordToTest))
                        anagramString += " " + wordToTest;
                }

                if (anagramString != currentWord)
                    anagrams.Add(anagramString);
            }

            anagrams.ForEach(Console.WriteLine);
        }
    }
}
