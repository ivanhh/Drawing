using System;
using System.Collections.Generic;

namespace Drawing.Lib
{
    public class Page
    {
        private readonly IDictionary<IWidget, Point> _widgets = new Dictionary<IWidget,Point>();
        private readonly Point _dimensions;

        public Page(uint width, uint height)
        {
            _dimensions = new Point(width, height);
        }

        public IWidget AddWidget(IWidget widget, Point locationBottomLeft)
        {
            if (widget.GetTopRight(locationBottomLeft)>_dimensions)
                throw new ArgumentException("Widget does not fit on page");

            _widgets.Add(widget, locationBottomLeft);
            return widget;
        }

        public void Render()
        {
            foreach (var widget in _widgets)
                widget.Key.Render(widget.Value);
        }
    }
}
