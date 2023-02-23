namespace interface_sample;
class Program
{
    static void Main(string[] args)
    {
        Volvo volvo = new();
        Console.WriteLine(volvo.CountWheel());
        Console.WriteLine(volvo.TellBrandName());
        Console.WriteLine(volvo.TellColor());


        Renault renault = new();
        Console.WriteLine(renault.CountWheel());
        Console.WriteLine(renault.TellBrandName());
        Console.WriteLine(renault.TellColor());

    }
}
