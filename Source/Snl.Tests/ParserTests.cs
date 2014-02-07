using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Snl.Engine;

namespace Snl.Tests
{
    [TestFixture]
    public class ParserTest
    {
        private Parser _parser;

        [SetUp]
        public void SetUp()
        {}

        [Test]
        public void DocumentWithoutObjects()
        {
            _parser = new Parser();

            string document = "";

            var result = _parser.ParseObjects(document);

            Assert.AreEqual(new List<SnlObject>(), result);
        }
    }
}
