using System;
using System.Collections.Generic;
using System.Text;

namespace TZAnagram
{
    public class ClassPermutation
    {
        private List<string> _permutationsList;
        private String _str;

        public ClassPermutation()
        {
            _str = "";
        }

        public ClassPermutation(String str)
        {
            _str = str;
        }

        private void AddToList(char[] a, bool repeat = true)
        {
            StringBuilder help = new StringBuilder("");
            for (int i = 0; i < a.Length; i++)
            {
                help.Append(a[i]);
            }
            if (repeat || !_permutationsList.Contains(help.ToString()))
            {
                _permutationsList.Add(help.ToString());
            }

        }
        private void RecPermutation(char[] arrLetter, int n, bool repeat = true)
        {
            for (int i = 0; i < n; i++)
            {
                char temp = arrLetter[n - 1];
                for (int j = n - 1; j > 0; j--)
                {
                    arrLetter[j] = arrLetter[j - 1];
                }
                arrLetter[0] = temp;
                if (i < n - 1)
                {
                    AddToList(arrLetter, repeat);
                }
                if (n > 0)
                {
                    RecPermutation(arrLetter, n - 1, repeat);
                }
            }
        }

        public List<string> GetPermutationsList(bool repeat = true)
        {
            _permutationsList = new List<string>
                    {
                        _str
                    };

            RecPermutation(_str.ToCharArray(), _str.Length, repeat);

            return _permutationsList;
        }
    }
}
