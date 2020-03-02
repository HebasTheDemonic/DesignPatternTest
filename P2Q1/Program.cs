using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Q1
{
    class Program
    {
        /// <summary>
        /// Checks how many times each letter combination appears in a string array.
        /// </summary>
        static void Main(string[] args)
        {
            string[] wordArray = { "java", "jjava", "vaj", "aavj", "j", "vjaa", "dan", "and", "ddan" };
            Dictionary<string, int> WordDictionary = new Dictionary<string, int>();

            // Sort to given string array into a dictionary. every key is a sorted string and the value is number of appearences.

            for(int wordIndex = 0; wordIndex < wordArray.Length; wordIndex++)
            {
                string word = StringSorter(wordArray[wordIndex]);
                if(WordDictionary.TryGetValue(word,out int value))
                {
                    value++;
                    WordDictionary.Remove(word);
                    WordDictionary.Add(word, value);
                }
                else
                {
                    WordDictionary.Add(word, 1);
                }
            }

            List<string> keyList = WordDictionary.Keys.ToList();

            // Print the results

            for(int listIndex = 0; listIndex < keyList.Count; listIndex++)
            {
                WordDictionary.TryGetValue(keyList[listIndex], out int value);
                Console.WriteLine($"The letter combination {keyList[listIndex]} appears {value.ToString()} times.");
            }
        }

        /// <summary>
        /// Recieves an unsorted string of letters and sorts it by alphabetical order.
        /// </summary>
        /// <param name="input">
        /// An alpabetically unsorted string
        /// </param>
        /// <returns string>
        /// Returns an alpabetically sorted string
        /// </returns>
        static string StringSorter(string input)
        {
            char[] characters = input.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
