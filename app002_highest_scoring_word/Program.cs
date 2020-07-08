using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Given a string of words, you need to find the highest scoring word.
 * Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.\
 * You need to return the highest scoring word as a string.
 * If two words score the same, return the word that appears earliest in the original string.
 * All letters will be lowercase and all inputs will be valid.
 */

namespace app002_highest_scoring_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "what time are we climbing up to the volcano";
            Console.WriteLine(Kata.High(s.ToLower()));
            Console.ReadKey();
        }
    }
}
public class Kata
{
    public static string High(string s)
    {
        string msxScoringWord = "";
        int maxScore = 0;
        int index = 1;
        Dictionary<char, int> words = new Dictionary<char, int>();
        for (int i = 97; i < 123; i++)
        {
            words.Add((char)i, index);
            index++;
        }
        int score = 0;
        string word = "";
        index = 0;
        do
        {
            if (char.IsWhiteSpace(s[index]) )
            {
                if (maxScore <= score)
                {
                    maxScore = score;
                    msxScoringWord = word;
                }
                score = 0;
                word = "";
            }
            else
            {
                word += s[index];
                score += words[s[index]];
            }
            index++;
        } while (index < s.Length);
        if (maxScore <= score) { msxScoringWord = word; }
        return msxScoringWord;
    }
}