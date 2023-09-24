namespace AbstractFactory;

public class ClearCodeFactory : AbstractFactory
{
    public override AbstractPages CreatePages()
    {
        return new ClearCodePages();
    }

    public override AbstractCover CreateCover()
    {
        return new ClearCodeCover();
    }

    public override AbstractText CreateText()
    {
        return new ClearCodeText();
    }
}