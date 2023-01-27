namespace method_declaration;
class Program
{
    static void Main(string[] args)
    {
        // Method Structure

        /*
        Access Modifiers return type methodName(argument/parameter)
        {
            //operation
        }
        */

        // global variables
        int a = 2;
        int b = 3;
        
        //basic operation without method
        Console.WriteLine("Basic sum is: " + (a + b));

        //sum operation with sum method
        int result = Sum(a,b);
        Console.WriteLine("Addition with sum method: " + result); 
        
        static int Sum(int val1, int val2)
        {
            return(val1 + val2);
        }

        //write operation with printOnScreen method
        MethodsSample sample = new MethodsSample();
        sample.PrintOnScreen(Convert.ToString(result)); 
        
        Console.WriteLine("****Ref Type Variables Samples****");
        //value type parameters samples : original values doesn't change. Method instance new variable and global var doesn't change.
        sample.PrintOnScreen(Convert.ToString(a+b)); //Original and global variables;
        int result2 = sample.IncreaseAndSum(a,b);// copy of original values;
        sample.PrintOnScreen(Convert.ToString(result2));
        
        
        Console.WriteLine("****Ref Type Variables Samples****");
        int result3 = sample.IncreaseAndSumRefs(ref a,ref b);// point original values and change the global variables.;
        sample.PrintOnScreen(Convert.ToString(result3));
        sample.PrintOnScreen(Convert.ToString(a+b));
    }

    class MethodsSample
    {
        public void PrintOnScreen(string data)
        {
            Console.WriteLine("Print sum with PrintOnScreen method: " + data);
        }

        public int IncreaseAndSum(int val1, int val2)
        {
            val1 += 1;
            val2 += 2;
            return val1 + val2;
        }

        public int IncreaseAndSumRefs( ref int val1, ref int val2)
        {
            val1 += 1;
            val2 += 2;
            return val1 + val2;
        }
    }
}
