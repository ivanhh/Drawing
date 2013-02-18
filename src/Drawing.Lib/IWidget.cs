namespace Drawing.Lib
{
    public interface IWidget
    {
        Point GetTopRight(Point bottomLeft);
        string Name { get; }
        void Render(Point bottomLeft);
    }
}
