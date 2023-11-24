using System.Runtime.InteropServices;

namespace Decorator;

public abstract class Coffee
{
    private double _price;

    public Coffee(double price)
    {
        if (price < 0)
        {
            throw new ArgumentOutOfRangeException("Ошибка ввода данных");
        }

        _price = price;
    }
    
    public virtual double Price()
    {
        return _price;
    }

    public virtual void Print()
    {
        Console.Write($"Цена кофе: {Price()}");
    }
}