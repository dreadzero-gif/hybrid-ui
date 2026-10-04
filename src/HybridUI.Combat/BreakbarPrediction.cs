using Microsoft.Xna.Framework;

namespace HybridUI.Combat
{
    public class BreakbarPrediction
    {
        public float BreakbarValue { get; private set; }
        public bool IsActive { get; private set; }

        public void Update(float delta)
        {
            // Future: breakbar prediction logic
        }

        public void Activate(float initialValue)
        {
            BreakbarValue = initialValue;
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}
