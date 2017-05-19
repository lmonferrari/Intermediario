using System;

namespace Exercicio1_secao5
{
    class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _command;

        public DbCommand(DbConnection dbConnection, string command)
        {
            if (dbConnection.Equals(null) || string.IsNullOrWhiteSpace(command))
                throw new ArgumentNullException("null or empty");
             
            _dbConnection = dbConnection;
            _command = command;
        }

        public void Execute()
        {
            _dbConnection.Open();
            System.Console.WriteLine("sending : {0} to DB",_command);
            _dbConnection.Close();
        }
    }
}
