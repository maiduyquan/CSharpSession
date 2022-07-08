using System;
interface ICalculate
{
    double Area();
}
class Rectangle : ICalculate
{
    float _length;
    float _Breadth;
    public Rectangle(float length, float breadth)
    {
        _length = valOne;
        _Breadth = valTwo;
    }
    public double Area()
    {
        return _length*_Breadth;
    }
    static void Main(string[] args)
    {
        Rectangle objRec = new Rectangle(10.2F, 20.3F);
        if(objRec is ICalculate)
        {
            Console.WriteLine("Area Of Rectangle: {0:F2}",objRec.Area());
        }
        else
        {
            Console.WriteLine("Interface mehtod not implemented"
        }
    }
}
