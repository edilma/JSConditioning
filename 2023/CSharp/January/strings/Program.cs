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
            //string word = "This website is for losers LOL!";
            //Console.WriteLine(Disemvowel2(word));
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //Console.WriteLine(CreatePhoneNumber(numbers));
            //Console.WriteLine(evaporator(10, 10, 5));
            List<object> mylist = new List<object> { 1, 2, "a", "b" };
            IEnumerable<int> answer = GetIntegersFromList2(mylist);

            foreach (int item in answer)
            {
                Console.WriteLine(item);
            }





            Console.ReadLine();
        }
        //best practice
        public static IEnumerable<int> GetIntegersFromList2(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            int num = 9;
            List<int> mylist = new List<int>();
            foreach (var item in listOfItems)
            {
                if (item.GetType()== num.GetType())
                {
                    mylist.Add((int)item);
                }
            }
            return mylist;
        }

        public static int evaporator2(double content, double evap_per_day, double threshold)
        {
            int days = 0;
            double amountLeft = 100;
            double evapToday = evap_per_day * amountLeft/100;
            do
            {
                days++;
                amountLeft = amountLeft - evapToday;
                evapToday = evap_per_day * amountLeft / 100;
            } while (amountLeft > threshold);
            return days;
           
        }

        //best practice evaporator 
        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            return (int)Math.Ceiling(Math.Log(threshold / 100.0) / Math.Log(1.0 - evap_per_day / 100.0));
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            List<string> strNum = new List<string>();
            foreach (int item in numbers)
            {
                strNum.Add(item.ToString());

            }
            return $"({strNum[0]}{strNum[1]}{strNum[2]}) {strNum[3]}{strNum[4]}{strNum[5]}-{strNum[6]}{strNum[7]}{strNum[8]}{strNum[9]}";
        }
        //Best practice Create phone number
        public static string CreatePhoneNumber2(int[] numbers)
        {
            return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x => x.ToString()).ToArray());
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
