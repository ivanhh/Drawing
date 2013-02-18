using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Textbox : Lib.Textbox
    {
        public Textbox(Point location, uint width, uint height, string text) : base(location, width, height, text)
        {}

        public override void Render()
        {
            Console.WriteLine("{0} {1}, width={2}, height={3}, text\"{4}\"", Name, Location, Width, Height, Text);
        }
    }
}
