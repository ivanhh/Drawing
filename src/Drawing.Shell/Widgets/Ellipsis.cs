using System;
using Drawing.Lib;

namespace Drawing.Shell.Widgets
{
    public class Ellipsis : Lib.Ellipsis
    {
        public Ellipsis(uint horizontalDiameter, uint verticleDiameter) : base(horizontalDiameter, verticleDiameter)
        {}

        public override void Render(Point bottomLeft)
        {
            Console.WriteLine("{0} {1}, horizontal diameter={2}, verticle diameter={3}", Name, bottomLeft, HorizontalDiameter, VerticleDiameter);
        }
    }
}
