using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220050
{
    class Superhero
    {
        protected string nama;
        protected string kekuatan;

        public Superhero(string nama, string kekuatan)
        {
            this.nama = nama;
            this.kekuatan = kekuatan;
        }

        public virtual void UsePower()
        {
            Console.WriteLine($"{nama} menggunakan {kekuatan} super!");
        }
    }
}
