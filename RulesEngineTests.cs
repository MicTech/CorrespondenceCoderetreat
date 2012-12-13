using NUnit.Framework;
using System;

namespace CorrespondenceCoderetreat
{
    [TestFixture]
    public class RulesEngineTests
    {
        readonly RulesEngine rulesEngine;

        public RulesEngineTests()
        {
            rulesEngine = new RulesEngine();
        }

        [Test]
        public void LivingCellWithThreeNeighboursShouldSurvive()
        {
            Assert.IsTrue(rulesEngine.WillSurvive(3));
        }

        [Test]
        public void LivingCellWithLessThanTwoNeighborsShouldDie()
        {
            Assert.IsFalse(rulesEngine.WillSurvive(1));
            Assert.IsFalse(rulesEngine.WillSurvive(0));
        }

        [Test]
        public void OnEmptySpaceWithThreeNeighboursShouldBornNewCell()
        {
            Assert.IsTrue(rulesEngine.WillBorn(3));
        }
    }
}