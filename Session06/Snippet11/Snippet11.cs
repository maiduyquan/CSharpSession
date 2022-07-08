class ITSystem
{
    public virtual void Print()
    {
        Console.WriteLine("The system should be handed carefully");
    }
}
class CompanySystem : ITSystem
{
    public sealed override void Print()
    {
        Console.WriteLine("The System information is confidential");
        Console.WriteLine("This information should not be overridden");
    }
}
class SealedSystem : CompanySystem
{
    public override void Print()
    {
        Console.WriteLine("This statment won't get executed");
    }
    static void Main(string[] args)
    {
        SealedSystem objSealed = new SealedSystem();
        objSealed.Print();
    }
}