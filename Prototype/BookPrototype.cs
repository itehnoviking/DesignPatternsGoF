namespace Prototype;

public class BookPrototype
{
    public BookPrototype Clone()
    {
        return this.MemberwiseClone() as BookPrototype;
    }
}