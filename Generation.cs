using System.Collections.Generic;

namespace CorrespondenceCoderetreat
{
    public class Generation
    {
        public static readonly Generation Empty = new Generation();
        readonly HashSet<Coordinates> coordinatesOfLivingCells;

        public Generation()
        {
            
        }

        public Generation(HashSet<Coordinates> coordinatesOfLivingCells)
        {
            this.coordinatesOfLivingCells = coordinatesOfLivingCells;
        }
    }
}
