using System;
using Drawing.Lib;
using NUnit.Framework;
using Rectangle = Drawing.Shell.Widgets.Rectangle;

namespace Drawing.Shell.UnitTests
{
    [TestFixture]
    public class RectangleTest
    {
        [ExpectedException(typeof(ArgumentException))]
        [Test]
        public void InvalidWidth()
        {
            new Rectangle(new Point(1,1),0, 1);
        }

        [ExpectedException(typeof(ArgumentException))]
        [Test]
        public void InvalidHeight()
        {
            new Rectangle(new Point(1,1), 1, 0);
        }
    }
}
