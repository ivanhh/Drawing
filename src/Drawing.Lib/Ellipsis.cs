using System;

namespace Drawing.Lib
{
    public abstract class Ellipsis : Widget
    {
        private readonly uint _horizontalDiameter;
        private readonly uint _verticleDiameter;

        protected Ellipsis(Point location, uint horizontalDiameter, uint verticleDiameter) : base(location)
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

        public override string Name
        {
            get { return "ellipsis"; }
        }
    }
}
