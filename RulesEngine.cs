using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorrespondenceCoderetreat
{
    public class RulesEngine
    {
        public bool WillSurvive(int neighboursCount)
        {
            return neighboursCount >= 2;
        }

        public bool WillBorn(int neighborsCount)
        {
            return true;
        }
    }
}
