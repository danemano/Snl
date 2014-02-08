using System.Collections.Generic;
using System.Linq;

namespace Snl.Engine
{
    class DictionaryBasedEngineState : IEngineState
    {
        readonly List<IExecutableObject> _objects = new List<IExecutableObject>();
        public string GetValue(string name)
        {
            var obj = _objects.Single(t => t.Name == name);
            return obj.Execute();
        }
    }
}