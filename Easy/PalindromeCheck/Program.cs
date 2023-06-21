using System;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string testCase = "abcdcba";
            //testCase = "ab";  // false case
            Console.WriteLine($"Is this a palindrome? {IsPalindrome(testCase)}");
            Console.ReadKey();
        }

        //// O(n^2) time  |  O(n) space
        //public static bool IsPalindrome(string str)
        //{
        //    string reverseString = "";
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        reverseString += str[i];
        //    }
        //    return str == reverseString;
        //}

        //// O(n) time  |  O(n) space
        //public static bool IsPalindrome(string str)
        //{
        //    char[] reverseString = new char[str.Length];
        //    for (int i = 0; i < str.Length ; i++)
        //    {
        //        reverseString[i] = str[(str.Length - 1) - i];
        //    }
        //    return str == string.Concat(reverseString);
        //}

        //#region Recursive
        //// O(n) time  |  O(n) space
        //public static bool IsPalindrome(string str)
        //{
        //    return IsPalindromeRecursive(str,0);
        //}

        //public static bool IsPalindromeRecursive(string str,int i)
        //{
        //    int j = str.Length - 1 - i;

        //    return i >= j ? true : (str[i] == str[j] && IsPalindromeRecursive(str,i+1)) ;
        //}
        //#endregion

        #region WhileLoop
        // O(n) time  |  O(n) space
        public static bool IsPalindrome(string str)
        {
            int leftIndex = 0;
            int rightIndex = str.Length - 1;

            while (leftIndex < rightIndex)
            {
                if (str[leftIndex] != str[rightIndex])
                    return false;
                leftIndex += 1;
                rightIndex -= 1;
            }
            return true;
        }

        #endregion


        #region MySolution
        //public static bool IsPalindrome(string str)
        //{
        //    if (string.IsNullOrWhiteSpace(str))
        //    {
        //        return false;
        //    }
        //    else if (str.Length == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        char[] charArray = str.ToCharArray();
        //        for (int i = 0; i < charArray.Length / 2; i++)
        //        {
        //            if (charArray[i] != charArray[(charArray.Length - 1) - i])
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //}
        #endregion

    }
}
