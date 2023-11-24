namespace Decorator;

public class Discount : AdishCoffeeDecorator
{
    public Discount(Coffee coffee)
        :base(coffee, -(coffee.Price() * -0.1))
    {}

    public virtual void Print()
    {
        Console.WriteLine($"Цена со скидкой: {Price()}");
    }
}