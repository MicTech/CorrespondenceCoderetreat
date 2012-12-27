namespace CorrespondenceCoderetreat
{
    public class RulesEngine
    {
        public bool WillSurvive(int neighborsCount)
        {
            return neighborsCount == 2 || neighborsCount == 3;
        }

        public bool WillBorn(int neighborsCount)
        {
            return true;
        }
    }
}
