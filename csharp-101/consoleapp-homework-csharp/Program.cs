namespace consoleapp_homework_csharp;
class Program
{
    static void Main(string[] args)
    {
        //User History
//     1 ) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
//     Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//     Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

// 2) Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


// 3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
Console.WriteLine("**** Multi Purpose Calculator Console App**** \n");
Console.WriteLine("*************************");
Console.WriteLine("1. Find even numbers");
Console.WriteLine("2. Find dividend");
Console.WriteLine("3. Find total number of words and characters in a sentence.");
Console.WriteLine("*************************");


for(int i = 0;;i++)
{
    Console.Write("Please select an action using sequence number :");
    bool isActionNumber = byte.TryParse(Console.ReadLine(),out byte actionNumber);
    
    if(!isActionNumber || actionNumber < 0 || actionNumber > 3)
        {
        

        for(int j = 0;;j++)
        {
            Console.WriteLine("İnput error. If you want to try again write 'Y' for yes and 'N' for no");
            string yesNoAnswer = Console.ReadLine();

            if(yesNoAnswer == "Y")
            break;
        
            else if(yesNoAnswer == "N")
            {
            Console.WriteLine("Program will shut down.");
            
            }

            else
            {
            Console.WriteLine("İnput value error.");
            continue;
            }
        }

        continue;
       
        }
       
    else
    {

        switch(actionNumber)
        {
            case 1 : 
            myMethods.FindEven();
            break;
            case 2 :
            Console.WriteLine("action 2");
            break;
            case 3 : 
            Console.WriteLine("action 3");
            break;
        }

        break;

    }
        
}

    }
}

public static class myMethods
{

public static void FindEven()
{
    Console.Write("Please enter a number: ");
    
    bool islengtNumbers = int.TryParse(Console.ReadLine(),out int lengthNumber );
    
        
        if(islengtNumbers)
         {
        Console.WriteLine($"Please enter {lengthNumber} different numbers");
         }
        
        else
        {
         Console.WriteLine("Input error. Program will shut down");
           
        }
   
    




}




}
