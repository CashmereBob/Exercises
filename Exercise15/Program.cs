using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";
            Dictionary<char, string> listOfLetters = new Dictionary<char, string>();

            foreach (char letter in input)
            {
                if (listOfLetters.ContainsKey(letter))
                {
                    listOfLetters[letter] += "*";
                }
                else
                {
                    listOfLetters[letter] = "*";
                }
            }

            foreach (KeyValuePair<char, string> letters in listOfLetters)
            {
                Console.WriteLine(letters.Key + " " + letters.Value);
            }

            Console.WriteLine();

            Dictionary<char, string> alfaLetters = new Dictionary<char, string>();

            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {
                    if (alfaLetters.ContainsKey(letter))
                    {
                        alfaLetters[letter] += "*";
                    }
                    else
                    {
                        alfaLetters[letter] = "*";
                    }
                }
            }

            foreach (KeyValuePair<char, string> letters in alfaLetters)
            {
                Console.WriteLine(letters.Key + " " + letters.Value);
            }

            Console.WriteLine();

            char? mostCommon = null;
            string numberOfRepetitions = string.Empty;

            foreach(KeyValuePair<char, string> letters in listOfLetters)
            {
                if (letters.Value.Count() > numberOfRepetitions.Count())
                {
                    mostCommon = letters.Key;
                    numberOfRepetitions = letters.Value;
                }
            }

            Console.WriteLine("Most common letter is \"{0}\" it appeared {1} times.", mostCommon, numberOfRepetitions.Count());
            Console.WriteLine();
            var words = input.Split(' ');
            Dictionary<string, string> wordCount = new Dictionary<string, string>();

            foreach (string word in words)
            {
               
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word] += "*";
                    }
                    else
                    {
                        wordCount[word] = "*";
                    }
                
            }

            foreach (KeyValuePair<string,string> word in wordCount)
            {
                Console.WriteLine(word.Key + " " + word.Value);
            }
                Console.ReadKey();
        }
    }
}
