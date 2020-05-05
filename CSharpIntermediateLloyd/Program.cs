
using System;

namespace CSharpIntermediateLloyd
{
    class Program 
    {
        static void Main(string[] args)
        {
            var newConn = new DbCommand(new OracleConnection("conneccttiooonnees"), "oracle Instructions");
            newConn.Execute();
        }
    }
}
