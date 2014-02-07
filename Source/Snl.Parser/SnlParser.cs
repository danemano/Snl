using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Snl.Parser
{
    public class SnlParser
    {
        public List<SnlObject> ParseObjects(string document)
        {
            try
            {
                var xdocument = XDocument.Parse(document);
                var rules =
                    xdocument.Element("Snl")
                             .Element("Objects")
                             .Elements("Object").Select(ParseObject);

                return rules.ToList();
            }
            catch (Exception)
            {
                return new List<SnlObject>(0);
            }
        }

        private SnlObject ParseObject(XElement xElement)
        {
            var snlObject = new SnlObject
            {
                Name = (string) xElement.Attribute("Name"),
                Path = (string) xElement.Element("Path"),
                Type = (string) xElement.Attribute("Type")
            };

            return snlObject;
        }
    }
}
