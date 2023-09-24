namespace AbstractFactory;

public class CodeCompleteCover : AbstractCover
{
    public override void Interact(AbstractPages pages, AbstractText text)
    {
        Console.WriteLine(this + " interact with " + pages + " and " + text);
    }
}