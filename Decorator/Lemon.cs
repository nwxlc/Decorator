namespace Decorator;

public class Lemon : AdishCoffeeDecorator
{
    public Lemon(Coffee coffee) 
        :base(coffee, 1)
    {}

    public override void Print()
    {
        Console.WriteLine($"Цена лимона: {Price()}");
    }
}