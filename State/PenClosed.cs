namespace State;

public class PenClosed : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("Pen is closed");
        context.State = new PenOpen();
    }
}