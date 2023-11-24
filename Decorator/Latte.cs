namespace Decorator;

public class Latte : Coffee
{
    public Latte()
        : base(20)
    { }

    public override void Print()
    {
        Console.WriteLine($"Цена латте: {Price()}");
    }
}