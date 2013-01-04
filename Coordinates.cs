namespace CorrespondenceCoderetreat
{
    public struct Coordinates
    {
        readonly int x;
        readonly int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
    }
}
