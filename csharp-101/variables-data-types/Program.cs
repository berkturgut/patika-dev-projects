namespace variables_data_types;
class Program
{
    static void Main(string[] args)
    {
        // Integers
        byte b = 5;         //1 byte 
        sbyte c = 5;        //1 byte

        short s = 5;         //2byte
        ushort us = 5;       //2byte

        Int16 i16 = 2;       //2byte
        int i = 2;           //4byte
        Int32 i32 = 2;       //4byte
        Int64 i64 = 2;

        uint ui = 2;        //4 byte
        long l = 4;         //8 byte
        ulong ul = 4;       //8 byte
        
        //Reel Numbers

        float f = 5;        //4 byte
        double d = 5;       //8 byte
        decimal de = 5;    //16 byte

        //String Variable
        
        char ch = '2';       //2 byte
        string str ="Berk";  //infinite

        //Logical

        bool b1 = true;
        bool b2 = false;

        //Time Variables 

        DateTime dt = DateTime.Now;

        Console.WriteLine(dt);

        //Object Variables

        object o1 = "x";
        object o2 = "y";
        object o3 = "4";
        object o4 = "4.3";

        // String Expressions

        string str1 = string.Empty;
        str1 = "Berk Turgut";
        string ad = "Berk";
        string soyAd = "Turgut";
        String tamIsim = ad + " " + soyAd;

        //Integer Definitions

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 + integer2;

        //Boolean Expression

        bool bool1 = 10 > 2;

        //Type Conversion

        string str20 = "20";
        int int20 = "20";
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger); //output is 2020

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); //output is 40

        //DateTime Formats

        string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(dateTime);

        string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy"); //output is dd.mm.yyyy . To solve this we use culturelinfo class.
        Console.WriteLine(dateTime2);

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
    }
}
