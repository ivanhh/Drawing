using System;
using System.Collections.Generic;
using Drawing.Lib;

namespace Drawing.Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            var page = new Page(1000, 1000);

            page.AddWidget(new Widgets.Rectangle(30, 40), new Point(10, 10));
            page.AddWidget(new Widgets.Square(35), new Point(15, 30));
            page.AddWidget(new Widgets.Ellipsis(300, 200), new Point(100, 150));
            page.AddWidget(new Widgets.Circle(300), new Point(1, 1));
            page.AddWidget(new Widgets.Textbox(200, 100, "sample text"), new Point(5, 5));

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Current Drawing");
            Console.WriteLine("----------------------------------------------------------------");

            page.Render();

            Console.WriteLine("----------------------------------------------------------------");
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
