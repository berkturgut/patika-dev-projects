namespace collections_homework_two;
class Program
{
    
    static void Main(string[] args)
    {
        int[] numbers = new int[20];
        int[] highestThreeValues = new int[3];
        int[] lowestThreeValues = new int[3];
        
        Console.WriteLine("Please Enter 20 different and positive integer: ");
        BasicCalculations.InputNumbers(numbers);
        BasicCalculations.FindHighestThree(numbers,highestThreeValues);
        BasicCalculations.FindLowestThree(numbers,lowestThreeValues);
        BasicCalculations.PrintArray(highestThreeValues,"Highest");
        BasicCalculations.PrintArray(lowestThreeValues,"Lowest");
        Console.WriteLine("\nAvarage of highest three values is : " + BasicCalculations.AvarageHighestThree(highestThreeValues));
        Console.WriteLine("Avarage of lowest three values is : " + BasicCalculations.AvarageLowestThree(lowestThreeValues)); 
        BasicCalculations.TotalAvarageMinMax(BasicCalculations.AvarageHighestThree(highestThreeValues), BasicCalculations.AvarageLowestThree(lowestThreeValues));
        
    }
}

public static class BasicCalculations
{
    public static void InputNumbers(int[] numbers)
    {
        for(int i = 0; i < 20 ; i++)
        {
           bool isNumber = Int32.TryParse(Console.ReadLine(),out int number);

           if(isNumber || !numbers.Contains(number))
            numbers[i] = number;

           else
           Console.WriteLine("Invalid Input"); 
           Environment.Exit(0); 

        }
    }

    public static void FindHighestThree(int[] numbers,int[] maxThreeValues)
    {
        Array.Sort(numbers);
        Array.Reverse(numbers);
        for(int i = 0 ; i < 3; i++)
        {
            maxThreeValues[i] = numbers[i]; 
        }
        
    }

    public static void FindLowestThree(int[] numbers,int[] minThreeValues)
    {
        Array.Sort(numbers);
        for(int i = 0; i < 3; i++)
        {
            minThreeValues[i] = numbers[i];
        }
        
    }

    public static int AvarageHighestThree(int[] highestThreeValues )
    {
        int totalHighestThreeValues = 0;
        int avarageTotal = 0;
         foreach(var item in highestThreeValues)
         {
            totalHighestThreeValues += item;
         }
         avarageTotal = totalHighestThreeValues / highestThreeValues.Count();
         return  avarageTotal;
    }

    public static int AvarageLowestThree(int[] lowestThreeValues )
    {
        int totalLowestThreeValues = 0;

         foreach(var item in lowestThreeValues)
         {
            totalLowestThreeValues += item;
         }
        int avarageTotal = totalLowestThreeValues / lowestThreeValues.Count();
    
    return avarageTotal;
    }

    public static void TotalAvarageMinMax(int AvarageHighestThree,int AvarageLowestThree)
    {
        int total = AvarageHighestThree + AvarageLowestThree;
        Console.WriteLine("Sum of avarages highest and lowest three numbers is: " + total);
    }

    public static void PrintArray(int[] array, string valuesType)
    {
        Console.Write("\n" + valuesType + " three numbers are : ");
        foreach (var item in array)
        {
           Console.Write(" " + item + " "); 
        }

    }

    


}