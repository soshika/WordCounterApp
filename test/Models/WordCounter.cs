using System;
namespace test.Models
{
    public class WordCounter
    {
        public string words { get; set; }

        public static int WordsCounter(string words)
        {
            int ans = words.Split(' ').Length;
            return ans;
        }
    }
}
