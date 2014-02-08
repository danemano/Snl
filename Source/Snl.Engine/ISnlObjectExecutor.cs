using Snl.Parser;

namespace Snl.Engine
{
    public interface ISnlObjectExecutor
    {
        string Execute(SnlObject snlObject);
    }

    class SnlObjectExecutor : ISnlObjectExecutor
    {
        private Engine _engine;

        public string Execute(SnlObject snlObject)
        {
            throw new System.NotImplementedException();
        }
    }
}