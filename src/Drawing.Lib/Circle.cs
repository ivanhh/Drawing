namespace Drawing.Lib
{
    public class Circle : Ellipsis
    {
        protected Circle(uint diameter)
            : base( diameter, diameter)
        {}

        public override string Name
        {
            get { return "circle"; }
        }
    }
}
