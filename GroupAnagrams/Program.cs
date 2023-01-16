using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "yo", "act", "flop", "tac", "foo", "cat", "oy", "olfp" };
            words = new List<string>() { "boo", "bob"};
            Console.WriteLine($"Array :{ String.Join(',', words)} ");

            foreach (var item in groupAnagrams(words))
            {
                Console.WriteLine($"Anagrams are :{ String.Join(',', item)} ");
            }
        }


        #region usind sorting 
        public static List<List<string>> groupAnagrams(List<string> words)
        {
            var memo = new Dictionary<string, List<string>>();

            foreach (var elm in words)
            {
                var sortedString = String.Concat(elm.OrderBy(a=>a));

                if (memo.ContainsKey(sortedString))
                {
                    memo[sortedString].Add(elm);
                }
                else
                {
                    memo[sortedString] = new List<string> { elm};
                }
            }

            return memo.Values.ToList();
        }

        #endregion

        #region using dictionary and Hash value
        //public static List<List<string>> groupAnagrams(List<string> words)
        //{
        //    Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();

        //    for (int i = 0; i < words.Count; i++)
        //    {
        //        int hash = CalculateHash(words[i]);

        //        if (map.ContainsKey(hash))
        //        {
        //            map[hash].Add(words[i]);
        //        }
        //        else
        //        {
        //            map.Add(hash, new List<string>() { words[i] });
        //        }
        //    }

        //    return map.Select(a => a.Value).ToList();
        //}

        //private static int CalculateHash(string word)
        //{
        //    char[] chars = word.ToCharArray();
        //    int aggregate = 0;
        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        aggregate += (int)Math.Pow((int)chars[i], 2);
        //    }
        //    return aggregate;
        //}
        #endregion


        #region MySolution
        //public static List<List<string>> groupAnagrams(List<string> words)
        //{
        //    List<List<string>> allAnagrams = new List<List<string>>();
        //    Dictionary<string, bool> wordsDict = new Dictionary<string, bool>();
        //    for (int i = 0; i < words.Count; i++)
        //    {
        //        wordsDict.Add(words[i], false);
        //    }

        //    for (int i = 0; i < words.Count; i++)
        //    {
        //        if (wordsDict[words[i]] == true)
        //            continue;
        //        List<string> currentWordAnagrams = new List<string>();
        //        wordsDict[words[i]] = true;
        //        currentWordAnagrams.Add(words[i]);
        //        for (int j = i + 1; j < words.Count; j++)
        //        {
        //            if (wordsDict[words[j]] == true)
        //                continue;
        //            if (words[i].Length == words[j].Length)
        //            {
        //                bool anagramCheck = true;
        //                foreach (char character in words[i])
        //                {
        //                    if (!words[j].Contains(character) || words[i].Count(a => a == character) != words[j].Count(a => a == character))
        //                    {
        //                        anagramCheck = false;
        //                    }
        //                }

        //                if (anagramCheck)
        //                {
        //                    wordsDict[words[j]] = true;
        //                    currentWordAnagrams.Add(words[j]);
        //                }
        //            }
        //        }
        //        allAnagrams.Add(currentWordAnagrams);
        //    }

        //    return allAnagrams;
        //}
        #endregion

    }
}
