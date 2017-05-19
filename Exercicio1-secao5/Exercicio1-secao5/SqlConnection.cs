using System;

namespace Exercicio1_secao5
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString) { }
       
        public override void Open()
        {
            Console.WriteLine("Openning Sql.");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Sql.");
        }
    }
}
