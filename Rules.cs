namespace CorrespondenceCoderetreat
{
    public class Rules
    {
        readonly int[] surviveRules;
        readonly int[] bornRules;

        public Rules(int[] survive, int[] born)
        {
            surviveRules = survive;
            bornRules = born;
        }

        public int[] BornRules
        {
            get { return bornRules; }
        }

        public int[] SurviveRules
        {
            get { return surviveRules; }
        }
    }
}