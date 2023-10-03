namespace Decorator;

public class ConcreteBook : Component
{
    public override void Operation()
    {
        Console.WriteLine("Book");
    }
}