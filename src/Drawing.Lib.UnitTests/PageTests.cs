using System;
using Drawing.Lib;
using Moq;
using NUnit.Framework;

namespace Drawing.Shell.UnitTests
{
    [TestFixture]
    public class PageTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [Test]
        public void AddWidget_OutOfBounds()
        {
            var origin = new Point(1, 1);
            var widget = new Mock<IWidget>();

            widget.Setup(w => w.GetTopRight(origin)).Returns(new Point(100, 100));

            new Page(99, 99).AddWidget(widget.Object, origin);

        }
    }
}
