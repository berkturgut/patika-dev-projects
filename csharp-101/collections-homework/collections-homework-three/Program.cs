namespace collections_homework_two;
class Program
{
    
    static void Main(string[] args)
    {
        List<string> vowels = new List<string>();
       
        Console.WriteLine("Please enter a sentences: ");
        string sentence = Console.ReadLine();
        
        Operations.FindVowels(sentence,vowels);
        Operations.PrintVowels(vowels);
        
    }
}

public static class Operations
{
 
    public static List<string> FindVowels(string sentence ,List<string> vowels)
    {
        string[] baseVowels = {"a" , "e", "ı" , "i" , "o" , "ö" , "u" , "ü"};
        
        for(int i = 0; i < sentence.Length; i++)
        {
            for(int j = 0; j < baseVowels.Length ; j++)
            {
                if(sentence[i].ToString().ToLowerInvariant() == baseVowels[j].ToString() && !vowels.Contains(baseVowels[j]))
                vowels.Add(baseVowels[j]);

                else
                continue;
            }

        }

        if(vowels.Count == 0)
        {
            Console.WriteLine("Vowel not found.");
            Environment.Exit(0);
        }
            
        return vowels;
    }


    public static void PrintVowels(List<string> vowels)
    {
        Console.Write("Vowels are : ");
        
        foreach(var item in vowels)
            Console.Write(item + " ");
    }

}