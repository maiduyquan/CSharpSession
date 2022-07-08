class Student
{
    string _studentName = "james";
    string _address = "Califonia";
    public virtual void PrintDetails()
    {
        Console.WriteLine("Studnet Name: " + _studentName);
        Console.WriteLine("Address: " + _address);
    }
}
class Grade : Student
{
    string _class = "Four";
    float _percent = 71.25F;
    public override void PrintDetails()
    {
        Console.WriteLine("Class: " + _class);
        Console.WriteLine("Percentage: " + _percent);
    }
    static void Main(string[] args)
    {
        Student objStudent = new Student();
        Grade objGrade = new Grade();
        objStudent.PrintDetails();
        objGrade.PrintDetails();
    }
}
