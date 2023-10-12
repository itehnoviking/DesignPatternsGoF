namespace State;

public class PenOpen : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("Pen is open");
        context.State = new PenClosed();
        
    }
}
