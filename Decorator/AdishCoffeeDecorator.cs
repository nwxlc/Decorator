using System.Net;

namespace Decorator;

public class AdishCoffeeDecorator : Coffee
{
    private Coffee _coffee;
    

    public AdishCoffeeDecorator(Coffee coffee, double adishPrice, string adishExtra)
        : base(adishPrice, adishExtra)
    {
        ArgumentNullException.ThrowIfNull(coffee);

        _coffee = coffee;
    }

    public override double Price()
    {
        return _coffee.Price() + base.Price();
    }
    
}