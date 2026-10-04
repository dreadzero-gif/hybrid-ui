namespace HybridUI.Components
{
    public interface IHUDComponent
    {
        void Render();
        void Update(GameTime time);
        void ApplyTheme(ITheme theme);
    }
}
