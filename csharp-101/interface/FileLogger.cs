using System;

namespace interfaceSample
{

    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Logging with file.");
        }
    }

}