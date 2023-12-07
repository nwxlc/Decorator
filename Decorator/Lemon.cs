namespace Decorator;

public class Lemon : AdishCoffeeDecorator
{
    public Lemon(Coffee coffee) 
        :base(coffee, 1, "+ лимон ")
    {}
    
    
}