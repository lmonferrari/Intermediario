using System;

namespace Exercicio1_secao5
{

    public abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        public abstract void Open();
        public abstract void Close();

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection string");

            _connectionString = connectionString;
        }
    }
}
