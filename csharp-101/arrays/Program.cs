namespace arrays;
class Program
{
    static void Main(string[] args)
    {
        //define an array
        string[] colors = new string[5]; //option 1 

        string[] animals = {"cat", "bird", "monkey"}; //option 2 

        int[] myArray;
        myArray = new int[5]; //option 3

        //assigning a value to the arrays and accessing array members
        colors[0] = "Blue";
        myArray[3] = 10;

        Console.WriteLine(animals[2]);
        Console.WriteLine(myArray[3]);
        Console.WriteLine(colors[0]);

        //using loops with arrays
        //example : Find the average of n numbers entered from the console.
        Console.Write("Please enter length of the array ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numArray = new int[arrayLength];

        for(int i=0; i < arrayLength; i++)
        {
            Console.WriteLine("Please enter the {0}. number",i + 1);
            numArray[i] = int.Parse(Console.ReadLine()); 
        }

        int sum = 0;

        foreach (var arrayItem in numArray)
        {
            sum += arrayItem;
        }
        Console.WriteLine("Avarage is : " + (sum / arrayLength) );
    }
    
}
