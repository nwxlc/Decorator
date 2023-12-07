using System.Net;

namespace Decorator;

public class AdishCoffeeDecorator : Coffee
{
    private Coffee _coffee;
    private double _extraPrice;

    public AdishCoffeeDecorator(Coffee coffee, double extraPrice, string descriptionAddition)
        : base(coffee.GetDescription() + descriptionAddition)
    {
        _coffee = coffee;
        _extraPrice = extraPrice;
    }

    public override double Price()
    {
        return _coffee.Price() + _extraPrice;
    }
}