
using System;

namespace CSharpIntermediateLloyd
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connStr) : base(connStr)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Connection to oracle opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection to oracle closed");
        }
    }
}
