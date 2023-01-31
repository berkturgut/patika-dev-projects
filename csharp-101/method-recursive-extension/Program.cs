namespace method_recursive_extension;
class Program
{
    static void Main(string[] args)
    {
        //recursive function 
        //3 * 4 = 3 * 3 * 3 * 3

        //primitive for loop for recursive process
        int result = 1;

        for(int i = 1; i < 5 ; i++)
            result = result * 3;
        Console.WriteLine("This is for loops calculation : " + result);

        //recursive function
        myMethods myMethods = new(); //C# 9 preview. We can declare instances like this.
        Console.WriteLine("This is recursive function calculation : " + myMethods.Expo(3,4));


        //extension methods sample 1 
        string name = "Berk Turgut";
        bool stringResult = name.CheckSpace();
        Console.WriteLine(stringResult);

        if(stringResult)//remove white space, make lover case and make upper case
        {
        Console.WriteLine(name.RemoveWhiteSpace());
        Console.WriteLine(name.MakeLowerCase());
        Console.WriteLine(name.MakeUpperCase());
        }

        //extension methods sample 2 
        int[] intArray = {12, 3, 4, 5, 23, 6, 1}; 
        intArray.SortArray();
        intArray.PrintOnScreen();

        //extension methods sample 3 
        int evenCheck = 2;
        Console.WriteLine(evenCheck.IsEvenNumber());

        //pick first character on string
        string lastName = "Turgut";
        Console.WriteLine(lastName.GetFirstCharacter());


        
    }
}

public class myMethods
{
    public int Expo(int number, int exponent)
    {
        if(exponent < 2)
            return number; // 3 ^ 1 result
        return Expo(number,exponent - 1) * number;
        // Expo(3 ,4)
        // Expo(3 ,3) * 3
        // Expo(3 ,2) * 3 * 3
        // Expo(3 ,1) * 3 * 3 * 3 (if condition triggered)
        // 3 * 3 * 3 * 3 = 81
    }
}

public static class myExtensions //entension class and methods must be static.
{
    public static bool CheckSpace(this string param) //if we add this keyword this method behave like extension method. This extension method only avaible for string type data.
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpace(this string param)
    {
        string[] myArray = param.Split(" ");
        return string.Join("",myArray);
    }

    public static string MakeUpperCase(this string param) // you can set the default .net methods like this.
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param) // you can set the default .net methods like this.
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void PrintOnScreen(this int[] param)
    {
        foreach(var item in param)
            Console.WriteLine(item);
    }

    public static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0 ;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }
     
 
}