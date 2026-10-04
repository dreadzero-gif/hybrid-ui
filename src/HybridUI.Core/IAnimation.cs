namespace HybridUI.Core.Animations
{
    public interface IAnimation
    {
        bool IsFinished { get; }
        void Update(float delta);
    }
}
