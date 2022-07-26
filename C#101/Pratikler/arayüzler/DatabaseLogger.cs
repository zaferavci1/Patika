using System;

namespace arayuzler
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Database'a log yazar");
        }
    }
}