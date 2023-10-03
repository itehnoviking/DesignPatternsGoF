namespace Flyweight;

public class CodeCompleteOriginal : Flyweight
{
    public override void GetPrice(int price)
    {
        Console.WriteLine($"Price: {price}");
    }
}