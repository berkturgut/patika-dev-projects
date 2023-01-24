namespace while_foreach_loops;
class Program
{
    static void Main(string[] args)
    {
        //Find the avarage from 1 to input number
        Console.WriteLine("Lütfen bir sayı giriniz.");
        int avarageNumber = int.Parse(Console.ReadLine());
        int counter = 1;
        int sum = 0;
        
        while(counter <= avarageNumber)
        {
            sum += counter;
            counter++;
        }

        Console.WriteLine(sum/avarageNumber);


        //Write all characters from a to z.
        char character = 'a';

        while(character <= 'z')
        {
            Console.Write(character);
            character++;
        }
        
        //For each
        Console.WriteLine("****Foreach Loop****");
        string[] cars = {"BMV","Ford","Nissan"};

        foreach(var singleCarName in cars)
        {
            Console.WriteLine(singleCarName);
        }
    }
}
