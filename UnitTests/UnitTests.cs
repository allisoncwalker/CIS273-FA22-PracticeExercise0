using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExcercise0;


namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestIsPalindromeForSpaces()
        {
            Assert.AreEqual(true, Program.IsPalindrome(""));
            Assert.AreEqual(true, Program.IsPalindrome(" "));
            Assert.AreEqual(true, Program.IsPalindrome("f"));
            Assert.AreEqual(true, Program.IsPalindrome("race car"));
            Assert.AreEqual(true, Program.IsPalindrome("race             car"));
            Assert.AreEqual(true, Program.IsPalindrome(" r a c e car"));

            Assert.AreEqual(true, Program.IsPalindrome(" a man a plan a canal  panama"));
            Assert.AreEqual(true, Program.IsPalindrome(" never odd or even    "));
        }

        [TestMethod]
        public void TestIsPalindromeForCase()
        {
            Assert.AreEqual(true, Program.IsPalindrome("Race Car"));
            Assert.AreEqual(true, Program.IsPalindrome("Race Car"));
            Assert.AreEqual(true, Program.IsPalindrome(" r a C e caR    "));

            Assert.AreEqual(true, Program.IsPalindrome("A man a plan a canal  Panama"));
            Assert.AreEqual(true, Program.IsPalindrome("Never odd or even"));

        }

        [TestMethod]
        public void TestIsPalindromeForFails()
        {
            Assert.AreEqual(false, Program.IsPalindrome("Race"));
            Assert.AreEqual(false, Program.IsPalindrome("RaceCarPaceCar"));
            Assert.AreEqual(false, Program.IsPalindrome(" oh yeahhhhhhhh"));

            Assert.AreEqual(false, Program.IsPalindrome("A man a plan Z canal  Panama"));
            Assert.AreEqual(false, Program.IsPalindrome("Never odd or even!"));

        }

        [TestMethod]
        public void TestIntReveral()
        {
            Assert.AreEqual(3, Program.ReverseInt(3));
            Assert.AreEqual(9753, Program.ReverseInt(3579));
            Assert.AreEqual(14789, Program.ReverseInt(98741));
            Assert.AreEqual(0, Program.ReverseInt(0));
            Assert.AreEqual(12345678, Program.ReverseInt(87654321));
        }

        [TestMethod]
        public void TestIntReveralForNegatives()
        {
            Assert.AreEqual(0, Program.ReverseInt(0));
            Assert.AreEqual(-14789, Program.ReverseInt(-98741));
            Assert.AreEqual(-6001, Program.ReverseInt(-1006));
            Assert.AreEqual(-3579, Program.ReverseInt(-9753));
            Assert.AreEqual(-12345678, Program.ReverseInt(-87654321));
        }

        [TestMethod]
        public void TestIsUnique()
        {
            Assert.AreEqual(true, Program.IsUnique("abcdefg"));           
            Assert.AreEqual(true, Program.IsUnique(""));
            Assert.AreEqual(true, Program.IsUnique("steward"));
            Assert.AreEqual(true, Program.IsUnique("the man is old"));
        }

        [TestMethod]
        public void TestIsUniqueFalse()
        {
            Assert.AreEqual(false, Program.IsUnique("abccba"));
            Assert.AreEqual(false, Program.IsUnique("aBb"));
            Assert.AreEqual(false, Program.IsUnique("I don't like this."));
            Assert.AreEqual(false, Program.IsUnique("stewardesses"));
        }


        [TestMethod]
        public void TestNeilNumbers()
        {
            Assert.AreEqual(true, Program.IsNeilNumber(1));
            Assert.AreEqual(true, Program.IsNeilNumber(2));
            Assert.AreEqual(true, Program.IsNeilNumber(9));
            Assert.AreEqual(true, Program.IsNeilNumber(370));
            Assert.AreEqual(true, Program.IsNeilNumber(371));
            Assert.AreEqual(true, Program.IsNeilNumber(8208));
            Assert.AreEqual(true, Program.IsNeilNumber(54748));
            Assert.AreEqual(true, Program.IsNeilNumber(9926315));
        }

        [TestMethod]
        public void TestNeilNumbersForNegatives()
        {
            Assert.AreEqual(false, Program.IsNeilNumber(10));
            Assert.AreEqual(false, Program.IsNeilNumber(2003));
            Assert.AreEqual(false, Program.IsNeilNumber(99999));
        }
    }
}
