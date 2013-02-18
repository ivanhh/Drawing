namespace Drawing.Lib
{
    public class Textbox : Rectangle
    {
        private readonly string _text;

        protected Textbox(uint width, uint height, string text) : base( width, height)
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
