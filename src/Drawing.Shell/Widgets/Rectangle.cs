using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Rectangle : Lib.Rectangle
    {
        public Rectangle(Point location, uint width, uint height) : base(location, width, height)
        {}

        public override void Render()
        {
            Console.WriteLine("{0} {1}, width={2} height={3}", Name, Location, Width, Height);
        }
    }
}
