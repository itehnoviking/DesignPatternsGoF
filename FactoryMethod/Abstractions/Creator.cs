using System.Net.Http.Headers;

namespace FactoryMethod.Abstractions;

public abstract class Creator
{
    public Product product;
    public abstract Product FactoryMethod();
}