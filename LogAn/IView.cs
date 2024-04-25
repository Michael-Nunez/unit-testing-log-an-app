namespace LogAn
{
    public interface IView
    {
        event Action Loaded;
        void Render(string text);
    }
}