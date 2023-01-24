using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // forLoop();
            // whileLoop();
            doWhileLoop();

        }

        private static void doWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number),
                number--;
            } while (number >= 0);
        }

        private static void whileLoop()
        {
            int number = 100;
            //While döngüsü içindeki sart saglandigi sürece icindeki 
            //kod blogunu calistirmaya devam eder
            while (number >= 0)
            {
                //sayida bir degisiklik yapmadigimiz icin sart hep saglanir ve sonsuz dönguye girer
                Console.WriteLine(number);
                // number--;  boyle yazarak dongunun durmasini saglayabiliriz
            }
        }

        private static void forLoop()
        {
            //program that writes odd numbers on the screen
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
