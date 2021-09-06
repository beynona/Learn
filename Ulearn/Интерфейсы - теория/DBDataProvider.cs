using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn.Интерфейсы
{
    class DBDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "DBData";
        }
    }
}
