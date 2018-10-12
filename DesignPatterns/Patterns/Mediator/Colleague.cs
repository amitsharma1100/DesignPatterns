namespace DesignPatterns.Patterns.Mediator
{
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
