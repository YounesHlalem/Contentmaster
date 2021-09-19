using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClientWPF
{
    public static class MyStringExtensions
    {
        public static bool Like(this string toSearch, string toFind)
        {
            if (toFind.Length == 0) return false;
            var res =  toSearch.Contains(toFind);
            return res;
        }
    }
}
