using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn.Интерфейсы
{
    class ConsoleDataProcessor : IDataProcessor
    { 
        public void ProcessData(IDataProvider dataProcessor)
        {
            Console.WriteLine(dataProcessor.GetData());
        }
    }
}
