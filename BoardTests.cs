using NUnit.Framework;

namespace CorrespondenceCoderetreat
{
    [TestFixture]
    public class BoardTests
    {
        readonly Coordinates[] coordinatesOfLivingCells;

        public BoardTests()
        {
            coordinatesOfLivingCells = new[] { new Coordinates(0, 0) };
        }

        [Test]
        public void ShouldCountZeroNeighborsOnEmptyBoard()
        {
            var board = new Board(Generation.Empty);
            Assert.AreEqual(0, board.CountNeightborsFor(new Coordinates(0, 1)));
        }

        [Test]
        public void ShouldCountOneNeighborForCoordinatesWithOneNeighbor()
        {
            var generation = new Generation(coordinatesOfLivingCells);
            var board = new Board(generation);
            Assert.AreEqual(1, board.CountNeightborsFor(new Coordinates(0, 1)));
        }
    }
}