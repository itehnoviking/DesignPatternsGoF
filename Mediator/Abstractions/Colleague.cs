namespace Mediator.Abstractions;

public abstract class Colleague
{
    protected Mediator _mediator;

    protected Colleague(Mediator mediator)
    {
        _mediator = mediator;
    }
}