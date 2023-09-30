namespace Adapter;

public class Adapter : Target
{
    private  Adaptee adaptee;

    public Adapter()
    {
        this.adaptee = new Adaptee();
    }

    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}