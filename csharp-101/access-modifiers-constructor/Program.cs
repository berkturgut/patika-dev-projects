namespace access_modifiers_constructor;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****Employee One****");
        //Using constructor with parameters.
        Employee employeeOne = new Employee("Dilek","Bohça",10,"IT");
        employeeOne.GetEmployeeInfo();
        
        Console.WriteLine("************");
         
        Console.WriteLine("****Employee Two****");
        Employee employeeTwo = new Employee();
        employeeTwo.Name = "Ali";
        employeeTwo.LastName = "Solmaz";
        employeeTwo.No = 123434;
        employeeTwo.Department = "Hr";

        employeeTwo.GetEmployeeInfo();

         Console.WriteLine("****Employee Three****");
        //Using overload constructor with parameters. 
        Employee employeeThree = new Employee("Fatih","Tarhan");
        employeeThree.GetEmployeeInfo();
        //output only contains name and lastname value. Other parameters didn't set and default constructor will execute also and return null or 0 or false.
        
    }
}


class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        //constructor method
        public Employee(string name, string lastName, int no, string department)
        {
            //Name = name; this syntax should be used but "this" express class variable.
            this.Name = name;
            this.LastName = lastName;
            this.No = no;
            this.Department = department;
            
        }
        
        public Employee(){}
        
       //We can overload constructor methods. We create empty method for instance with no parameters.
       public Employee(string name, string lastName)
        {
            //Name = name; this syntax should be used but "this" express class variable.
            this.Name = name;
            this.LastName = lastName;
                
        }

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}",Name);
            Console.WriteLine("Last Name of the employee: {0}",LastName);
            Console.WriteLine("Id of the employee: {0}",No);
            Console.WriteLine("Department of the employee: {0}",Department);
        }
    }
