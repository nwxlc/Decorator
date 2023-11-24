namespace Decorator;

public class Cappuccino : Coffee
{
    public Cappuccino()
        : base(25)
    { }
    
    public override void Print()
    {
        Console.WriteLine($"Цена капучино: {Price()}");
    }
}