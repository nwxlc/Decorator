using System.Net;

namespace Decorator;

public class Syrop : AdishCoffeeDecorator
{
    public Syrop(Coffee coffee)
        :base(coffee, 3, "+ сироп ")
    {}
}