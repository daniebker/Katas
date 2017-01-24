using ChopKata.Lib;
using NUnit.Framework;

namespace ChopKata
{
    [TestFixture]
    public class ChopKataShould
    {
        [Test]
        [TestCase(3, new int[0], ExpectedResult = -1)]
        [TestCase(3, new int[] { 1 }, ExpectedResult = -1)]
        [TestCase(1, new int[] { 1 }, ExpectedResult = 0)]
        [TestCase(1, new int[] { 1, 3, 5 }, ExpectedResult = 0)]
        [TestCase(3, new int[] { 1, 3, 5 }, ExpectedResult = 1)]
        [TestCase(5, new int[] { 1, 3, 5 }, ExpectedResult = 2)]
        [TestCase(0, new int[] { 1, 3, 5 }, ExpectedResult = -1)]
        [TestCase(2, new int[] { 1, 3, 5 }, ExpectedResult = -1)]
        [TestCase(4, new int[] { 1, 3, 5 }, ExpectedResult = -1)]
        [TestCase(6, new int[] { 1, 3, 5 }, ExpectedResult = -1)]
        [TestCase(1, new int[] { 1, 3, 5, 7 }, ExpectedResult = 0)]
        [TestCase(3, new int[] { 1, 3, 5, 7 }, ExpectedResult = 1)]
        [TestCase(5, new int[] { 1, 3, 5, 7 }, ExpectedResult = 2)]
        [TestCase(7, new int[] { 1, 3, 5, 7 }, ExpectedResult = 3)]
        [TestCase(0, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        [TestCase(2, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        [TestCase(4, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        [TestCase(6, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        [TestCase(8, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        public int Chop_using_while(int find, int[] arrayToChop)
        {
            var choppa = new WhileChoppa();

            return choppa.Chop(find, (arrayToChop));
        }

        [Test]
        [TestCase(3, new int[0], ExpectedResult = -1)]
        [TestCase(3, new int[] { 1 }, ExpectedResult = -1)]
        [TestCase(1, new int[] { 1 }, ExpectedResult = 0)]
        [TestCase(1, new int[] { 1, 3, 5 }, ExpectedResult = 0)]
        [TestCase(3, new int[] { 1, 3, 5 }, ExpectedResult = 1)]
        [TestCase(5, new int[] { 1, 3, 5 }, ExpectedResult = 2)]
        [TestCase(0, new int[] { 1, 3, 5 }, ExpectedResult = -1)]
        [TestCase(2, new int[] { 1, 3, 5 }, ExpectedResult = -1)]
        [TestCase(4, new int[] { 1, 3, 5 }, ExpectedResult = -1)]
        [TestCase(6, new int[] { 1, 3, 5 }, ExpectedResult = -1)]
        [TestCase(1, new int[] { 1, 3, 5, 7 }, ExpectedResult = 0)]
        [TestCase(3, new int[] { 1, 3, 5, 7 }, ExpectedResult = 1)]
        [TestCase(5, new int[] { 1, 3, 5, 7 }, ExpectedResult = 2)]
        [TestCase(7, new int[] { 1, 3, 5, 7 }, ExpectedResult = 3)]
        [TestCase(0, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        [TestCase(2, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        [TestCase(4, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        [TestCase(6, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        [TestCase(8, new int[] { 1, 3, 5, 7 }, ExpectedResult = -1)]
        public int Chop_using_recurse(int find, int[] arrayToChop)
        {
            var choppa = new RecursiveChoppa();

            return choppa.Chop(find, (arrayToChop));
        }
    }
}
