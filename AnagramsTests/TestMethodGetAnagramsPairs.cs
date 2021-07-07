using NUnit.Framework;
using TZAnagram;

namespace AnagramsTests
{
    public class TestMethodGetAnagramsPairs
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(null, Anagram.GetAnagramsPairs(null));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(null, Anagram.GetAnagramsPairs(""));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(null, Anagram.GetAnagramsPairs("ab"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(null, Anagram.GetAnagramsPairs("AB"));
        }

        [Test]
        public void Test5()
        {
            string[] arrayInt = {
                "abc",
                "cab",
                "acb",
                "bca",
                "cba",
                "bac"};
            Assert.AreEqual(arrayInt, Anagram.GetAnagramsPairs("abc"));
        }
    }
}
