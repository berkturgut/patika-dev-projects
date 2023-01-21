namespace type_conversion;
class Program
{
    static void Main(string[] args)
    {
        //Implicit Conversion 

       byte a = 5;
       sbyte b = 5;
       short c = 10;

       int d = a + b + c;
       Console.WriteLine("d:" + d);

       long h = d;
       Console.WriteLine("h:" + h);

       float i = h;
       Console.WriteLine("i:" + i);

       string e= "zikriye";
       char f='k';
       object g = e + f + d;
       Console.WriteLine("g:" + g);

       //Explicit Conversion
       Console.WriteLine("****** Explicit Conversion******");

       int x = 4;
       byte y = (byte)x;
       Console.WriteLine("y:" + y);

       float w = 10.3f;
       byte v =(byte)w;
       Console.WriteLine("v:" + v);

       //Extra Methods For Conversion
       
       //ToString Method
       Console.WriteLine("****** ToString Method******");
       
       int xx = 6;
       string yy = xx.ToString();
       Console.WriteLine("yy:" + yy);

       string zz = 12.5f.ToString();
       Console.WriteLine("zz:" + zz);

       //System.Convert 
        Console.WriteLine("***** System.Convert Class *****");

        string s1 = "10", s2="20";
        int sayi1, sayi2;
        int toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);

        toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam:" + toplam);

        // Parse Method 
        Console.WriteLine("***** System.Convert Class *****");
        ParseMethod();


    }

    public static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;

        rakam1 = Int32.Parse(metin1);
        double1 = Double.Parse(metin2);

        Console.WriteLine("rakam1:" + rakam1);
        Console.WriteLine("double1:" + double1);
    }


}
