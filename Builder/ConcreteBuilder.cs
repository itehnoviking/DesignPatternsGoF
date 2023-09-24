namespace Builder;

public class ConcreteBuilder : Abstractions.Builder
{
    Product product = new Product();

    public override void BuildPartA()
    {
        product.Add("Pages");
    }

    public override void BuildPartB()
    {
        product.Add("Text");
    }

    public override void BuildPartC()
    {
        product.Add("Cover");
    }

    public override Product GetResult()
    {
        return product;
    }
}