using System;
interface ISet
{
    void AcceptDetails(int valOne, string valTwo);
}
interface IGet
{
    void Display();
}
class Employee: ISet
{
    int _empID;
    string _empName;
    public void AcceptDetails(int valOne,string valTwo)
    {
        _empID = valOne; 
        _empName = valTwo;
    }
    static void Main(string[] args)
    {
        Employee objEm = new Employee();
        objEm.AcceptDetails(10, "jack");
        IGet objGet = objEm as IGet;
        if(objGet != null)
        {
            objGet.Display();
        }
        else
        {
            Console.WriteLine("Invalid casring occurred");
        }
    }
}