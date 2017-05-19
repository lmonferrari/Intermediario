using System;

namespace Exercicio1_secao5
{
    class SqlConnection : DbConnection
    {
        private readonly string _connectionString;

        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            _connectionString = connectionString;
        }
       
        public override void Open()
        {
            Console.WriteLine("Openning Sql: {0}", _connectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Closing Sql.\n");
        }
    }
}
