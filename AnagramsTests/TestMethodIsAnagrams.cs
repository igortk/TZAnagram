using NUnit.Framework;
using TZAnagram;

namespace AnagramsTests
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
            Assert.AreEqual(true,Anagram.IsAnagram("restful", "fluster"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, Anagram.IsAnagram("ResSful", "fluster"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, Anagram.IsAnagram("re", "er"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, Anagram.IsAnagram(null, "er"));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(false, Anagram.IsAnagram(null, null));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(false, Anagram.IsAnagram("", ""));
        }
    }
}