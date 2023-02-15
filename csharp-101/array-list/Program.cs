using System.Collections;

namespace array_list;
class Program
{
    static void Main(string[] args)
    {
       
       //System.Collections namespace
       ArrayList list = new ArrayList();

       list.Add("Brain");
       list.Add(2);
       list.Add(true);
       list.Add('A');

       //Accessing arraylist member
       Console.WriteLine(list[1]);

        //Accessing all members
        foreach(var item in list)
            Console.WriteLine(item);
        
        //AddRange
        Console.WriteLine("****Add Range****");
        
        //You can add any collection type inside exist Arraylist.
        //In C# arrays is also collection type. 
        //Their type is fixed and they are collections of objects.
        string[] colors = {"red","yellow","green"};
        list.AddRange(colors);
      
       //You can add also generic list as a collection type
        List<int> numbers = new List<int>(){1,8,3,7,9,92,5};
        list.AddRange(numbers);

        //Accessing all members
        foreach(var item in list)
            Console.WriteLine(item);
        
        //Sort
        Console.WriteLine("****Sort****");
        //this sort operation doesn't give any error in compile time but it will give an error on runtime because thera are different type like string and int. You can't compare int with string etc. You have to use int array for sort.
        //list.Sort();

        //Sort 
        List<int> numbersTwo = new List<int>(){1,8,3,7,9,92,5};
        ArrayList arrayList = new ArrayList();
        arrayList.AddRange(numbersTwo);
        arrayList.Sort();
        
        foreach(var item in arrayList)
            Console.WriteLine(item);
        
        //Binary Search
        
        Console.WriteLine("****Binary Search****");
        //İf you want to use binary search you should sort the array first. 
        //Binary search gives you a index number of value.
        Console.WriteLine(arrayList.BinarySearch(9));

        //Reverse
        
        //Change position symetricly. If array is sorted you can use like a ordering operations.
        Console.WriteLine("****Reverse****");
        arrayList.Reverse();

        foreach(var item in arrayList)
            Console.WriteLine(item);
        
        //Clear  
        
        //remove all items in arraylist
        arrayList.Clear();

        foreach(var item in arrayList)
            Console.WriteLine(item); //return empty

    }
}
