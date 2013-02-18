using System;

namespace Drawing.Lib
{
    public class Ellipsis : IWidget
    {
        private readonly uint _horizontalDiameter;
        private readonly uint _verticleDiameter;

        protected Ellipsis(uint horizontalDiameter, uint verticleDiameter) 
        {
            if (horizontalDiameter == 0 || verticleDiameter == 0)
                throw new ArgumentException("Verticle diameter and horizontal diameter must be greater than zero");

            _horizontalDiameter = horizontalDiameter;
            _verticleDiameter = verticleDiameter;
        }

        public uint HorizontalDiameter
        {
            get { return _horizontalDiameter; }
        }

        public uint VerticleDiameter
        {
            get { return _verticleDiameter; }
        }

        public virtual string Name
        {
            get { return "ellipsis"; }
        }

        public virtual void Render(Point bottomLeft)
        {}

        public Point GetTopRight(Point bottomLeft)
        {
            return new Point(bottomLeft.X+HorizontalDiameter, bottomLeft.Y+VerticleDiameter); 
        }
    }
}
