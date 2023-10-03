namespace Decorator;

public class BookPagesDecorator : Decorator
{
    public void AddedBehavior()
    {
        Console.WriteLine("Book Pages");
    }

    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
    }
}