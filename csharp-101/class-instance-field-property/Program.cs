namespace class_instance_field_property;
class Program
{
    static void Main(string[] args)
    {
        Employee employeeOne = new Employee();
        employeeOne.Name = "Berk";
        employeeOne.LastName = "Turgut";
        employeeOne.No = 123456;
        employeeOne.Department = "IT";

        employeeOne.GetEmployeeInfo();
        
        Console.WriteLine("************");

        Employee employeeTwo = new Employee();
        employeeTwo.Name = "Ali";
        employeeTwo.LastName = "Solmaz";
        employeeTwo.No = 123434;
        employeeTwo.Department = "Hr";

        employeeTwo.GetEmployeeInfo();
       
    }

    class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}",Name);
            Console.WriteLine("Last Name of the employee: {0}",LastName);
            Console.WriteLine("Id of the employee: {0}",No);
            Console.WriteLine("Department of the employee: {0}",Department);
        }
    }
}
