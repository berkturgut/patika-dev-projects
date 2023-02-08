namespace math_datetime_methods;
class Program
{
    static void Main(string[] args)
    {
        //DateTime Library

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(20));
        Console.WriteLine(DateTime.Now.AddMonths(1));
        Console.WriteLine(DateTime.Now.AddYears(2));
        Console.WriteLine(DateTime.Now.AddMilliseconds(55));

        //08.02.2023
        Console.WriteLine(DateTime.Now.ToString("dd")); //08
        Console.WriteLine(DateTime.Now.ToString("ddd")); //Çar
        Console.WriteLine(DateTime.Now.ToString("dddd")); //Çarşamba

        Console.WriteLine(DateTime.Now.ToString("MM")); //02
        Console.WriteLine(DateTime.Now.ToString("MMM")); // Şub
        Console.WriteLine(DateTime.Now.ToString("MMMM")); // Şubat
        
        Console.WriteLine(DateTime.Now.ToString("yy")); //21
        Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

        //Math Library
        Console.WriteLine(Math.Abs(-25)); // 25 (Absolute value)
        Console.WriteLine(Math.Sin(10)); 
        Console.WriteLine(Math.Cos(10)); 
        Console.WriteLine(Math.Tan(10)); 

        Console.WriteLine(Math.Ceiling(22.3)); // 23 (higher value)
        Console.WriteLine(Math.Round(22.3)); // 22 (nearest value)
        Console.WriteLine(Math.Round(22.7)); // 23 (nearest value)
        Console.WriteLine(Math.Floor(22.7)); // 22 (lower value)

        Console.WriteLine(Math.Max(2,6)); 
        Console.WriteLine(Math.Min(2,6)); 
        
        Console.WriteLine(Math.Pow(3,4)); // 3 ^ 4 = 81
        Console.WriteLine(Math.Sqrt(9)); // square root = 3
        Console.WriteLine(Math.Log(9)); // value log(9) of e 
        Console.WriteLine(Math.Exp(3)); // e ^ 3
        Console.WriteLine(Math.Log10(10)); // value log(10) of 10






    }
        
}
