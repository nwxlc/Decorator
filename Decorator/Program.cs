using Decorator;

Coffee latte = new Latte();

latte = new Syrop(latte);
latte = new Discount(latte);

Console.WriteLine($"{latte.OrderLine()}");