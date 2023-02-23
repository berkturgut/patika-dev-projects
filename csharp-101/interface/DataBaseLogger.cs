using System;

namespace interfaceSample{

    public class DataBaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Logging with database");
        }
    }
}