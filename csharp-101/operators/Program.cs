namespace operators;
class Program
{
    static void Main(string[] args)
    {
        /* 
         OPERATORS 

         1 ) Assignment Operators 
         2 ) Compound Assignment Operators
         3 ) Logical Operators
         4 ) Relational Operators
         5 ) Arithmetic Operators
        */

        // Assignment Operators ( = )
        
        int x = 3;
        int t = 2;
        t = t + 2;
       
        Console.WriteLine(x + " and " + t + " created with assign operator");
        

        //Compound Assignment Operators (+= , /= , *= , -=)
        
        x += 3;
        Console.WriteLine(x + " : We added 3 to the x variables");
       
        x /= 6;
        Console.WriteLine(x + " : We divided the variable x into 6 ");
       
        t *= 3;
        Console.WriteLine(x + " : We multiplied the variable ali by 6");

        //Logical Operators (||, &&, !)

        bool isSuccess = true;
        bool isCompleted = false;

        if(isSuccess && isCompleted)
        Console.WriteLine("Perfect!");

        if(isSuccess || isCompleted)
        Console.WriteLine("Great!");

        if(isSuccess && !isCompleted)
        Console.WriteLine("Fine!");

        //Relational Operators (<, >, <=, >=, ==, !=)

        int a = 3;
        int b = 4;

        bool result = a < b;
        Console.WriteLine(result);

        result = a > b;
        Console.WriteLine(result);

        result = a <= b;
        Console.WriteLine(result);

        result = a >= b;
        Console.WriteLine(result);

        result = a == b;
        Console.WriteLine(result);

        result = a != b;
        Console.WriteLine(result);
        
        //Arithmetic Operators (/, *, +, ++, %)

        int div1 = 8;
        int div2 = 4;
        int mul1 = 3;
        int mul2 = 5;
        int sum1 = 1;
        int sum2 = 6;
        int add1 = 9;
        int mod1 = 10;


        int aritResultDivide = div1 / div2;
        Console.WriteLine("Result of divison is " + aritResultDivide);

        int aritResultMultiply = mul1 * mul2;
        Console.WriteLine("Result of multiplication is " + aritResultMultiply);

        int aritResultSum = sum1 + sum2;
        Console.WriteLine("Result of addition is " + aritResultSum);

        int aritResultIncrement = ++add1;
        Console.WriteLine("increase the value of the number by one, the result is: " + aritResultIncrement);

        int aritResultRemainder = mod1 % 3;
        Console.WriteLine("Remainder by division by 3 is: " + aritResultRemainder);

        

        



    }
}
