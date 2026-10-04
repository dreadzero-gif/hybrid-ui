
Paste:

```markdown
# Themes

Themes define the visual identity of Hybrid UI.

## Structure
Each theme includes:
- Color palette
- Texture set
- Optional animations

## Creating a Theme
```csharp
public class MyTheme : ITheme
{
    public ThemeColorPalette Colors { get; }
    public ThemeTextureSet Textures { get; }
}
