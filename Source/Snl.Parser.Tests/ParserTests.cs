using System.Collections.Generic;
using NUnit.Framework;
using Snl.Parser;

namespace Snl.Tests
{
    [TestFixture]
    public class ParserTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        private SnlParser _parser;

        [Test]
        public void DocumentWithoutObjects()
        {
            _parser = new SnlParser();

           const string document = "<Snl>" +
                              "<Objects>" +
                              "</Objects>" +
                              "</Snl>";

            List<SnlObject> result = _parser.ParseObjects(document);

            Assert.AreEqual(new List<SnlObject>(), result);
        }

        [Test]
        public void WithOneSimpleObject()
        {
            const string document = "<Snl>" +
                        "<Objects>" +
                        "<Object Name=\"ObjectName\" Type = \"WebPage\">" +
                        "<Path>" + 
                        "http://bash.im/" +
                        "</Path>" + 
                        "</Object>" +
                        "</Objects>" +
                        "</Snl>";

            _parser = new SnlParser();

            var result = _parser.ParseObjects(document);


            var resultObject = new SnlObject()
            {
                Name = "ObjectName",
                Type = "WebPage",
                Path = "http://bash.im/"
            };

            Assert.AreEqual(1, result.Count);

            Assert.AreEqual(resultObject.Name, result[0].Name);
            Assert.AreEqual(resultObject.Type, result[0].Type);
            Assert.AreEqual(resultObject.Path, result[0].Path);


        }
    }
}