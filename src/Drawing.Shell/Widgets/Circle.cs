using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Circle : Lib.Circle
    {
        public Circle(uint diameter) : base(diameter)
        {}

        public override void Render(Point bottomLeft)
        {
            Console.WriteLine("{0} {1}, size={2}", Name, bottomLeft, HorizontalDiameter);
        }
    }
}
