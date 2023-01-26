using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            intro();
        }

        private static void intro()
        {
            //strings are actuallly a char array
            string city = "Ankara";
            // Console.WriteLine(city[0]);
            foreach (char letter in city)
            {
                Console.WriteLine(letter);
            }
            string city2 = "Istanbul";
            //writing two strings together
            //string result = city + city2; intead of occupying place at memory
            //it is more useful to use string.format class

            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
