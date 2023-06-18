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
        
        public static bool OneEdit(string stringOne, string stringTwo)
        {
            // Write your code here.
            return false;
        }
    }
}
