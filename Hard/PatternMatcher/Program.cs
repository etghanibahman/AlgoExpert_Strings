using System;
using System.Linq;
using System.Text;

namespace PatternMatcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TestCase__1
            //string pattern = "xxyxxy";
            //string str = "gogopowerrangergogopowerranger";
            #endregion

            #region TestCase__4
            string pattern = "xxxx";
            string str = "testtesttesttest";
            #endregion

            Console.WriteLine($"Pattern: {pattern} , str: {str}");
            Console.WriteLine($"The result is : {String.Join(',', PatternMatcher(pattern, str))}");
        }

        public static string[] PatternMatcher(string pattern, string str)
        {
            var indexOfY = GetIndexOfY(pattern).indexOfY;
            bool patternChanged = pattern[0] != GetIndexOfY(pattern).correctedPattern[0];
            pattern = GetIndexOfY(pattern).correctedPattern;
            var patternDicCount = pattern.ToCharArray().GroupBy(a => a.ToString()).ToDictionary(a => a.Key, a => a.Count());

            var xCount = patternDicCount.FirstOrDefault(x => x.Key == "x").Value;
            var yCount = patternDicCount.FirstOrDefault(x => x.Key == "y").Value;
            int lengthX = 1;
            while ((str.Length - (lengthX * xCount)) >= 0)
            {
                if (yCount == 0)
                {
                    var validationResult = PatternIsCorrectOnlyX(str, pattern, lengthX);
                    if (validationResult.result)
                    {
                        if (patternChanged)
                        {
                            return new string[] { validationResult.y, validationResult.x };
                        }
                        return new string[] { validationResult.x, validationResult.y };
                    }
                }
                else
                {
                    var lenY = (str.Length - (lengthX * xCount)) / yCount;
                    var validationResult = PatternIsCorrect(str, pattern, lengthX, lenY, indexOfY);
                    if (validationResult.result)
                    {
                        if (patternChanged)
                        {
                            return new string[] { validationResult.y, validationResult.x };
                        }
                        return new string[] { validationResult.x, validationResult.y };
                    }
                }


                lengthX++;
            }

            return new string[] { };
        }

        public static (string x, string y, bool result) PatternIsCorrectOnlyX(string str, string pattern, int lengthX)
        {
            var x = str.Substring(0, lengthX);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in pattern)
            {
                    stringBuilder.Append(x);

            }

            return (x, "", stringBuilder.ToString() == str);
        }

        public static (string x, string y, bool result) PatternIsCorrect(string str,string pattern,int lengthX,int lengthY,int indexOfY)
        {
            var x = str.Substring(0,lengthX);
            var y = str.Substring(lengthX* indexOfY,lengthY);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in pattern)
            {
                if (item.ToString()=="x")
                {
                    stringBuilder.Append(x);
                }
                else
                {
                    stringBuilder.Append(y);
                }
            }

            return (x, y, stringBuilder.ToString() == str);
        }

        public static (string correctedPattern, int indexOfY) GetIndexOfY(string pattern)
        {
            if (pattern[0].ToString() == "y")
            {
                pattern = pattern.Replace("x", "t");
                pattern = pattern.Replace("y", "x");
                pattern = pattern.Replace("t", "y");
            }
              
            return (pattern, pattern.IndexOf('y'));
        }
    }
}
