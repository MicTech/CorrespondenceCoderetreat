using NUnit.Framework;
using System;

namespace CorrespondenceCoderetreat
{
    public class RulesEngineTests
    {
        [Test]
        public void LivingCellWithThreeNeighboursShouldSurvive()
        {
            var rulesEngine = new RulesEngine();
            bool willSurvive = rulesEngine.WillSurvive(3);
            Assert.IsTrue(willSurvive);
        }
    }
}