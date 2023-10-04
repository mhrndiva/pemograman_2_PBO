using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_1_71420050
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Masukkan angka pertama");
            float Angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka pertama");
            float Angka2 = Convert.ToInt32(Console.ReadLine());

            float penjumlahan;
            float pengurangan;
            float perkalian;
            float pembagian;

            penjumlahan = Angka1 + Angka2;
            Console.WriteLine("{0} + {1} = {2}", Angka1, Angka2, penjumlahan);
            pengurangan = Angka1 - Angka2;
            Console.WriteLine("{0} - {1} = {2}", Angka1, Angka2, pengurangan);
            perkalian = Angka1 * Angka2;
            Console.WriteLine("{0} * {1} = {2}", Angka1, Angka2, perkalian);
            pembagian = Angka1 / Angka2;
            Console.WriteLine("{0} / {1} = {2}", Angka1, Angka2, pembagian);


        }
    }
}
