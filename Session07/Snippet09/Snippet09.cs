using System;
interface IMath
{
    void Area();
}
class Circle : IMath
{
    public const float PI = 3.14F;
    protected float Radius;
    protected double AreaOfCircle;
    public virtual void Area()
    {
        AreaOfCircle = (PI * Radius * Radius);
    }
}
class Sphere : Circle
{
    double _areaOfSphere;
    public override void Area()
    {
        base.Area();
        _areaOfSphere = (AreaOfCircle*4);
    }
    static void Main(string[] args)
    {
        Sphere objSph = new Sphere();
        objSph.Radius = 7;
        objSph.Area();
        Console.WriteLine("Area Of Sphere: {0:F2}", objSph._areaOfSphere);
    }
}
