namespace Drawing.Lib
{
    public abstract class Square : Rectangle
    {
        protected Square(Point location, uint size) : base(location, size, size)
        {}

        public override string Name
        {
            get { return "sqaure"; }
        }
    }
}
