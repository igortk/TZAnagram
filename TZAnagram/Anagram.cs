using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TZAnagram
{
    public static class Anagram
    {
        public static bool IsAnagram(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                Console.WriteLine("Some input parameter is null ");
                return false;
            }

            if (!Regex.IsMatch(str1, ValidationException.PatternRegisterDownCheck) ||
                    !Regex.IsMatch(str2, ValidationException.PatternRegisterDownCheck) ||
                    (str1.Length < 3 || str1.Length > 100) || (str2.Length < 3 || str2.Length > 100))
            {
                Console.WriteLine("Invalid string format entered");
                return false;
            }

            str1 = str1.Trim();
            str2 = str2.Trim();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Invalid string format entered");
                return false;
            }

            List<char> arrStr1 = new List<char>();
            List<char> arrStr2 = new List<char>();

            for (int i = 0; i < str1.Length; i++)
            {
                arrStr1.Add(str1[i]);
                arrStr2.Add(str2[i]);
            }

            arrStr1.Sort();
            arrStr2.Sort();

            for (int i = 0; i < arrStr1.Count; i++)
            {
                if (arrStr1[i] != arrStr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int[,] GetNumberAnagrams(string str)
        {
            if (str == null)
            {
                Console.WriteLine("Some input parameter is null");
                return null;
            }

            if (!Regex.IsMatch(str, ValidationException.PatternRegisterDownCheck) || (str.Length < 3 || str.Length > 100))
            {
                Console.WriteLine("Invalid string format entered");
                return null;
            }

            var per = new ClassPermutation(str);
            var list = per.GetPermutationsList();

            int height = list.Count;
            int width = str.Length;

            int[,] numberPairs = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    string temp = list[i];
                    for (int k = 0; k < str.Length; k++)
                    {
                        if (str[k].ToString() == temp[j].ToString())
                        {
                            numberPairs[i, j] = k;
                        }
                    }
                }
            }

            return numberPairs;
        }

        public static string[] GetAnagramsPairs(string str)
        {
            if (str == null)
            {
                Console.WriteLine("Some input parameter is null");
                return null;
            }

            if (!Regex.IsMatch(str, ValidationException.PatternRegisterDownCheck) || (str.Length < 3 || str.Length > 100))
            {
                Console.WriteLine("Invalid string format entered");
                return null;
            }

            var list = GetNumberAnagrams(str);

            List<string> anagrammaticPairs = new List<string>();

            for (int i = 0; i < list.GetLength(0); i++)
            {
                anagrammaticPairs.Add("");
                for (int j = 0; j < list.GetLength(1); j++)
                {
                    anagrammaticPairs[i] += str[list[i, j]];
                }
            }

            return RemovingDuplicateElements(ref anagrammaticPairs);
        }

        private static string[] RemovingDuplicateElements(ref List<string> arrayStr)
        {
            int length = arrayStr.Count;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i==j)
                    {
                        continue;
                    }
                    else
                    {
                        if (arrayStr[i] == arrayStr[j])
                        {
                            arrayStr.RemoveAt(j);
                            length--;
                            j--;
                        }
                    }
                }
            }

            string[] arrStr = new string[length];

            for (int i = 0; i < length; i++)
            {
                arrStr[i] = arrayStr[i];
            }

            return arrStr;
        }
    }
}
