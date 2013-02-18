using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Rectangle : Lib.Rectangle
    {
        public Rectangle(uint width, uint height) : base(width, height)
        {}

        public override void Render(Point bottomLeft)
        {
            Console.WriteLine("{0} {1}, width={2} height={3}", Name, bottomLeft, Width, Height);
        }
    }
}
