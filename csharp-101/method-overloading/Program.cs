namespace method_overloading;
class Program
{
    static void Main(string[] args)
    {
        //using out parameter
            string stringNumber = "999";
           
            //using out with "TryParse" metod.
            bool result = int.TryParse(stringNumber, out int intNumber); // try parse returns 2 value. Status for try process(true - false) and the value that parsed.
            
            
                if(result)
                {
                    Console.WriteLine("Success!! Number parsed");
                    Console.WriteLine("The number is " + intNumber);
                } 

                else
                {
                    Console.WriteLine("Error! Input type is not valid.");
                }

            //using "out" with custom method 
            MyMethods instance = new MyMethods();
            instance.Sum(12,10,out int totalNumber);
            Console.WriteLine(totalNumber);

        //using method overloading
        
        //metot signature = metot name + number of parameters + parameter type 
        //if these three attributes are the same we say this method equal.
        //Access identifier and return type is not important for metot signature.
            instance.PrintOnScreen("Berk " , "Turgut");
        
    }

class MyMethods
    {
        //using out with custom method 
        public void Sum(int a, int b, out int sumUp)// we don't need to create sumUp variables before if we use out.
        {
            sumUp = a + b;
        }

        //metot overloading
        public void PrintOnScreen(string stringData) //main method
        {
            Console.WriteLine(stringData);
        }

        public void PrintOnScreen(int intData) //method overloading
        {
            Console.WriteLine(intData);
        }

        public void PrintOnScreen(string stringData, string stringData2)
        {
            Console.WriteLine(stringData + stringData2);
        }

    }
}
