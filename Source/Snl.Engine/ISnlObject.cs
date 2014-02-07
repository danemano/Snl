namespace Snl.Engine
{
    public interface ISnlObject
    {
        string Name { get; }

        string GetValue();
    }
}