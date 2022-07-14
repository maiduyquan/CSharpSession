abstract class Product
{
    int[] ID = new int[5];
    string[] Name = new string[5];
    int[] Price = new int[5];
    public void product(int id,string name,int price)
    {
        ID[5] = { 1,2,3,4,5};
        Name[5] = { "A","B","C","D","E"};
        Price[5] = { 20000,30000,40000,50000,60000};
    }
    public abstract double computeTax();
}
class Book : Product
{
    public override double computeTax()
    {
        Console.WriteLine("Tax of book: " + Product.Price * 5/100);
    }
}
class Phone : Product
{
    public override double computeTax()
    {
        Console.WriteLine("Tax of Phone: " + Product.Price * 10/100);
    }
}
class Test : Product
{
    public static void Main(string[] args)
    {
        Product product = new Product();
        product = Product.product;
        Console.WriteLine(product.ID);
        Console.WriteLine(product.Name);
        product.computeTax();
        Console.WriteLine(product.computeTax());
    }
}
