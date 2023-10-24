using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220050
{
    class FlyingSuperhero : Superhero
    {
        public FlyingSuperhero(string nama, string kekuatan) : base(nama, kekuatan)
        {
        }

        public override void UsePower()
        {
            Console.WriteLine($"{nama} terbang melintasi langit dengan kekuatan {kekuatan}!");
        }
    }
}
