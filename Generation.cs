namespace CorrespondenceCoderetreat
{
    public class Generation
    {
        public static readonly Generation Empty = new Generation();

        readonly Coordinates[] coordinatesOfLivingCells;

        public Generation(params Coordinates[] coordinatesOfLivingCells)
        {
            this.coordinatesOfLivingCells = coordinatesOfLivingCells;
        }
    }
}
