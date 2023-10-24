using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220050
{
    class Program
    {
        static void Main(string[] args)
        {
            Superhero batman = new Superhero("Batman", "kecerdasan");
            Superhero superman = new FlyingSuperhero("Superman", "terbang");
            Superhero hulk = new SuperStrengthSuperhero("Hulk", "kekuatan super");

            Console.WriteLine("Superhero dengan kekuatannya:");
            Console.WriteLine("-----------------------");
            batman.UsePower();
            superman.UsePower();
            hulk.UsePower();
        }
    }
}
