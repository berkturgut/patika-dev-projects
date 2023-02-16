namespace dictionary;
class Program
{
    static void Main(string[] args)
    {
        
        //system.collection.generic
        Dictionary<int,string> users = new Dictionary<int, string>();

        users.Add(10,"Ayşe Yilmaz");
        users.Add(12,"Ahmet Yilmaz");
        //users.Add(12,"gives error"); If you have same key program will error on runtime not compile time.
        users.Add(18,"Deniz Arda");
        users.Add(20,"Özcan Çoşar");

        //Accesing Dictionary members
        Console.WriteLine("****Accessing Members****");
        
        //Single : Output : Gives an value of 12 key.
        Console.WriteLine(users[12]);
        
        //Write all members(key - value)
        foreach(var item in users)
            Console.WriteLine(item);
        
        //Count
        Console.WriteLine(users.Count);

        //Contains Key
        Console.WriteLine(users.ContainsKey(12));
        //Contains Value
        Console.WriteLine(users.ContainsValue("Zikriye Ürkmez"));

        //Remove
        Console.WriteLine("****Remove****");
        users.Remove(12);

        foreach(var item in users)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }    

        //Keys : Only works with Keys
        Console.WriteLine("****Keys****");
        foreach(var item in users.Keys)
            Console.WriteLine(item);
        
        //Values : Only works with Values
        Console.WriteLine("****Values****");
        foreach(var item in users.Values)
            Console.WriteLine(item);
    }
}
