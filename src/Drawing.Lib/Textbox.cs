namespace Drawing.Lib
{
    public abstract class Textbox : Rectangle
    {
        private readonly string _text;

        protected Textbox(Point location, uint width, uint height, string text) : base(location, width, height)
        {
            _text = text;
        }

        public string Text
        {
            get { return _text; }
        }

        public override string Name
        {
            get { return "textbox"; }
        }
    }
}
