using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Textbox : Lib.Textbox
    {
        public Textbox(uint width, uint height, string text) : base(width, height, text)
        {}

        public override void Render(Point bottomLeft)
        {
            Console.WriteLine("{0} {1}, width={2}, height={3}, text\"{4}\"", Name, bottomLeft, Width, Height, Text);
        }
    }
}
