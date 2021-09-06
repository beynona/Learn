using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn.Интерфейсы___практика
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
