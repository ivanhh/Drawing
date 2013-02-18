using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Square : Lib.Square
    {
        public Square(uint size) : base(size)
        {}

        public override void Render(Point bottomLeft)
        {
            Console.WriteLine("{0} {1}, size={2}", Name, bottomLeft, Width);
        }
    }
}
