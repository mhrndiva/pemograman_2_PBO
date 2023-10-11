using System;

namespace P3_3_NPM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Hitung Luas");
            Console.WriteLine("2. Hitung Keliling");
            Console.WriteLine("Pilih menu (1/2): ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Masukkan panjang: ");
                int panjang = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan lebar: ");
                int lebar = Convert.ToInt32(Console.ReadLine());

                int luas = panjang * lebar;
                Console.WriteLine($"Luas persegi panjang: {luas}");
            }
            else if (input == "2")
            {
                Console.Write("Masukkan panjang: ");
                int panjang = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan lebar: ");
                int lebar = Convert.ToInt32(Console.ReadLine());

                int keliling = 2 * (panjang + lebar);
                Console.WriteLine($"Keliling persegi panjang: {keliling}");
            }
            else
            {
                Console.WriteLine("Menu tidak tersedia.");
            }

            Console.Write("Ingin mengulang? (Y/T): ");
            string response = Console.ReadLine().ToLower();

            if (response == "t")
            {
                Console.WriteLine("Terima kasih! Besok berhitung lagi yuk!");
            }
        }
    }
}
