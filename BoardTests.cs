using NUnit.Framework;

namespace CorrespondenceCoderetreat
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void BoardShouldReturnThreeNeighborsForCoordinatesX5Y3()
        {
            var x = 5;
            var y = 3;
            var board = new Board();
            var neighborsCount = board.GetNeighborsCountForCoordinates(x, y);
            Assert.AreEqual(3,neighborsCount);
        }
    }
}