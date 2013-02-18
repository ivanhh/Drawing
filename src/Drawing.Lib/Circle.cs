namespace Drawing.Lib
{
    public abstract class Circle : Ellipsis
    {
        protected Circle(Point location, uint diameter)
            : base(location, diameter, diameter)
        {}

        public override string Name
        {
            get { return "circle"; }
        }
    }
}
