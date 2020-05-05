
using System;

namespace CSharpIntermediateLloyd
{
    public class SqlConnection : DbConnection 
    {
        public SqlConnection(string connStr) :base(connStr)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Connection to sql opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection to sql closed");
        }
    }
}
