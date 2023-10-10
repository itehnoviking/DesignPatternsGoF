using Iterator.Interfaces;

namespace Iterator;

public class Cashier : IEnumerator
{
    private Bank _bank;
    private int current = -1;

    public Cashier(Bank enumerable)
    {
        _bank = enumerable;
    }


    //реализация интерфейса IEnumerator
    public bool MoveNext()
    {
        if (current < _bank.Count - 1)
        {
            current++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        current = -1;
    }

    public object Current
    {
        get { return _bank[current]; }
    }
}