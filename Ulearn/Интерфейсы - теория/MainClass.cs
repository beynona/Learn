using System;

namespace Ulearn.Интерфейсы
{
    class MainClass
    {
        static void Mains()
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DBDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());

        }
    }
}