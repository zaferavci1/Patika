using System;

namespace arayuzler
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Smsm olarak log yazar");
        }
    }
}