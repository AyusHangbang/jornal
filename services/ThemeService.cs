public static void SetTheme(string theme)
{
    Application.Current.Resources.MergedDictionaries.Clear();
    Application.Current.Resources.MergedDictionaries.Add(
        new ResourceDictionary { Source = new Uri($"Themes/{theme}Theme.xaml", UriKind.Relative) });
}
