namespace static_class_members;
class Program
{
    static void Main(string[] args)
    {
        //When you access this static member static constructor start one time and thats enough.
        
        Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);

        Employee employee = new Employee("Deniz", "Malcom", "IT");
        Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);
        Employee employeeTwo = new Employee("Derin", "Malça", "IT");
        Employee employeeThree = new Employee("Ahmet", "Balca", "IT");
        Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);
    
        //You can access this class only using this syntax. New keyword doesn't work.
        Console.WriteLine("Sum of two numbers are : {0}", MathOperations.Sum(100,200));
        Console.WriteLine("Extraction of two numbers are : {0}", MathOperations.Subtrac(200,50));

    }
}

class Employee
{
    private static int employeeNumber;

    public static int EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }

    private string Name;
    private string LastName;
    private string Department;

    static Employee()
    {
        employeeNumber = 0;
    }

    public Employee(string name, string lastName, string department)
    {
        this.Name = name;
        this.LastName = lastName;
        this.Department = department;
        employeeNumber ++;
    }

}

static class MathOperations
{
    public static long Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static long Subtrac(int num1, int num2)
    {
        return num1 - num2;
    }
}
    
