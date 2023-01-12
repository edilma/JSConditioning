using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_BC
{
    class Program
    {
        static void Main(string[] args)
        {
            printEmoji(5);
            Console.ReadLine();
        }
        public static void printEmoji(int size)
        {
            for (int i = 0; i < size+1; i++)
            {
                string result = new String('@', i);
                Console.WriteLine(result);
            }
        }
    }
}
