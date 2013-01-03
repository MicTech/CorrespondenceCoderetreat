using System.Linq;

namespace CorrespondenceCoderetreat
{
    public class RulesEngine
    {
        readonly Rules rules;

        public RulesEngine()
        {
            rules = new Rules(new[] { 2, 3 }, new[] { 3 });
        }

        public RulesEngine(Rules rules)
        {
            this.rules = rules;
        }
        
        public bool WillSurvive(int neighborsCount)
        {
            return rules.SurviveRules.Contains(neighborsCount);
        }

        public bool WillBorn(int neighborsCount)
        {
            return rules.BornRules.Contains(neighborsCount);
        }
    }
}
