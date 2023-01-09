using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abaxyzzyxf";
            //str = "a";
            //str = "it's highnoon";
            str = "non";
            str = "noon";

            Console.WriteLine($"The longest Palindrome is : { LongestPalindromicSubstring(str) }");
        }

        #region AlgoExpert_Solution
        public static string LongestPalindromicSubstring(string str)
        {
            string longestPalindrome = "";
            for (int i = 0; i < str.Length; i++)
            {
                var palEven = ExpandFromMiddle(str, i, i + 1);
                var palOdd = ExpandFromMiddle(str, i, i);

                if (palOdd.Length > longestPalindrome.Length)
                {
                    longestPalindrome = palOdd;
                }
                if (palEven.Length > longestPalindrome.Length)
                {
                    longestPalindrome = palEven;
                }
            }
            return longestPalindrome;
        }


        public static string ExpandFromMiddle(string str, int i, int j)
        {
            while (i >= 0 && j < str.Length && str[i] == str[j])
            {
                i--;
                j++;
            }
            var currentLength = j - i - 1;
            var startIndex = i + 1;
            return str.Substring(startIndex, currentLength);
        }
        #endregion


        #region My_Solution
        //public static string LongestPalindromicSubstring(string str)
        //{
        //    Dictionary<string, int> dicPalindromes = new Dictionary<string, int>();
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        for (int j = i; j <= str.Length; j++)
        //        {
        //            string current = str.Substring(i, j - i);
        //            if (IsPalindrome(current))
        //            {
        //                if (!dicPalindromes.ContainsKey(current))
        //                    dicPalindromes.Add(current, current.Length);
        //            }
        //        }
        //    }
        //    int maxLentgh = dicPalindromes?.Max(a => a.Value) ?? 0;
        //    return dicPalindromes.Where(a => a.Value == maxLentgh).FirstOrDefault().Key;
        //}

        //public static bool IsPalindrome(string str)
        //{
        //    int leftIndex = 0;
        //    int rightIndex = str.Length - 1;

        //    while (leftIndex < rightIndex)
        //    {
        //        if (str[leftIndex] != str[rightIndex])
        //            return false;
        //        leftIndex += 1;
        //        rightIndex -= 1;
        //    }
        //    return true;
        //}
        #endregion

    }
}
