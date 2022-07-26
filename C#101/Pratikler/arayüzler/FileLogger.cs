using System;

namespace arayuzler
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya Log Yazar");
        }
    }
}