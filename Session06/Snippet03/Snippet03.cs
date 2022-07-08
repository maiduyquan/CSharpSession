class Animal
{
    protected String Food;
    protected String Activity;
}
class Cat : Animal
{
    static void Main(String[] args)
    {
        Cat objCat = new Cat();
        objCat.Food = "Mouse";
        objCat.Activity = "Laze around";
        Console.WriteLine("The Cat loves to eat " + objCat.Food + ".");
        Console.WriteLine("the Cat loves to " + objCat.Activity + ".");
    }
}