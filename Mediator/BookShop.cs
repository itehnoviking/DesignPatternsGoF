using Mediator.Abstractions;

namespace Mediator;

public class BookShop : Colleague
{
    public BookShop(Abstractions.Mediator mediator) : base(mediator)
    {
    }

    public void SellBook(string message)
    {
        Console.WriteLine(this.GetType().Name + " sold " + message);
    }
}