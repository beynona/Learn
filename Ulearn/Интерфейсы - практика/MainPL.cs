using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn.Интерфейсы___практика
{
    class MainPlay
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] inventory = { new Gun(), new Bow() };
            foreach (var item in inventory)
            {
                item.Fire();
                item.ShowInfo();
                Console.WriteLine();
            }
            player.GetInfo(new Box());
        }
    }
}
