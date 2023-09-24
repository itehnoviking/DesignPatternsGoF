namespace AbstractFactory;

public abstract class AbstractFactory
{
    public abstract AbstractPages CreatePages();
    public abstract AbstractCover CreateCover();
    public abstract AbstractText CreateText();
}