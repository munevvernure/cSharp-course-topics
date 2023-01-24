using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrayler sayesinde aynı veri tipindeki degiskenleri 
            //tek bir noktada toplayıp onları tek bir noktadan kontrol edebiliriz
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            //ya da su sekilde tanimlanabilir
            //basina yazdigimiz new olmadan da arrayi tanimlayabilirdik
            //string[] students2 = new[] { "Engin", "Derin", "Salih" };

            //foreach döngüsü bir arrayi gezmek için kullanılır
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //Tr nin bes bölgesi ve bu bes bölgenin
            //en büyük uc sehrini tutan ikiboyutlu dizi örnegi
            string[,] regions = new string[5, 3]
            {
                {"Istanbul", "Izmit", "Balikesir"},
                {"Ankara","Konya","Kirikkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"Izmir","Mugla","Manisa"},

            }; 

            for(int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j=0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine();
            }

           
            Console.ReadLine();
        }
    }
}
