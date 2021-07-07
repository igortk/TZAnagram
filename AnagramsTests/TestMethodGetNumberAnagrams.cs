using NUnit.Framework;
using TZAnagram;

namespace AnagramsTests
{
    public class TestMethodGetNumberAnagrams
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(null, Anagram.GetNumberAnagrams(null));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(null, Anagram.GetNumberAnagrams(""));
        }

        [Test]
        public void Test3()
        {

            Assert.AreEqual(null, Anagram.GetNumberAnagrams("ab"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(null, Anagram.GetNumberAnagrams("AB"));
        }

        [Test]
        public void Test5()
        {
            int[,] arrayInt = {
                {0,1,2 },
                {2,0,1 },
                {0,2,1 },
                {1,2,0 },
                {2,1,0 },
                {1,0,2 } };
            Assert.AreEqual(arrayInt, Anagram.GetNumberAnagrams("abc"));
        }
    }
}