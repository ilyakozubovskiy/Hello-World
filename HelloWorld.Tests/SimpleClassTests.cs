using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    public sealed class SimpleClassTests
    {
        [Test]
        public void ReturnOne()
        {
            int result = SimpleClass.ReturnOne();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ReturnTrue()
        {
            bool result = SimpleClass.ReturnTrue();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void ReturnObject()
        {
            object result = SimpleClass.ReturnObject();

            Assert.NotNull(result);
        }
    }
}
