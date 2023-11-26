using System;

namespace OOP
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("File Logger");
        }
    }
}
