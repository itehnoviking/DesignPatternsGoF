namespace Flyweight;

public class CodeCompleteBook : Flyweight
{
    private Flyweight _flyweight;

    public CodeCompleteBook(Flyweight flyweight)
    {
        _flyweight = flyweight;
    }

    public override void GetPrice(int price)
    {
        _flyweight.GetPrice(price);
    }
}