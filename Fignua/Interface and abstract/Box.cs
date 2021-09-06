using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloPractical.Interface_and_abstract
{
    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("Коробка");
        }
    }
}
