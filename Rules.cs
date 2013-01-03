using NUnit.Framework;

namespace CorrespondenceCoderetreat
{
    public class Rules
    {
        public int[] SurviveRules;
        public int[] BornRules;

        public Rules(int[] survive, int[] born)
        {
            SurviveRules = survive;
            BornRules = born;
        }
    }
}