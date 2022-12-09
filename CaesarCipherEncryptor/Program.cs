using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarCipherEncryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            //zab
            string sample = "xyz";
            int key = 2;

            ////fgh
            //sample = "abc";
            //key = 57;

            Console.WriteLine($"The result is : {CaesarCypherEncryptor(sample, key)}");
            Console.ReadKey();
        }


        public static string CaesarCypherEncryptor(string str, int key)
        {
            var numberOfChars = 26;
            var resultBuilder = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                var encodedCharacter = (((str[i] - 97) + key) % numberOfChars) + 97;
                resultBuilder.Append((char)encodedCharacter);
            }
            return resultBuilder.ToString();
        }

        #region MySolution
        //public static string CaesarCypherEncryptor(string str, int key)
        //{
        //    key = key % 26;
        //Dictionary<char, int> dictionary = new Dictionary<char, int>();
        //    for (char c = 'a'; c <= 'z'; c++)
        //    {
        //        int keyChar = c - 'a' + 1;
        //dictionary.Add(c, keyChar);
        //    }

        //    string cypherString = "";
        //    foreach (char character in str)
        //    {
        //        int index;
        //        dictionary.TryGetValue(character, out index);

        //        if (index + key > 26)
        //            index = (index + key) - 26;
        //        else
        //            index = index + key;

        //        char encryptedChar = dictionary.Where(a => a.Value == index).Select(a => a.Key).FirstOrDefault();
        //        cypherString += encryptedChar;
        //    }

        //    return cypherString;
        //}
        #endregion


    }
}
