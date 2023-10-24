using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220050
{
    class SuperStrengthSuperhero : Superhero
    {
        public SuperStrengthSuperhero(string nama, string kekuatan) : base(nama, kekuatan)
        {
        }

        public override void UsePower()
        {
            Console.WriteLine($"{nama} menampilkan  {kekuatan} dengan mengangkat mobil!");
        }
    }
}
