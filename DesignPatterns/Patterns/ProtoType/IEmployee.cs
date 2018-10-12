namespace DesignPatterns.Patterns.ProtoType
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
