namespace HybridUI.Combat
{
    public class MechanicAlert
    {
        public string Message { get; private set; }
        public float Duration { get; private set; }
        public float TimeLeft { get; private set; }
        public bool Active => TimeLeft > 0;

        public void Trigger(string message, float duration = 2f)
        {
            Message = message;
            Duration = duration;
            TimeLeft = duration;
        }

        public void Update(float delta)
        {
            if (TimeLeft > 0)
                TimeLeft -= delta;
        }
    }
}
