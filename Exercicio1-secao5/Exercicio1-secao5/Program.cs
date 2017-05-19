namespace Exercicio1_secao5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new DbCommand(new SqlConnection("SQL_DB"), "Select * from User");
            sql.Execute();

            var oracle = new DbCommand(new OracleConnection("ORACLE_DB"), "Select * from User");
            oracle.Execute();
        }
    }
}
