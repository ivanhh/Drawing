using System;

namespace Drawing.Lib
{
    public abstract class Rectangle : Widget
    {
        private readonly uint _width;
        private readonly uint _height;

        protected Rectangle(Point location, uint width, uint height) : base(location)
        {
            if (width==0 || height==0)
                throw new ArgumentException("Height and Width must be greater than zero");

            _width = width;
            _height = height;
        }

        public uint Width
        {
            get { return _width; }
        }

        public uint Height
        {
            get { return _height; }
        }

        public override string Name
        {
            get { return "rectangle"; }
        }
    }
}
