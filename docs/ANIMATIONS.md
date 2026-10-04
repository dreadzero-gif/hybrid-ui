
Paste:

```markdown
# Animations

Hybrid UI includes a lightweight animation engine.

## Built‑in Animations
- Pulse
- Glow
- Rotate
- Fade

## Using an Animation
```csharp
AnimationEngine.Add(new PulseAnimation(0.5f));

public class MyAnimation : IAnimation
{
    public void Update(float delta) { }
}
