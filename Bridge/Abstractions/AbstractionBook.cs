using Bridge.Implementation;

namespace Bridge.Abstractions;

public class AbstractionBook
{
    protected Text text;

    public AbstractionBook(Text text)
    {
        this.text = text;
    }

    public virtual void Operation()
    {
        text.OperationText();
    }
}