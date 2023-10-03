namespace Flyweight;

public class CodeCompletePdfBook : Flyweight
{
    private Flyweight _flyweight;

    public CodeCompletePdfBook(Flyweight flyweight)
    {
        _flyweight = flyweight;
    }

    public override void GetPrice(int price)
    {
        _flyweight.GetPrice(price);
    }
}