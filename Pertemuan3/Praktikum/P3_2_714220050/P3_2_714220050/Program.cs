using System;

namespace P3_2_714220050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Masukkan nilai N: ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ANAK AYAM TURUN " + nilai);

            if (nilai >= 1 && nilai <= 10)
            {
                int Ayam = nilai; 

                for (int i = Ayam; i >= 0; i--)
                {
                    if (i > 1)
                    {
                        Console.WriteLine($"Anak ayam turun {i}, mati satu tinggal {i - 1}");
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("Anak ayam turun 1, mati satu tinggal induknya");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nilai tidak boleh di bawah 0 atau di atas 10 ya");
            }
        }
    }
}
