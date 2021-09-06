using SoloPractical.Interface_and_abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoloPractical
{
    class MainCS
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "123", "234" };

            List<string> list2 = new List<string>() { "333", "234", "123" };


            var intersecting = list1.Intersect(list2);
            foreach (var commonElement in intersecting)
            {
                Console.WriteLine(commonElement);
            }
        }

        static void InterfaceAndAbstract()
        {
            Player player = new Player();
            Weapon[] inventry = { new Gun(), new Bow() };

            foreach (var item in inventry)
            {
                item.Fire();
                item.ShowInfo();
                Console.WriteLine();
            }

            player.GetInfo(new Box());
        }
    }
}
