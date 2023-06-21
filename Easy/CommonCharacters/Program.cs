using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[] { "abc", "bcd", "cbad" }; // {"b","c"}
            Console.WriteLine($"Common characters are :{String.Join(',', CommonCharacters(strings))}");
        }

        //O(n*m) time, O(m) space
        public static string[] CommonCharacters(string[] strings)
        {
            List<string> result = new List<string>();

            var min = strings.Min(a => a.Length);
            var toBeginWith = strings.FirstOrDefault(a => a.Length == min);
            bool check = true;
            foreach (char character in toBeginWith)
            {
                check = true;
                foreach (var item in strings)
                {
                    if (!item.Contains(character)) {
                        check = false;
                        break;
                    }
                }
                if (check)
                    result.Add(character.ToString());
            }

            return result.Distinct().ToArray();
        }
    }
}
