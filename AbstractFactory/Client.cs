namespace AbstractFactory;

public class Client
{
    private AbstractPages pages;
    private AbstractCover cover;
    private AbstractText text;

    public Client(AbstractFactory factory)
    {
        text = factory.CreateText();
        pages = factory.CreatePages();
        cover = factory.CreateCover();
    }

    public void Run()
    {
        cover.Interact(pages, text);
    }
}