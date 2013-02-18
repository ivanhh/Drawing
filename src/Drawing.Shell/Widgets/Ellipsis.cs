using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Ellipsis : Lib.Ellipsis
    {
        public Ellipsis(Point location, uint horizontalDiameter, uint verticleDiameter) : base(location, horizontalDiameter, verticleDiameter)
        {}

        public override void Render()
        {
            Console.WriteLine("{0} {1}, horizontal diameter={2}, verticle diameter={3}", Name, Location, HorizontalDiameter, VerticleDiameter);
        }
    }
}
