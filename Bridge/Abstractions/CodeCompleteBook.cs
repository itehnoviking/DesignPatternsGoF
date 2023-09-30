using Bridge.Implementation;

namespace Bridge.Abstractions;

public class TechBook : AbstractionBook
{
    public TechBook(Text text) : base(text)
    {
    }

    public override void Operation()
    {
        base.Operation();
    }
}