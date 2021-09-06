using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloPractical.Interface_and_abstract
{
    abstract class Weapon : IHasInfo
    {
        public abstract int Damage { get; }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}: Damage - {Damage}");
        }
    }
}
