using System;
namespace CorrespondenceCoderetreat
{
    public class Board
    {
        readonly Generation generation;

        public Board(Generation generation)
        {
            this.generation = generation;
        }

        public int CountNeightborsFor(Coordinates coordinates)
        {
            return generation == Generation.Empty ? 0 : -1;
        }
    }
}