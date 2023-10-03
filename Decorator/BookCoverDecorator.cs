namespace Decorator;

public class BookCoverDecorator : Decorator
{
    private string addedState = "Book Cover";

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine(addedState);
    }
}