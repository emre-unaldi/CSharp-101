using System;

namespace OOP
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database Logger");
        }
    }
}
