using System;

namespace interfaceSample
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Loggin with Sms.");
        }
    }
}