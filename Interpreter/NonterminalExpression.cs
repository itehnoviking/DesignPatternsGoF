namespace Interpreter;

public class NonterminalExpression : AbstractExpression
{
    private AbstractExpression nonterminalExpression;
    private AbstractExpression terminalExpression;
    public override void Interpret(Context context)
    {
        if (context.Position < context.Source.Length)
        {
            terminalExpression = new TerminalExpression();
            terminalExpression.Interpret(context);
            context.Position++;

            if (context.Result)
            {
                nonterminalExpression = new NonterminalExpression();
                nonterminalExpression.Interpret(context);
            }
        }
    }
}