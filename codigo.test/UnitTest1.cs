using NUnit.Framework;
using codigo.prodiccion;

namespace codigo.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestHttp()
        {
            clsUrlToStringParser urlparser = new clsUrlToStringParser();
            var urlParsed = urlparser.parseUrl("http://localhost:8000/search?q=text#hello");
            string result = urlParsed["Scheme"];
            Assert.AreEqual("http", result);
        }
        
        [Test]
        public void TestHost()
        {
            clsUrlToStringParser urlparser = new clsUrlToStringParser();
            var urlParsed = urlparser.parseUrl("http://localhost:8000/search?q=text#hello");
            string result = urlParsed["Host"];
            Assert.AreEqual("localhost", result);
        }
        
        [Test]
        public void TestPort()
        {
            clsUrlToStringParser urlparser = new clsUrlToStringParser();
            var urlParsed = urlparser.parseUrl("http://localhost:8000/search?q=text#hello");
            string result = urlParsed["Port"];
            Assert.AreEqual("8000", result);
        }
        
        [Test]
        public void TestPath()
        {
            clsUrlToStringParser urlparser = new clsUrlToStringParser();
            var urlParsed = urlparser.parseUrl("http://localhost:8000/search?q=text#hello");
            string result = urlParsed["Path"];
            Assert.AreEqual("/search", result);
        }
        
        [Test]
        public void TestQuery()
        {
            clsUrlToStringParser urlparser = new clsUrlToStringParser();
            var urlParsed = urlparser.parseUrl("http://localhost:8000/search?q=text#hello");
            string result = urlParsed["Query"];
            Assert.AreEqual("q=text", result);
        }
        
        [Test]
        public void TestFrag()
        {
            clsUrlToStringParser urlparser = new clsUrlToStringParser();
            var urlParsed = urlparser.parseUrl("http://localhost:8000/search?q=text#hello");
            string result = urlParsed["Fragment"];
            Assert.AreEqual("hello", result);
        }
    }
}