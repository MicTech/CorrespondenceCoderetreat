using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorrespondenceCoderetreat
{
    public class RulesEngine
    {
        public bool WillSurvive(int neighborsCount)
        {
            return neighborsCount >= 2;
        }

        public bool WillBorn(int neighborsCount)
        {
            return true;
        }
    }
}
