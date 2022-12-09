using System;
using System.Linq;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdcaf";
            //str = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
            Console.WriteLine($"The string is {str}");
            Console.WriteLine($"The index of first non repating character is : { FirstNonRepeatingCharacter(str)} ");
        }


        public static int FirstNonRepeatingCharacter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                string remainedPart = str.Remove(i,1);
                if (remainedPart.IndexOf(str[i]) == -1)
                {
                    return i;
                }
            }
            return -1;

        }

        //public static int FirstNonRepeatingCharacter(string str)
        //{
        //    char? res = str.ToCharArray().GroupBy(a => a).Select(a => new { character = a.Key, charCount = a.Count() })
        //        .Where(a => a.charCount == 1).FirstOrDefault()?.character;
        //    if (res == null)
        //        return -1;

        //    return str.IndexOf((char)res);
        //}
    }
}
