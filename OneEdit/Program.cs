using System;

namespace OneEdit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "hello";
            string stringTwo = "hollo";
            Console.WriteLine($"is one edit enough for <{stringOne}> and <{stringTwo}>? {OneEdit(stringOne,stringTwo)}");
        }

        #region Comparing_Index_Of_Characters___O(n)_time__|__O(1)_space___n=Lentgh of shorter string
        public static bool OneEdit(string stringOne, string stringTwo)
        {
            var diffLength = stringOne.Length - stringTwo.Length;
            if (Math.Abs(diffLength) > 1)
            {
                return false;
            }
            int firstIndex = 0;
            int secondIndex = 0;
            bool madeEdit = false;
            while (firstIndex < stringOne.Length && secondIndex < stringTwo.Length)
            {
                if (stringOne[firstIndex] != stringTwo[secondIndex])
                {
                    if (madeEdit)
                        return false;
                    else
                        madeEdit = true;
                    if (diffLength > 0)
                    {
                        firstIndex++;
                    }
                    else if (diffLength < 0)
                    {
                        secondIndex++;
                    }
                    else
                    {
                        firstIndex++;
                        secondIndex++;
                    }
                }
                else
                {
                    firstIndex++;
                    secondIndex++;
                }
            }
            return true;
        }
        #endregion

        #region Comparing_rest_of_strings___O(n + m)_time__|__O(n + m)_space____n=SizeStringOne_m=SizeStringTwo
        //public static bool OneEdit(string stringOne, string stringTwo)
        //{
        //    var diffLength = stringOne.Length - stringTwo.Length;
        //    if (Math.Abs(diffLength) > 1)
        //    {
        //        return false;
        //    }
        //    for (int i = 0; i < Math.Min(stringOne.Length, stringTwo.Length); i++)
        //    {
        //        if (stringOne[i] != stringTwo[i])
        //        {
        //            string remainedPart1;
        //            string remainedPart2;
        //            if (diffLength > 0)
        //            {
        //                remainedPart1 = stringOne.Substring(i + 1) ?? string.Empty;
        //                remainedPart2 = stringTwo.Substring(i) ?? string.Empty;
        //                return remainedPart1 == remainedPart2;
        //            }
        //            else if (diffLength < 0)
        //            {
        //                remainedPart1 = stringOne.Substring(i) ?? string.Empty;
        //                remainedPart2 = stringTwo.Substring(i + 1) ?? string.Empty;
        //                return remainedPart1 == remainedPart2;
        //            }
        //            else
        //            {
        //                remainedPart1 = stringOne.Substring(i + 1) ?? string.Empty;
        //                remainedPart2 = stringTwo.Substring(i + 1) ?? string.Empty;
        //                return remainedPart1 == remainedPart2;
        //            }
        //        }
        //    }
        //    return true;
        //}
        #endregion

    }
}
