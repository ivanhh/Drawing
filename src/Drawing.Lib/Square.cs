namespace Drawing.Lib
{
    public class Square : Rectangle
    {
        protected Square(uint size) : base(size, size)
        {}

        public override string Name
        {
            get { return "sqaure"; }
        }
    }
}
