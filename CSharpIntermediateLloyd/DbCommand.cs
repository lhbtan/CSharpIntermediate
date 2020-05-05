
using System;

namespace CSharpIntermediateLloyd
{
    public class DbCommand
    {
        public DbConnection DbConn { get; set; }
        public string Command { get; set; }
        public DbCommand(DbConnection dbConn, string command)
        {
            if(dbConn == null || command == null || command == "")
            {
                throw new InvalidOperationException("cannot be null");
            }
            else
            {
                DbConn = dbConn;
                Command = command;
            }
        }

        public void Execute()
        {
            DbConn.OpenConnection();
            Console.WriteLine("running instructions: " + Command);
            DbConn.CloseConnection();
        }
    }
}
