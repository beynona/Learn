using System;
using Microsoft.Data.Sqlite;

namespace SqlLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqliteConnection("Data Source=ParseDataCrypto.db;Mode=ReadWriteCreate;"))
            {
                connection.Open();
            }
            Console.Read();
        }
    }
}
