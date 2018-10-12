namespace DesignPatterns.Patterns.Mediator
{
    public interface IMediator
    {
        void SendMessage(Colleague caller, string msg);
    }
}
