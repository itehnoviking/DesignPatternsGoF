using Mediator.Abstractions;

namespace Mediator;

public class PaperFactory : Colleague
{
    public PaperFactory(Abstractions.Mediator mediator) : base(mediator)
    {
    }

    public void MakePaper()
    {
        string paper = "Paper";
        Console.WriteLine(this.GetType().Name + " produced " + paper);

        _mediator.Send(paper, this);
    }
}