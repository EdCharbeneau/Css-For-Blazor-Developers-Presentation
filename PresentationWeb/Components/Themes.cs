using BlazorComponentUtilities;
using System;

namespace PresentationWeb.Components
{
    public static class Themes
    {
        public static StyleBuilder Dark => StyleBuilder.Empty()
                .AddStyle("--app-foreground", "antiquewhite")
                .AddStyle("--app-background", "var(--denim)")
                .AddStyle("--primary-color-darker", "var(--sky)")
                .AddStyle("--primary-color", "var(--denim)")
                .AddStyle("--primary-contrast-color", "var(--app-background)")
                ;
        public static StyleBuilder HighContrast => StyleBuilder.Empty()
                .AddStyle("--app-foreground", "white")
                .AddStyle("--app-background", "black")
                .AddStyle("--primary-color-darker", "var(--sky)")
                .AddStyle("--primary-color", "black")
                .AddStyle("--secondary-color", "#f1c40f")
                .AddStyle("--secondary-color-darker", "fuchsia")
                .AddStyle("--primary-contrast-color", "var(--app-background)")
                .AddStyle("--secondary-contrast-color", "var(--app-background)")
                ;
        public static StyleBuilder Default => StyleBuilder.Empty();

        public static StyleBuilder Light => StyleBuilder.Empty()
                .AddStyle("--app-foreground", "black")
                .AddStyle("--app-background", "antiquewhite")
                .AddStyle("--primary-color-darker", " var(--denim)")
                .AddStyle("--primary-color", " var(--sky)")
                .AddStyle("--primary-contrast-color", " var(--app-background)")
                .AddStyle("--secondary-color", "var(--orange)")
                .AddStyle("--secondary-contrast-color", " var(--app-background)")
                .AddStyle("--secondary-color-darker", " var(--orange-peel)")
            ;

        public static Dictionary<string, StyleBuilder> ThemeChoices = new()
        {
            { "default", Default },
            { "light", Light },
            { "dark", Dark },
            { "high", HighContrast }
        };
    }
}

