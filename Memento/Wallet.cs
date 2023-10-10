namespace Memento;

public class Wallet
{
    public string Сontents
    {
        get;
        private set;
    }
    public Wallet(string сontents)
    {
        this.Сontents = сontents;
    }
}