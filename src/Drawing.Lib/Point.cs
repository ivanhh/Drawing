namespace Drawing.Lib
{
    public struct Point
    {
        private readonly uint _x;
        private readonly uint _y;

        public Point(uint x, uint y)
        {
            _x = x;
            _y = y;
        }

        public uint X
        {
            get { return _x; }
        }

        public uint Y
        {
            get { return _y; }
        }

        public override string ToString()
        {
            return string.Format("x={0}, y={1}", X, Y);
        }
        
        public static bool operator >(Point a, Point b)
        {
            return a.X > b.X || a.Y > b.Y;
        }

        public static bool operator <(Point a, Point b)
        {
            return a.X < b.X || a.Y < b.Y;
        }
    }
}
