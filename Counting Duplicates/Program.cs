using System;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Duplicates
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //"abcde" -> 0 # no characters repeats more than once
            //"aabbcde" -> 2 # 'a' and 'b'
            //"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (bandB)
            //"indivisibility" -> 1 # 'i' occurs six times
            //"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
            //"aA11" -> 2 # 'a' and '1'
            //"ABBA" -> 2 # 'A' and 'B' each occur twice
            string a = "Aabbcde";
            CountingDuplicates(a);
        }

        private static void CountingDuplicates(string s)
        {
            var resultDictionary = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (resultDictionary.ContainsKey(c))
                    resultDictionary[c] += 1;
                else
                    resultDictionary.Add(c, 1);
            }
            PrintResultInConsole(resultDictionary);
        }

        private static void PrintResultInConsole(Dictionary<char, int> resultDictionary)
        {
            var total = "total";
            Console.Write(total + " # ");

            if (resultDictionary.Values.Max() < 2)
            {
                Console.Write("no characters repeats more than once");
            }

            foreach (var result in resultDictionary)
            {
                if (result.Value > 1)
                {
                    Console.Write("'" + result.Key + "' occurs " + result.Value + " times. ");
                }
            }
        }
    }
}
