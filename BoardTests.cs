using NUnit.Framework;

namespace CorrespondenceCoderetreat
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void ShouldCountZeroNeighborsOnEmptyBoard()
        {
            var board = new Board(Generation.Empty);
            Assert.AreEqual(0, board.CountNeightborsFor(new Coordinates(5, 3)));
        }
    }
}