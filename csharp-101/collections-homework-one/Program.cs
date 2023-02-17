using System.Collections;

namespace collections_homework_one;
class Program
{
    static void Main(string[] args)
    {
       
        ArrayList primeNumber = new ArrayList();
        ArrayList compositeNumber = new ArrayList();

        Console.WriteLine("Please Enter 20 numbers.");
    
        BasicCalculations.EnterNumbers(primeNumber,compositeNumber);
        
        Console.WriteLine("****Sorted Lists****");
        
        Console.Write("Prime numbers = ");
        BasicCalculations.PrintSortedArray(primeNumber);

        Console.Write("\nComposite numbers = ");
        BasicCalculations.PrintSortedArray(compositeNumber);

        Console.WriteLine("\n\n****Total Number Of Lists****");
        
        Console.Write("Prime numbers = ");
        BasicCalculations.PrintArrayCount(primeNumber);
       
        Console.Write("\nComposite numbers = ");
        BasicCalculations.PrintArrayCount(compositeNumber);

        Console.WriteLine("\n\n****Avarage of numbers****");
        
        Console.Write("Avarage of prime numbers = ");
        BasicCalculations.PrintArrayAvarage(primeNumber);

        Console.Write("\nAvarage of composite numbers = ");
        BasicCalculations.PrintArrayAvarage(compositeNumber);


        
    }
}

static class BasicCalculations
{

    public static void EnterNumbers(ArrayList primeNumbers, ArrayList compositeNumbers)
    {
         
        for(int i = 0; i < 20 ; i++)
        {
        bool isNumber = int.TryParse(Console.ReadLine(), out int number);
        
            if(number < 0 || !isNumber || primeNumbers.Contains(number) || compositeNumbers.Contains(number))
            {
                Console.WriteLine("Invalid Input Error.");
                Environment.Exit(0);  
            }

            else if(BasicCalculations.isPrime(number))
                primeNumbers.Add(number);
            else
                compositeNumbers.Add(number);
        }

    }

    public static bool isPrime (int number)
    {
        if(number <= 1 || number % 2 == 0)
            return false;
        else if(number == 2)
            return true;
       
        var boundary = (int)Math.Floor(Math.Sqrt(number));
        
        for(int i = 3; i <= boundary ; i++)
        {
            if(number % i == 0)
                return false;
        }

        return true;    
    }

    public static void PrintSortedArray(ArrayList list)
    {
        list.Sort();
        list.Reverse();
        foreach(var item in list)
            Console.Write(item + " ");
    }

    public static void PrintArrayCount(ArrayList list)
    {
        Console.Write(list.Count);
    }

    public static void PrintArrayAvarage(ArrayList list)
    {
        int itemCount = list.Count;
        int itemTotal = 0;

        foreach(var item in list)
        {
            itemTotal += (int)item;
        }

        Console.Write(itemTotal / itemCount);
    }


}
