using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Circle : Lib.Circle
    {
        public Circle(Point location, uint diameter) : base(location, diameter)
        {}

        public override void Render()
        {
            Console.WriteLine("{0} {1}, size={2}", Name, Location, HorizontalDiameter);
        }
    }
}
