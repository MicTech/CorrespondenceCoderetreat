namespace CorrespondenceCoderetreat
{
    using System.Linq;

    public class RulesEngine
    {
        static readonly int[] SurviveRules = { 2, 3 };
        static readonly int[] BornRules = { 3 };

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
