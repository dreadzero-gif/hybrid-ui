
Paste:

```markdown
# Components

Hybrid UI includes modular HUD components.

## Player Frame
Shows HP, boons, class icon, gauges.

## Target Frame
Shows target HP, breakbar, debuffs.

## Buff Bar
Displays active boons and conditions.

## Gauges
Available gauges:
- Attunement
- Energy Core
- Lifeforce

## Creating a Component
```csharp
public class MyComponent : IHUDComponent
{
    public void Update(float delta) { }
    public void Render() { }
}
