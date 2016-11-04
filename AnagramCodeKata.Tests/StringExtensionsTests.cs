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
            var stringOne = "piecrusp";
            var stringTwo = "pictures";

            var isAnagram = stringOne.IsAnagramOf(stringTwo);

            Assert.IsFalse(isAnagram);
        }

        [TestMethod]
        public void Given_two_strings_can_test_if_not_anagram_when_different_lengths()
        {
            var stringOne = "piecrustx";
            var stringTwo = "pictures";

            var isAnagram = stringOne.IsAnagramOf(stringTwo);

            Assert.IsFalse(isAnagram);
        }

        [TestMethod]
        public void Word_is_sorted_correctly()
        {
            var word = "cat";
            Assert.AreEqual("act", word.SortedLetters());
        }
    }
}
