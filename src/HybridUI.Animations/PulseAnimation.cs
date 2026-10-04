using HybridUI.Core.Animations;

namespace HybridUI.Animations
{
    public class PulseAnimation : IAnimation
    {
        private float _time;
        private readonly float _duration;

        public bool IsFinished => _time >= _duration;

        public PulseAnimation(float duration = 0.5f)
        {
            _duration = duration;
        }

        public void Update(float delta)
        {
            _time += delta;

            // Future: apply pulse effect to UI component
        }
    }
}
