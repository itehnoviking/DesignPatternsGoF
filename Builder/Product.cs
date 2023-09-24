using System.Collections;

namespace Builder;

public class Product
{
    ArrayList parts = new ArrayList();

    public void Add(string part)
    {
        parts.Add(part);
    }

    public void Show()
    {
        foreach (var part in parts)
        {
            Console.WriteLine(part);
        }
    }
}