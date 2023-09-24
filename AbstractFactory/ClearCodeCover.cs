namespace AbstractFactory;

public class ClearCodeCover : AbstractCover
{
    public override void Interact(AbstractPages pages, AbstractText text)
    {
        Console.WriteLine(this + " interact with " + pages + " and " + text);
    }
}