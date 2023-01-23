namespace for_loop_break_continue;
class Program
{
    static void Main(string[] args)
    {
        //print odd numbers up to given number
        Console.WriteLine("Please input a number ");
        int inputNumber = int.Parse(Console.ReadLine());

        for(int i = 0; i <= inputNumber; i++)
        {
            if(i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }

        //print sum of the odd and even number separately
        int sumOdd = 0;
        int sumEven = 0;

        for(int i = 0; i <= 1000; i++)
        {
            if(i % 2 == 0)
            {
                sumEven += i; //sumEven = sumEven + 1;
            }

            else
            {
                sumOdd += i; //sumOdd = sumOdd + 1;
            }
        }
        Console.WriteLine("Sum of the even numbers are:" + sumEven);
        Console.WriteLine("Sum of the odd numbers are:" + sumOdd);


        //break and continue
        for(int i = 0; i < 10; i++)
        {
            if(i==4)
            {
                break; // It'll stop when it reaches 4. Only write 1-2-3;
                
                
            }
            Console.WriteLine(i);
        }

        for(int i = 0; i < 10; i++) // It'll skip 4 and write other numbers. It'll write 1-2-3-5-6-7-8-9
        {
            if(i==4)
            {
            continue;
            }
            Console.WriteLine(i);
        }

         for(;;) // Infinite loop. Doesn't recommend to use.
        {
            Console.WriteLine("keep going forever :)");
            
        }
        
    }
}
