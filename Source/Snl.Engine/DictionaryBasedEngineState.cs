using System.Collections.Generic;
using System.Linq;

namespace Snl.Engine
{
    class DictionaryBasedEngineState : IEngineState
    {
        readonly List<ISnlObject> _objects = new List<ISnlObject>();
        public string GetValue(string name)
        {
            var obj = _objects.Single(t => t.Name == name);
            return obj.GetValue();
        }
    }
}