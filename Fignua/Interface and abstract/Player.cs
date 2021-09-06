using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloPractical.Interface_and_abstract
{
    class Player
    {
        public void Fire (Weapon weapon)
        {
            weapon.Fire();
        }
        public void GetInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }
}
