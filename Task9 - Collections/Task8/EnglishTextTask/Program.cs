using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTextTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text in English");
            string text = Console.ReadLine();
            IEnumerable<string> words = GetAllWords(text);
            Dictionary<string, int> wordsFrequency = GetFrequencyPairs(GetNonDuplicate(words), words);
            foreach (KeyValuePair<string, int> el in wordsFrequency)
            {
                Console.WriteLine(el.Key + " " + el.Value);
            }
            Console.ReadLine();
        }

        static IEnumerable<string> GetAllWords(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n' };
            string[] allWords = text.Split(delimiterChars);
            foreach (string word in allWords)
            {
                word.ToLower();
            }
            return allWords;
        }

        private static IEnumerable<string> GetNonDuplicate(IEnumerable<string> allWords)
        {
            return allWords.Distinct();
        }

        static int GetFrequency(String word, IEnumerable<string> words)
        {
            int frequency = 0;
            foreach (string el in words)
            {
                if (word == el)
                {
                    frequency++;
                }
            }
            return frequency;
        }

        static Dictionary<string,int> GetFrequencyPairs(IEnumerable<string> words, IEnumerable<string> allWords)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string el in words)
            {
                dictionary.Add(el, GetFrequency(el, allWords));
            }
            return dictionary;
        }

    }
}
