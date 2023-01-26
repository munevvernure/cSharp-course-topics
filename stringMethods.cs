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
            //intro();
            //string methods
            string sentence = "My name is Munevver";
            var result = sentence.Length; //sentence. length shows the number of characters
            var result2 = sentence.Clone(); //it is used to copy any text from any variable to another variable
            bool result3 = sentence.EndsWith("g");// it checks whether the sentence ends with g and returns a boolean value
            bool result4 = sentence.StartsWith("My name"); // checks the start of the sentence
            var result5 = sentence.IndexOf("name"); //it shows the startinh index of the word name
            var result6 = sentence.LastIndexOf(" "); //it starts cntrolling from the end
            var result7 = sentence.Insert(0, "Hello, "); // it adds the given string from 0th character
            var result8 = sentence.Substring(3); // it starts printing from 3rd character
            var result9 = sentence.Substring(3,4); // it starts printing from 3rd character and prints the following 4 character
            var result10 = sentence.ToLower(); //converts all characters to lowercase
            var result11 = sentence.ToUpper(); //converts all characters to uppercase
            var result12 = sentence.Replace(" ", "-"); // this method allows us to use dash instead of space and changes it 
            var result13 = sentence.Remove(2);//it removes all characters after the 2nd character
            var result14 = sentence.Remove(2,4);//it removes 4 characters after the 2nd character
            Console.WriteLine(result);
            Console.ReadLine();
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
