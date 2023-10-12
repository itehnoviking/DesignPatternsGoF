namespace Strategy;

public class ContextStrategy
{
    Strategy strategy;

    int[] array = { 3, 5, 1, 2, 4 };
    public ContextStrategy(Strategy strategy)
    {
        this.strategy = strategy;
    }
    public void Sort()
    {
        strategy.Sort(ref array);
    }
    public void PrintArray()
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}
