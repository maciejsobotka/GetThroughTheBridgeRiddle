using GetThroughTheBridgeRiddle;
using NUnit.Framework;

namespace GetThroughTheBridgeRiddleTests
{
    [TestFixture]
    public class AlgorithmTests
    {
        [Test]
        [TestCase(new[] {1, 2, 5, 10})]
        [TestCase(new[] {1, 2, 9, 10})]
        public void ShouldReturn17Test(int[] sprinters)
        {
            var expected = 17;

            Assert.AreEqual(expected, Algorithm.GetAllThroughTheBridge(sprinters));
        }

        [Test]
        [TestCase(new[] {2})]
        public void ShouldReturn2Test(int[] sprinters)
        {
            var expected = 2;

            Assert.AreEqual(expected, Algorithm.GetAllThroughTheBridge(sprinters));
        }

        [Test]
        [TestCase(new[] {1, 3})]
        public void ShouldReturn3Test(int[] sprinters)
        {
            var expected = 3;

            Assert.AreEqual(expected, Algorithm.GetAllThroughTheBridge(sprinters));
        }

        [Test]
        [TestCase(new[] {1, 2, 5})]
        public void ShouldReturn8Test(int[] sprinters)
        {
            var expected = 8;

            Assert.AreEqual(expected, Algorithm.GetAllThroughTheBridge(sprinters));
        }
    }
}