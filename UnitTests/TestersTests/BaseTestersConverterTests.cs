using Testers;
using NUnit.Framework;
using System.Xml.Linq;

namespace UnitTests.TestersTests
{
    [TestFixture]
    public class BaseTestersConverterTests
    {
        [SetUp]
        public void Setup()
        {
            tester = new TesterBase();
            tester.Name = "Robert Snyder";
            tester.TesterId = 1;
            tester.PrivilegeLevel = Privileges.Administrator;
        }

        [Test]
        public void TestXMLConversions()
        {
            var converter = tester.GetClassConverter("XML");
            var actual = XElement.Parse(converter.GetAddStatement());
            var xml = "<TesterBase><TesterId>1</TesterId><Name>Robert Snyder</Name><PrivilegeLevel>Administrator</PrivilegeLevel></TesterBase>";
            XElement expected = XElement.Parse(xml);
            Assert.IsTrue(XElement.DeepEquals(expected, actual));
        }
        TesterBase tester;
    }
}
