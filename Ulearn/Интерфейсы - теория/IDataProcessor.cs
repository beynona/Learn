using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn.Интерфейсы
{
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProcessor);
    }
}
