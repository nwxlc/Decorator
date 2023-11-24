namespace Decorator;

public class Sugar : AdishCoffeeDecorator
{
    public Sugar(Coffee coffee)
        :base(coffee, 2)
    {}
    
    public override void Print()
    {
        Console.WriteLine($"Цена сахара: {Price()}");
    }
}