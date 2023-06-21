using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerateDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            string characters = "Bste!hetsi ogEAxpelrt x ";
            string document = "AlgoExpert is the Best!";

            characters = "aheaolabbhb";
            document = "hello";

            Console.WriteLine($"Characters : {characters}");
            Console.WriteLine($"Document : {document}");
            Console.WriteLine($"is the document generatable? {GenerateDocument(characters,document)}");
        }

        public static bool GenerateDocument(string characters, string document)
        {
            var charactersCharDic = characters.ToCharArray().GroupBy(a => a).Select(n => new
            {
                charName = n.Key,
                charCount = n.Count()
            }).ToDictionary(t => t.charName, t => t.charCount);

            var documentCharDic = document.ToCharArray().GroupBy(a => a).Select(n => new
            {
                charName = n.Key,
                charCount = n.Count()
            }).ToDictionary(t => t.charName, t => t.charCount);

            foreach (var item in documentCharDic)
            {
                char currentChar = item.Key;
                int currentCharCount = item.Value;
                if (charactersCharDic.SingleOrDefault(a => a.Key == currentChar).Value < currentCharCount)
                {
                    return false;
                }
            }

            return true;
        }

        //public static bool GenerateDocument(string characters, string document)
        //{
        //    Dictionary<char, int> dicCharacters = new Dictionary<char, int>();

        //    foreach (var item in characters)
        //    {
        //        if (!dicCharacters.ContainsKey(item))
        //            dicCharacters.Add(item, 0);
        //        dicCharacters[item]++;
        //    }

        //    foreach (var item in document)
        //    {
        //        if (!dicCharacters.ContainsKey(item) || dicCharacters[item] == 0)
        //            return false;
        //        dicCharacters[item]--;
        //    }

        //    return true;
        //}
    }
}
