using System;
using System.Collections.Generic;

namespace ValidIPAddresses2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1921680";
            Console.WriteLine($"The input is : {input}");
            Console.WriteLine($"Valid ips are \n");

            foreach (var item in ValidIPAddresses(input))
            {
                Console.WriteLine($"{item}");
            }
        }

        #region My_Solution
        // here it's better to use an string array
        // and also it's better to not user the no 4 loop
        public static List<string> ValidIPAddresses(string str)
        {
            var result = new List<string>();
            if (string.IsNullOrWhiteSpace(str))
                return result;
            if (str.Length < 4)
                return result;
            string firstPart = "";
            string secondPart = "";
            string thirdPart = "";
            string forthPart = "";
            // here it's better to use an string array
            // and also it's better to not user the no 4 loop
            for (int i = 1; i < 4; i++)
            {
                firstPart = str.Substring(0, i);
                if (!IsValid(firstPart))
                    continue;
                for (int j = 1; j < 4; j++)
                {
                    if (i + j > str.Length)
                        break;
                    secondPart = str.Substring(i, j);
                    if (!IsValid(secondPart))
                        continue;
                    for (int k = 1; k < 4; k++)
                    {
                        if (i + j + k > str.Length)
                            break;
                        thirdPart = str.Substring(i + j, k);
                        if (!IsValid(thirdPart))
                            continue;
                        for (int l = 1; l < 4; l++)
                        {
                            if (i + j + k + l > str.Length)
                                break;
                            forthPart = str.Substring(i + j + k, l);
                            if (!IsValid(forthPart))
                                continue;
                            if (firstPart + secondPart + thirdPart + forthPart == str)
                            {
                                result.Add($"{firstPart}.{secondPart}.{thirdPart}.{forthPart}");
                            }
                            else
                                continue;
                        }
                    }
                }
            }
            return result;
        }

        public static bool IsValid(string ipPart)
        {
            if (string.IsNullOrWhiteSpace(ipPart))
                return false;

            //var characters = ipPart.ToCharArray();
            //if (characters[0] == '0' && ipPart.Length > 1)
            //    return false;

            int intIpPart = int.Parse(ipPart);

            if (intIpPart > 255)
                return false;

            return intIpPart.ToString().Length == ipPart.Length;

            //return true;
        }
        #endregion

    }
}
