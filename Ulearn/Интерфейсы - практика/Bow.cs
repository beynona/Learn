using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn.Интерфейсы___практика
{
    class Bow : Weapon
    {
        public override int Damage { get { return 2; } }

        public override void Fire()
        {
            Console.WriteLine("Чпоньк");
        }
    }
}
