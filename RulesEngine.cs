using System.Linq;

namespace CorrespondenceCoderetreat
{
    public class RulesEngine
    {
        static int[] SurviveRules = { 2, 3 };
        static int[] BornRules = { 3 };

        public RulesEngine(Rules rules)
        {
            SurviveRules = rules.SurviveRules;
            BornRules = rules.BornRules;
        }

        public RulesEngine()
        {
        }

        public bool WillSurvive(int neighborsCount)
        {
            return SurviveRules.Contains(neighborsCount);
        }

        public bool WillBorn(int neighborsCount)
        {
            return BornRules.Contains(neighborsCount);
        }
    }
}
