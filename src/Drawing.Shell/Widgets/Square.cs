using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Square : Lib.Square
    {
        public Square(Point location, uint size) : base(location, size)
        {}

        public override void Render()
        {
            Console.WriteLine("{0} {1}, size={2}", Name, Location, Width);
        }
    }
}
