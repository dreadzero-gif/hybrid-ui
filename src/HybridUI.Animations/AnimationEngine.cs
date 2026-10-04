using System.Collections.Generic;

namespace HybridUI.Core.Animations
{
    public static class AnimationEngine
    {
        private static readonly List<IAnimation> _animations = new();

        public static void Add(IAnimation animation)
        {
            _animations.Add(animation);
        }

        public static void Update(float delta)
        {
            for (int i = _animations.Count - 1; i >= 0; i--)
            {
                var anim = _animations[i];
                anim.Update(delta);

                if (anim.IsFinished)
                    _animations.RemoveAt(i);
            }
        }
    }
}
