using System.Runtime.InteropServices;

namespace Decorator;

public abstract class Coffee
{
    private string _description;

    public Coffee(string description)
    {
        _description = description;
    }

    public virtual string GetDescription()
    {
        return _description;
    }

    public abstract double Price();
}