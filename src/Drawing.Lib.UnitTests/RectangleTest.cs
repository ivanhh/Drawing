using System;
using FluentAssertions;
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
            new Rectangle(0, 1);
        }

        [ExpectedException(typeof(ArgumentException))]
        [Test]
        public void InvalidHeight()
        {
            new Rectangle(1, 0);
        }

        public void Valid()
        {
            var rectangle = new Rectangle(1, 1);

            rectangle.Height.Should().Be(1);
            rectangle.Width.Should().Be(1);
        }
    }
}
