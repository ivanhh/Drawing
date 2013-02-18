namespace Drawing.Lib
{
    public interface IWidget
    {
        void Render();
        Point Location { get; }
        string Name { get; }
    }
}
