namespace string_methods;
class Program
{
    static void Main(string[] args)
    {
        //String Methods
        string sentence = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
        string longestword = "simply dummy";
        string longestwordUp = "Simply dummy";

        //Length
        Console.WriteLine(sentence.Length); //find string length

        //ToUpper,ToLower
        Console.WriteLine(sentence.ToUpper()); //all characters transform upper case 
        Console.WriteLine(sentence.ToLower()); //all characters transform lower case

        //Concat
        Console.WriteLine(String.Concat(sentence,"Merhaba")); // concatenates two string

        //Compare
        Console.WriteLine(String.Compare(sentence,longestword,true));// true : casesensitive is closed. Compare two strings.
        Console.WriteLine(String.Compare(longestwordUp,longestword,false));
        //CompareTo
        Console.WriteLine(sentence.CompareTo(longestword)); //comparte to character long. Return 1 0 -1

        //Contains
        Console.WriteLine(sentence.Contains("Lorem"));// if variables contains string return true;
        //EndWith
        Console.WriteLine(sentence.EndsWith("y."));//if sentence ends with y. return true;
        //StartsWith
         Console.WriteLine(sentence.StartsWith("Lorem"));//if sentence starts with Lorem return true;
        //IndexOf
         Console.WriteLine(sentence.IndexOf("Lorem"));//if sentences contains Lorem return index of "L". If false return -1
        //Insert 
        Console.WriteLine(sentence.Insert(0,longestword)); // start index 0 and add string to the variable.
        //LastIndexOf
        Console.WriteLine(sentence.LastIndexOf("i")); //if variable contains lots of "i"  return the last index of i characters. 
        
        //PadLeft, PadRight
        Console.WriteLine(sentence + longestwordUp.PadLeft(120));//create space(word.length - 120)
        Console.WriteLine(sentence + longestwordUp.PadLeft(120,'*'));//adding * (word.length - 120)
        Console.WriteLine(sentence.PadRight(120) + longestwordUp);////create space(word.length - 120)
        Console.WriteLine(sentence.PadRight(120,'-') + longestwordUp);//adding - (word.length - 120)
    
        //Remove
        Console.WriteLine(sentence.Remove(10)); // remove after the 10th character
        Console.WriteLine(sentence.Remove(5,3));//starts with 5th character and remove 3 character
        Console.WriteLine(sentence.Remove(0,1));//starts with 0 index and remove 1 character

        //Replace
        Console.WriteLine(sentence.Replace("Lorem","REPLACED"));//replace Lorem with REPLACED
        Console.WriteLine(sentence.Replace(" ","*"));//replace space with *
        //Split
        Console.WriteLine(sentence.Split(' ')[1]);//splits the sentences by space, creates array and return first word. 
        //Substring
        Console.WriteLine(sentence.Substring(4)); //starts from 4th index and returns all string value.
        Console.WriteLine(sentence.Substring(4,6));//starts from 4th index and return 6 characters after that. 
    
    
    
    
    
    }
}
