namespace switch_case;
class Program
{
    static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        switch(month) // expression
        {
            case 1:
            Console.WriteLine("January.");
            break;
           
            case 2:
            Console.WriteLine("February");
            break;
            
            case 3:
            Console.WriteLine("April"); // the order doesn't matter
            break;
           
            case 4:
            Console.WriteLine("March");
            break;
            
            default:
            Console.WriteLine("It's not valid month"); //Default isn't necessary and you can put it different place. It hasn't be at the end.
            break;
           
        }

        //You can group case statement
        int monthGroup = DateTime.Now.Month;

        switch(monthGroup)
        {
        case 12:
        case 1:
        case 2:
            Console.WriteLine("It's winter.");
            break;

        case 3:
        case 4:
        case 5:
            Console.WriteLine("It's spring.");
            break;

        case 6:
        case 7:
        case 8:
            Console.WriteLine("It's summer.");
            break;
        case 9:
        case 10:
        case 11:
            Console.WriteLine("It's autumn.");
            break;
            //We didn't use default.
        }
        




    }
}
