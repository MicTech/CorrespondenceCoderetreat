using NUnit.Framework;

namespace CorrespondenceCoderetreat
{
    public class RulesEngineTests
    {
        [Test]
        public void LivingCellWithThreeNeighboursShouldSurvive()
        {
            var rulesEngine = new RulesEngine();
            var willSurvive = rulesEngine.WillSurvive(3);
            Assert.IsTrue(willSurvive);
        }
    }
}