namespace Drawing.Lib
{
    public abstract class Widget : IWidget
    {
        private readonly Point _location;

        protected Widget(Point location)
        {
            _location = location;
        }

        public Point Location
        {
            get { return _location; }
        }

        public abstract string Name { get; }

        public abstract void Render();
    }
}
