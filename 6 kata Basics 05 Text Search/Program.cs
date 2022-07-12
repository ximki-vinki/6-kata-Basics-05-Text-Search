using System;
using System.Collections.Generic;

namespace _6_kata_Basics_05_Text_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Kata
    {
        public List<int> searchText(string text, string pattern, bool behind)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < text.Length - pattern.Length + 1; i++)
            {
                int constI = i;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (text[i] != pattern[j])
                    {
                        i = constI;
                        break;
                    }
                    i++;
                }
                if (i - constI == pattern.Length && pattern.Length != 0) answer.Add(constI);
                if (!behind) i = constI;
            }
            return answer;
        }
    }

}
