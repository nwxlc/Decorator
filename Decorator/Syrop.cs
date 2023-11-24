using System.Net;

namespace Decorator;

public class Syrop : AdishCoffeeDecorator
{
    public Syrop(Coffee coffee)
        :base(coffee, 3)
    {}
    
    public override void Print()
    {
        Console.WriteLine($"Цена сиропа: {Price()}");
    }
}