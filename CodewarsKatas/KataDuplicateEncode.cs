/* 12-Marzo-2022

The goal of this exercise is to convert a string to a new string where each character in the 
new string is "(" if that character appears only once in the original string, or ")" 
if that character appears more than once in the original string. Ignore capitalization when determining 
if a character is a duplicate.

Examples
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 

Kata: https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
*/

using System;

namespace CodewarsKatas
{
    public class KataDuplicateEncode
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            string result = "";

            //Recorrer caracteres de palabra original
            for (int i = 0; i < word.Length; i++)
            {
                if (word.IndexOf(word[i]) != word.LastIndexOf(word[i]))
                    result += ")";
                else
                    result += "(";
            }

            return result;
        }

        /*** 1st - Best Solution Selec ***
         * 
        using System.Linq;
        public static string DuplicateEncode(string word)
        {  
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }

         */

        /*** 2nd - Best Solution Selec ***
         * 
        using System.Linq;
        using System.Collections.Generic;
        public static string DuplicateEncode(string word)
        {
            var disct = word.ToUpper().Distinct();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach(var c in word.ToUpper())
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts.Add(c, 1);
            }

            StringBuilder builder = new StringBuilder();
            foreach(var c in word.ToUpper())
            {
                if (counts[c] == 1)
                    builder.Append('(');
                else
                    builder.Append(')');
            }

            return builder.ToString();
        }

         */
    }
}
