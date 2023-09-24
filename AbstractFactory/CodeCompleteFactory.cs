namespace AbstractFactory;

public class CodeCompleteFactory : AbstractFactory
{
    public override AbstractPages CreatePages()
    {
        return new CodeCompletePages();
    }

    public override AbstractCover CreateCover()
    {
        return new CodeCompleteCover();
    }

    public override AbstractText CreateText()
    {
        return new CodeCompleteText();
    }
}