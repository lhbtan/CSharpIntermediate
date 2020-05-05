
using System;

namespace CSharpIntermediateLloyd
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString == "" || connectionString == null)
            {
                throw new InvalidOperationException("String cannot be empty or null");
            }
            else
            {
                ConnectionString = connectionString;
            }
        }
       
        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}
