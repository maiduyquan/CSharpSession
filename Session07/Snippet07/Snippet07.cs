interface ITerrestrialAnimal
{
    string Eat();
}
interface IMarineAnimal
{
    string Eat();
}
class Crocodile : ITerrestrialAnimal, IMarineAnimal
{
    string ITerrestrialAnimal.Eat()
    {
        string terCroc = "Crocodile eats orther animals";
        return terCroc;
    }
    string IMarineAnimal.Eat()
    {
        string MarCroc = "Crocodile eats fish and marine animals";
        return MarCroc;
    }
    public string EatTerrestrial()
    {
        ITerrestrialAnimal objTerAnimal;
        objTerAnimal = this;
        return objTerAnimal.Eat();
    }
    public string EatMarina()
    {
        IMarineAnimal objMarAnimal;
        objMarAnimal = this;
        return objMarAnimal.Eat();
    }
    public static void Main(string[] args)
    {
        Crocodile objCrocodile = new Crocodile();
        string terCroc = objCrocodile.EatTerrestrial();
        Console.WriteLine(terCroc);
        string marCroc = objCrocodile.EatMarina();
        Console.WriteLine(marCroc);
    }
}
