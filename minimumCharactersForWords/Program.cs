using System;
using System.Collections.Generic;
using System.Linq;

namespace minimumCharactersForWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "this", "that", "did", "deed", "them!", "a" };
            Console.WriteLine($"The input is : {String.Join<string>(',',words)}"); 
            Console.WriteLine($"\nThe minimum characters for words are :\n{String.Join<string>(',', MinimumCharactersForWords(words))}");
        }

        #region Solution_with_Dictionary
        //public static string[] MinimumCharactersForWords(string[] words)
        //{
        //    Dictionary<char, int> charCountDict = new Dictionary<char, int>();
        //    List<string> allCharactersArray = new List<string>();
        //    foreach (var word in words)
        //    {
        //        var currentWordsCharacters = word.ToCharArray().GroupBy(a => a).Select(a => new { letter = a.Key, letterCount = a.Count() });
        //        foreach (var item in currentWordsCharacters)
        //        {
        //            var currentChar = item.letter;
        //            var currentCharCount = item.letterCount;
        //            if (charCountDict.ContainsKey(currentChar))
        //            {
        //                charCountDict[currentChar] = Math.Max(charCountDict[currentChar], currentCharCount);
        //            }
        //            else
        //            {
        //                charCountDict.Add(currentChar, currentCharCount);
        //            }
        //        }
        //    }
        //    foreach (var item in charCountDict)
        //    {
        //        for (int i = 0; i < item.Value; i++)
        //        {
        //            allCharactersArray.Add(item.Key.ToString());
        //        }
        //    }
        //    return allCharactersArray.ToArray();
        //}
        #endregion

        #region Solution_with_Pure_linq
        public static string[] MinimumCharactersForWords(string[] words)
        {
            List<string> allCharactersArray = new List<string>();
            foreach (var word in words)
            {
                var currentWordsCharacters = word.ToCharArray().GroupBy(a => a).Select(a => new { letter = a.Key, letterCount = a.Count() });
                foreach (var item in currentWordsCharacters)
                {
                    var currentChar = item.letter.ToString();
                    var currentCharCount = item.letterCount;
                    var differenceNumber = currentCharCount - allCharactersArray.Where(a => a == currentChar).Count();
                    if (differenceNumber > 0)
                    {
                        for (int i = 0; i < differenceNumber; i++)
                        {
                            allCharactersArray.Add(currentChar);
                        }
                    }
                }

            }
            return allCharactersArray.ToArray();
        }
        #endregion

    }
}
