using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "This website is for losers LOL!";
            Console.WriteLine(Disemvowel2(word));
            Console.ReadLine();
        }
        public static string Disemvowel(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string result = "";
            foreach (char letter in str)
            {
                if (!vowels.Contains(Char.ToLower(letter)))
                {
                    result += letter;
                }
            }
            return result;
        }
        //BEST PRACTICE
        public static string Disemvowel2(string str)
        {
            //return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));

        }
    }
}
