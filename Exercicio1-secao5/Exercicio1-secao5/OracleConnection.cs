using System;

namespace Exercicio1_secao5
{
    class OracleConnection: DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine("Openning Oracle.");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle.");
        }
    }
}
