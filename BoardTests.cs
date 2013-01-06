using System.Collections.Generic;
using NUnit.Framework;

namespace CorrespondenceCoderetreat
{
    [TestFixture]
    public class BoardTests
    {
        readonly HashSet<Coordinates> coordinatesOfLivingCells;

        public BoardTests()
        {
            coordinatesOfLivingCells = new HashSet<Coordinates> { new Coordinates(5, 2) };
        }

        [Test]
        public void ShouldCountZeroNeighborsOnEmptyBoard()
        {
            var board = new Board(Generation.Empty);
            Assert.AreEqual(0, board.CountNeightborsFor(new Coordinates(5, 3)));
        }

        [Test]
        public void ShouldCountOneNeighborForCoordinatesX5Y3()
        {
            var generation = new Generation(coordinatesOfLivingCells);
            var board = new Board(generation);
            Assert.AreEqual(1, board.CountNeightborsFor(new Coordinates(5, 3)));
        }
    }
}