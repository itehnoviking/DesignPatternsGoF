using System.Net.Http.Headers;

namespace Builder.Abstractions;

public abstract class Builder
{
    public abstract void BuildPartA();

    public abstract void BuildPartB();

    public abstract void BuildPartC();

    public abstract Product GetResult();
}