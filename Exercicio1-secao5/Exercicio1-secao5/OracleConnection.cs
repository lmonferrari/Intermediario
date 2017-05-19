using System;

namespace Exercicio1_secao5
{
   
    class OracleConnection: DbConnection
    {
        private readonly string _connectionString;

        public OracleConnection(string connectionString)
            :base(connectionString) {
            _connectionString = connectionString;
        }

        public override void Open()
        {
            Console.WriteLine("Openning Oracle: {0}",  _connectionString );
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle.\n");
        }
    }
}
