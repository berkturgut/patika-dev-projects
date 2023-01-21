namespace error_handling;
class Program
{
    static void Main(string[] args)
    {
       
        //Scenario 1 : We don't know the error type but we want to show the error directly.
        try
        {
        Console.WriteLine("Please write a number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input number is : " + a);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error Message :" + ex.Message.ToString());
        }

        finally
        {
        Console.WriteLine("İşlem tamamlandı.");
        }

        //Scenario 2 : We know the possible error type and want to classify the error
        //null exception

        try
        {
            int a = int.Parse(null); //Argument exception
           // int b = int.Parse("test"); // Format exception
           // int c = int.Parse("-10000000000000000000000000000"); //Overflow exception
        }
        catch (ArgumentNullException ex)
        {
            
            Console.WriteLine("You create empty value ");
            Console.WriteLine(ex.Message.ToString());
        }

        catch(FormatException ex1)
        {
            Console.WriteLine("Data type is not correct");
            Console.WriteLine(ex1.Message.ToString());
        }

        catch(OverflowException ex2)
        {
            Console.WriteLine("You write too big or too small value");
            Console.WriteLine(ex2.Message.ToString());
        }

        finally
        {
            Console.WriteLine("İşlem sonlandırıldı.");
        }

    }
}
