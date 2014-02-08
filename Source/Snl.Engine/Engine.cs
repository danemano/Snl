using System.Collections.Generic;
using System.Linq;
using Snl.Parser;

namespace Snl.Engine
{
    public class Engine
    {
        private ISnlObjectExecutor _objectExecutor;
        private HashSet<SnlObject> _objects;

        public Engine(HashSet<SnlObject> objects, ISnlObjectExecutor objectExecutor)
        {
            _objects = objects;
            _objectExecutor = objectExecutor;
        }

        public string GetObjectValue(string objectName)
        {
            var obj = _objects.Single(t => t.Name == objectName);
            return _objectExecutor.Execute(obj);
        }
    }
}