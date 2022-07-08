interface IAnimal
{
    void Drink();
}
interface ICarnivorous
{
    void Eat();
}
interface IReptile : IAnimal, ICarnivorous
{
    void Habitat();
}
class Crocodile: IReptile
{
    public void Drink()
    {
        Console.WriteLine("drink fresh water");
    }
    public void Habitat()
    {
        Console.WriteLine("Can stay in water and land");
    }
    public void Eat()
    {
        Console.WriteLine("Eats flesh");
    }
    static void Main(string[] args)
    {
        Crocodile objCroc = new Crocodile();
        Console.WriteLine(objCroc.GetType().Name);
        objCroc.Habitat();
        objCroc.Eat();
        objCroc.Drink();
    }
}