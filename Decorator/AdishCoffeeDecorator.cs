using System.Net;

namespace Decorator;

public class AdishCoffeeDecorator : Coffee
{
    private Coffee _coffee;

    public AdishCoffeeDecorator(Coffee coffee, double adishPrice)
        : base(adishPrice)
    {
        ArgumentNullException.ThrowIfNull(coffee);

        _coffee = coffee;
    }

    public override double Price()
    {
        return _coffee.Price() + base.Price();
    }

    public override void Print()
    {
        _coffee.Print();
    }
}