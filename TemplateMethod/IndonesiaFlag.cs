namespace TemplateMethod;

public class IndonesiaFlag : TwoColorFlag
{
    protected override void DrawTopPart()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(new string(' ', 7));
    }
    protected override void DrawBottomPart()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine(new string(' ', 7));
    }
}