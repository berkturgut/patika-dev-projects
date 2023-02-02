namespace consoleapp_homework_csharp;
class Program
{
    static void Main(string[] args)
    {
        UserInterFace.HomeScreen();
        UserInterFace.Start();
    }
}
public static class UserInterFace
{
    public static void HomeScreen()
    {

        Console.WriteLine("******************************");
        Console.WriteLine("\n MULTI PURPOSE CALCULATOR \n");
        Console.WriteLine("******************************");
        Console.WriteLine("1. Find Even Numbers");
        Console.WriteLine("2. Find Dividend");
        Console.WriteLine("3. Word Sorter");
        Console.WriteLine("4. Word and Character Counter.");
        Console.WriteLine("******************************");

    }
    public static void Start()
    {

        Console.Write("\nPlease select an action using sequence number: ");
        bool isActionNumber = byte.TryParse(Console.ReadLine(), out byte actionNumber);

        if (!isActionNumber || actionNumber < 0 || actionNumber > 4)
        {
            Console.WriteLine("You entered invalid action number. Please run the program and try again.");
        }

        else
        {
            switch (actionNumber)
            {
                case (int)ActionsName.Credit:
                    UserInterFace.CreditScreen();
                    break;
                case (int)ActionsName.FindEvenNumbers:
                    ActionMethods.FindEven();
                    break;
                case (int)ActionsName.FindDividend:
                    ActionMethods.FindDividend();
                    break;
                case (int)ActionsName.WordSorter:
                    ActionMethods.WordSorter();
                    break;
                case (int)ActionsName.WordAndCharacterCounter:
                    ActionMethods.WordAndCharacterCounter();
                    break;
            }
        }
    }
    public static void FindEvenNumbersInputScreen()
    {
        Console.WriteLine("\n **** Find Even Numbers **** \n");
        Console.Write("Please enter a length of numbers: ");
    }
    public static void InvalidInputScreen()
    {
        Console.WriteLine("Input error. Program will shut down");
        Environment.Exit(0);
    }

    public static void DuplicateInputScreen()
    {
        Console.WriteLine("Duplicate Input error. Program will shut down");
        Environment.Exit(0);
    }
    public static void CreditScreen()
    {
        Console.WriteLine("This program created for Patika.Dev's .Net Core Learning Path");
    }
}
enum ActionsName
{
    Credit,
    FindEvenNumbers,
    FindDividend,
    WordSorter,
    WordAndCharacterCounter
}
public static class ActionMethods
{
    public static void FindEven()
    {
        UserInterFace.FindEvenNumbersInputScreen();
        bool islengtNumbers = int.TryParse(Console.ReadLine(), out int lengthNumber);

        if (!islengtNumbers || lengthNumber <= 0)
        {
            UserInterFace.InvalidInputScreen();
        }

        int[] numbersArray = new int[lengthNumber];

        for (int i = 0; i < lengthNumber; i++)
        {
            try
            {
                Console.Write($"Please enter {i + 1}. number: ");
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                UserInterFace.InvalidInputScreen();
            }

        }

        Console.Write("\nNumber value received. Even numbers are: ");

        foreach (var item in numbersArray)
        {
            if (item.IsEvenNumber())
                Console.Write(item + " ");
        }

    }
    public static void FindDividend()
    {

        Console.Write("Please enter total length of numbers: ");
        bool isLengthNumber = int.TryParse(Console.ReadLine(), out int lengthNumber);
        Console.Write("Please enter a divider number: ");
        bool isDividerNumber = int.TryParse(Console.ReadLine(), out int dividerNumber);

        if (lengthNumber > 0 && dividerNumber > 0)
        {
            Console.WriteLine($"Please enter {lengthNumber} numbers: ");
        }

        else
        {
            UserInterFace.InvalidInputScreen();
        }

        int[] dividendNumbers = new int[lengthNumber];

        for (int i = 0; i < lengthNumber; i++)
        {
            Console.Write($"Please write {i + 1}. number: ");
            bool isArrayNumber = int.TryParse(Console.ReadLine(), out int arrayNumber);

            if (arrayNumber > 0 && dividendNumbers.IsArrayItemsDuplicate(arrayNumber))
            {
                dividendNumbers[i] = arrayNumber;
            }

            else
            {
                UserInterFace.DuplicateInputScreen();
            }

        }

        Console.WriteLine($"This numbers are dividable by or equal to {dividerNumber}");
        
        foreach (var item in dividendNumbers)
        {
            if (item.IsEqualOrDividable(dividerNumber))
                Console.Write(item + " ");
        }

    }
    public static void WordSorter()
    {
        Console.WriteLine("Please enter how many words do you want to enter");
        bool isWordCount = int.TryParse(Console.ReadLine(), out int wordCount);

        if (isWordCount && wordCount > 0)
        {
            Console.WriteLine($"Please enter {wordCount} words: ");
        }

        string[] wordsArray = new string[wordCount];

        for (int i = 0; i < wordCount; i++)
        {
            wordsArray[i] = Console.ReadLine();
        }

        Console.Write("Your words list are: ");
        for (int i = 0; i < wordCount; i++)
        {
            Console.WriteLine(wordsArray[i] + " ");
        }
        
        Console.Write("The reverse of the list are: ");
        for (int i = 1; i <= wordCount; i++)
        {
            Console.WriteLine(wordsArray[wordCount - i] + " ");
        }

    }
    public static void WordAndCharacterCounter()
    {
        Console.WriteLine("Please enter your sentence");
        string sentence = Console.ReadLine();
        sentence.WordsCounter();
        sentence.CharacterCounter();

    }
}
public static class ActionExtensionClass
{
    public static bool IsEvenNumber(this int value)
    {
        if (value % 2 == 0)
            return true;
        else
            return false;
    }
    public static bool IsEqualOrDividable(this int value, int divider)
    {
        if (value % divider == 0 || value == divider)
            return true;
        else
            return false;
    }
    public static bool IsArrayItemsDuplicate(this int[] words, int item)
    {
        bool result = Array.Exists(words, element => element == item) ? false : true;
        return result;
    }
    public static void WordsCounter(this string sentence)
    {
        string[] words = sentence.Split(" ");
        Console.WriteLine($"The total numbers of words of the sentence are: {words.Length}");
    }
    public static void CharacterCounter(this string sentence)
    {
        int numberOfWords = sentence.Replace(" ", "").Length;
        Console.WriteLine($"The total number of characters in sentences are: {numberOfWords}");
    }

}