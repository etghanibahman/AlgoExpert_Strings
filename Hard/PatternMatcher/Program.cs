using System;

namespace PatternMatcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern= "xxyxxy";
            string str = "gogopowerrangergogopowerranger";
            Console.WriteLine($"Pattern: {pattern} , str: {str}");
            Console.WriteLine($"The result is : {String.Join(',',PatternMatcher(pattern, str))}");
        }

        public static string[] PatternMatcher(string pattern, string str)
        {
            // Write your code here.
            return new string[] { };
        }
    }
}
