using NUnit.Framework;
using ParserTenders;

namespace TestProjectTenders
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestPrice()
        {
            var d = 20979288.57m;
            var m = UtilsFromParsing.ParsePrice("20979288,57");
            Assert.AreEqual(d, m);
        }
    }
}