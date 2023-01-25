namespace arrays_method;
class Program
{
    static void Main(string[] args)
    {
        //sort
        int[] arraySample = {23,12,4,86,72,3,11,17};
        Console.WriteLine("**** Unsorted Array****");
        
        foreach (var arrayItems in arraySample)
            Console.WriteLine(arrayItems);
        
        Console.WriteLine("**** Sorted Array****");
        Array.Sort(arraySample);
        
        foreach(var arrayitems in arraySample )
            Console.WriteLine(arrayitems);

        //clear
        Console.WriteLine("**** Array Clear ****");
        //clear items in array using the arrays item index number and clear length
        Array.Clear(arraySample,2,2); //start from 2. array and assign 0 2 items. 

        foreach(var arrayItems in arraySample)
            Console.WriteLine(arrayItems);

        //reverse
        Console.WriteLine("**** Array Reverse ****");
        Array.Reverse(arraySample);

        foreach(var arrayItems in arraySample)
        Console.WriteLine(arrayItems);

        //IndexOf
        Console.WriteLine("**** Array IndexOf ****");
        Console.WriteLine(Array.IndexOf(arraySample,23));

        //Resize
        Console.WriteLine("**** Array Resize ****");
        Array.Resize<int>(ref arraySample,9);
        arraySample[8] = 1234;

        foreach(var arrayItems in arraySample)
            Console.WriteLine(arrayItems);

    }
}
