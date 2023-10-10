namespace Observer;

// Конкретный издатель.
public class ConcreteSubject : Subject
{
    public override string State { get; set; }
    public override void Notify()
    {
        observers.Invoke(State);
    }
}