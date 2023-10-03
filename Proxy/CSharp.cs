namespace Proxy;

public class CSharp : ICompile
{
    private ICompile _compilator;

    public CSharp(ICompile compilator)
    {
        _compilator = compilator;
    }

    public void Compilation()
    {
        _compilator.Compilation();
    }
}