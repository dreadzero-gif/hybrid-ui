using HybridUI.Core.Themes;
using System.Collections.Generic;

namespace HybridUI.Themes
{
    public static class ThemeEngine
    {
        private static readonly Dictionary<string, ITheme> _themes = new();

        public static void Register(ITheme theme)
        {
            if (!_themes.ContainsKey(theme.Name))
                _themes.Add(theme.Name, theme);
        }

        public static ITheme Get(string name)
        {
            return _themes.TryGetValue(name, out var theme) ? theme : null;
        }

        public static IEnumerable<ITheme> AllThemes => _themes.Values;
    }
}
