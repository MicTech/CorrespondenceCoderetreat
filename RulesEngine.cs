using System.Linq;

namespace CorrespondenceCoderetreat
{
    public class RulesEngine
    {
        readonly Rules rules;

        public RulesEngine()
            : this(new GameOfLifeRules())
        { }

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
