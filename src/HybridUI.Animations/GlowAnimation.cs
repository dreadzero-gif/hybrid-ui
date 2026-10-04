using HybridUI.Core.Animations;

namespace HybridUI.Animations
{
    public class GlowAnimation : IAnimation
    {
        private float _time;
        private readonly float _duration;

        public bool IsFinished => _time >= _duration;

        public GlowAnimation(float duration = 1f)
        {
            _duration = duration;
        }

        public void Update(float delta)
        {
            _time += delta;

            // Future: glow intensity logic
        }
    }
}
