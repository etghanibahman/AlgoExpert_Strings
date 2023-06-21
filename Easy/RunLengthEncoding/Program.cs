using System;
using System.Text;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "AAAAAAAAAAAAABBCCCCDD"; //Expected output: 9A4A2B4C2D

            Console.WriteLine($"The string is : {str}");
            Console.WriteLine($"The endoded string is : {RunLengthEncoding(str)}");
            Console.ReadKey();
        }

        public static string RunLengthEncoding(string str)
        {
            StringBuilder result =  new StringBuilder();

            int encoderCounter = 1;
            char currentChar = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1] || encoderCounter == 9)
                {
                    result.Append($"{encoderCounter}{currentChar}");
                    encoderCounter = 1;
                    currentChar = str[i];
                }
                else
                {
                    encoderCounter += 1;
                }
            }
            result.Append($"{encoderCounter}{currentChar}");

            return result.ToString();
        }

        //public static string RunLengthEncoding(string str)
        //{
        //    string result = "";
        //    int encoderCounter = 1;
        //    char currentChar = str[0];
        //    for (int i = 1; i < str.Length; i++)
        //    {
        //        if (str[i] != str[i-1] || encoderCounter == 9)
        //        {
        //            result += $"{encoderCounter}{currentChar}";
        //            encoderCounter = 1;
        //            currentChar = str[i];
        //        }
        //        else
        //        {
        //            encoderCounter += 1;
        //        }
        //    }
        //    result += $"{encoderCounter}{currentChar}";

        //    return result;
        //}
    }
}
