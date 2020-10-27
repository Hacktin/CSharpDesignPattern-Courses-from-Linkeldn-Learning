using NUnit.Framework;
using Singleton;

namespace SingletonTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreSame(Policy.Instance,Policy.Instance);
        }
    }
}