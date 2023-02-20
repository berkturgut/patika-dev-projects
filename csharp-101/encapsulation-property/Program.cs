namespace encapsulation_property;
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Berk";
        student.LastName = "Turgut";
        student.StudentNo = 611;
        student.Grade = 3;

        student.GetStudentInfo();

        student.UpGrade();
        student.GetStudentInfo();

        Student studentTwo = new Student("Ali", "Deniz",256,1);
        studentTwo.GetStudentInfo();
        studentTwo.DownGrade();
        studentTwo.DownGrade();
        studentTwo.GetStudentInfo();
    }
}

class Student
{
    //field declaration. 
    private string name;
    private string lastName;
    private int studentNo;
    private int grade;

    public string Name {
         get => name; 
         set => name = value; }
    
    //equals to :
    // public string Name
    // {
    //     get{return name;} //get method
    //     set{name = value;} // set method
    // }

    public string LastName { get => lastName; set => lastName = value; }
    public int StudentNo { get => studentNo; set => studentNo = value; }
    public int Grade 
    {   get => grade; 
        set 
        {  //We add basic negative number logic. If we add this to the method it can be hack but prop is secure enough.
            if(value < 1)
            {
                Console.WriteLine("Grade can't be 0 or negative.");
                grade = 1;
            } 
            else
                grade = value;   
        }
    }

    public Student(string name, string lastName, int studentNo = 0, int room = 0)
    {
        Name = name;
        LastName = lastName;
        StudentNo = studentNo;
        Grade = grade;
    }

    public Student(){}

    public void GetStudentInfo()
    {
        Console.WriteLine("****Student Informations****");
        Console.WriteLine("Student Name   : {0}",this.Name);
        Console.WriteLine("Student LastName   : {0}",this.LastName);
        Console.WriteLine("Student No   : {0}",this.StudentNo);
        Console.WriteLine("Student Grade   : {0}",this.Grade);
    }

    public void DownGrade()
    {
        this.Grade = this.Grade - 1;
        //We shouldn't add logic for negative numbers. It local and we need to global logic so we will use this logic inside of the property.
    }

    public void UpGrade()
    {
        this.Grade = this.Grade + 1;
    }





}
