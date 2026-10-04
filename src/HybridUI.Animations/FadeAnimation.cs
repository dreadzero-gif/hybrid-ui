using HybridUI.Core.Animations;

namespace HybridUI.Animations
{
    public class FadeAnimation : IAnimation
    {
        private float _time;
        private readonly float _duration;

        public float Alpha { get; private set; }
        public bool IsFinished => _time >= _duration;

        public FadeAnimation(float duration = 0.5f)
        {
            _duration = duration;
        }

        public void Update(float delta)
        {
            _time += delta;
            Alpha = 1f - (_time / _duration);
        }
    }
}
