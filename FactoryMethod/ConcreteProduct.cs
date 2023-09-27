using FactoryMethod.Abstractions;

namespace FactoryMethod;

public class ConcreteProduct : Product
{
    public ConcreteProduct()
    {
        Console.WriteLine("Code Complete Book is created");
    }
}