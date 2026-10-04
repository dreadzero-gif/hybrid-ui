namespace HybridUI.Combat
{
    public class BossTimer
    {
        public float TimeRemaining { get; private set; }
        public bool Active { get; private set; }

        public void Start(float duration)
        {
            TimeRemaining = duration;
            Active = true;
        }

        public void Update(float delta)
        {
            if (!Active)
                return;

            TimeRemaining -= delta;

            if (TimeRemaining <= 0)
                Active = false;
        }
    }
}
