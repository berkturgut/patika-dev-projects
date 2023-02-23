namespace interfaceSample;
class Program
{
    static void Main(string[] args)
    {
        FileLogger fileLogger = new FileLogger();
        fileLogger.WriteLog();

        SmsLogger smsLogger = new SmsLogger();
        smsLogger.WriteLog();

        //You can also declare object like this.
        DataBaseLogger databaseLogger = new();
        databaseLogger.WriteLog();

        //We are using Logmanager instance.
        LogManager manager = new LogManager(new FileLogger());
        manager.WriteLog();
    }
}
