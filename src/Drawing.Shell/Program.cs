using System;
using System.Collections.Generic;
using Drawing.Lib;

namespace Drawing.Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            var widgets = new List<IWidget>
                {
                    new Widgets.Rectangle(new Point(20, 20), 30, 40),
                    new Widgets.Square(new Point(15, 30), 35),
                    new Widgets.Ellipsis(new Point(100, 150), 300, 200),
                    new Widgets.Circle(new Point(1, 1), 300),
                    new Widgets.Textbox(new Point(5, 5), 200, 100, "sample text")
                };

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Current Drawing");
            Console.WriteLine("----------------------------------------------------------------");

            foreach (var widget in widgets)
                widget.Render();

            Console.WriteLine("----------------------------------------------------------------");
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
