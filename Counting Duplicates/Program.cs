using System;

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
            string a = "abcde";
            Console.WriteLine(CountingDuplicates(a));
        }

        private static string CountingDuplicates(string s)
        {
            string result = string.Empty;
            foreach (var c in result)
            {
                
            }
            return result;
        }
    }
}
