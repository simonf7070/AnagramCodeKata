using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramCodeKata.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void Given_two_strings_can_test_if_anagram()
        {
            var stringOne = "piecrust";
            var stringTwo = "pictures";

            var isAnagram = stringOne.IsAnagramOf(stringTwo);

            Assert.IsTrue(isAnagram);
        }

        [TestMethod]
        public void Given_two_strings_can_test_if_not_anagram()
        {
            var stringOne = "piecrustx";
            var stringTwo = "pictures";

            var isAnagram = stringOne.IsAnagramOf(stringTwo);

            Assert.IsFalse(isAnagram);
        }
    }
}
