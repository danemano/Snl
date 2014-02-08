namespace Snl.Engine
{
    public interface IExecutableObject
    {
        string Name { get; }

        string Execute();
    }
}