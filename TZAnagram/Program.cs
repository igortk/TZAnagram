using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TZAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string choice = "";
            string word1 = "";
            string word2 = "";

            while (!isExit)
            {
                word1 = "";
                word2 = "";
                Console.WriteLine("1 - find out if two words are an anagram\n" +
                    "2 - get anagrammatic pairs\n" +
                    "3 - get numeric pairs\n" +
                    "another character - exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the first word \n");
                        word1 = Console.ReadLine();
                        Console.WriteLine("Enter the second word \n");
                        word2 = Console.ReadLine();
                        if (Anagram.IsAnagram(word1, word2))
                        {
                            Console.WriteLine("Is Anagram");
                        }
                        else
                        {
                            Console.WriteLine("Is`nt Anagram");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter the word \n");
                        word1 = Console.ReadLine();
                        string[] str = Anagram.GetAnagramsPairs(word1);
                        if (str != null)
                        {
                            if (str.Length > 0)
                            {
                                foreach (var item in str)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error in the entered information ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error in the entered information ");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter the word \n");
                        word1 = Console.ReadLine();
                        int[,] arrInt = Anagram.GetNumberAnagrams(word1);
                        if (arrInt != null)
                        {
                            if (arrInt.GetLength(0) > 0)
                            {
                                string strHelp = "";
                                for (int i = 0; i < arrInt.GetLength(0); i++)
                                {
                                    for (int j = 0; j < arrInt.GetLength(1); j++)
                                    {
                                        strHelp += arrInt[i, j];
                                    }
                                    Console.WriteLine(strHelp);
                                    strHelp = "";
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error in the entered information ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error in the entered information ");
                        }
                        break;
                    default:
                        isExit = !isExit;
                        break;
                }
            }
        }
    }
}
