using System.Collections.Generic;
using HybridUI.Core.Themes;

namespace HybridUI.Core
{
    public static class ThemeManager
    {
        private static readonly Dictionary<string, ITheme> _themes = new();

        public static void RegisterTheme(ITheme theme)
        {
            if (!_themes.ContainsKey(theme.Name))
                _themes.Add(theme.Name, theme);
        }

        public static ITheme GetTheme(string name)
        {
            return _themes.TryGetValue(name, out var theme) ? theme : null;
        }

        public static void LoadBuiltInThemes()
        {
            RegisterTheme(new GoldRebornTheme());
            RegisterTheme(new ObsidianRebornTheme());
            RegisterTheme(new AzureRebornTheme());
            RegisterTheme(new CrimsonRebornTheme());
        }
    }
}
