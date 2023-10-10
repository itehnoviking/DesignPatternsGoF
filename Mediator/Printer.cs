using Mediator.Abstractions;

namespace Mediator;

public class Printer : Colleague
{
    public Printer(Abstractions.Mediator mediator) : base(mediator)
    {
    }

    public void MakeBook(string message)
    {
        string book = message + "Book";
        Console.WriteLine(this.GetType().Name + " produced " + book);

        _mediator.Send(book, this);
    }

}