using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloPractical.Interface_and_abstract
{
    class Gun : Weapon
    {
        public override int Damage { get { return 15; } }

        public override void Fire()
        {
            Console.WriteLine("Выстрел с гана");
        }
    }
}
