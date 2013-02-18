using System;

namespace Drawing.Lib
{
    public class Rectangle : IWidget
    {
        private readonly uint _width;
        private readonly uint _height;

        protected Rectangle(uint width, uint height) 
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

        public virtual string Name
        {
            get { return "rectangle"; }
        }

        public virtual void Render(Point bottomLeft)
        {}

        public Point GetTopRight(Point bottomLeft)
        {
            return new Point(bottomLeft.X + Width, bottomLeft.Y + Height); 
        }
    }
}
