using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn.Интерфейсы
{
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "FileData";
        }
    }
}
