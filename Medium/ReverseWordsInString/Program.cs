using System;
using System.Text;

namespace ReverseWordsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "AlgoExpert is the best!";

            Console.WriteLine($"The string is: {str}");
            Console.WriteLine($"The Reversed string is: { ReverseWordsInString(str)}");
        }

        public static string ReverseWordsInString(string str)
        {
            var builder = new StringBuilder();
            int currentPosition = 0;

            while (currentPosition < str.Length)
            {
                if (char.IsWhiteSpace(str[currentPosition]))
                {
                    builder.Insert(0, str[currentPosition]);
                    currentPosition++;
                    continue;
                }

                int wordStart = currentPosition;
                while (currentPosition < str.Length && !char.IsWhiteSpace(str[currentPosition]))
                {
                    currentPosition++;
                }

                int wordLength = currentPosition - wordStart;
                builder.Insert(0, str.Substring(wordStart, wordLength));
            }

            return builder.ToString();
        }
    }
}
