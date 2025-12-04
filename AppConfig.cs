namespace TinyPad;

internal class AppConfig
{
    public int FontSize { get; set; } = 12;
    public FontStyle FontWeight { get; set; } = FontStyle.Regular;
    public string FontFamily { get; set; } = "Segoe UI";
    public bool WordWrap { get; set; } = true;

    public AppConfig() { }

    public AppConfig(int fontSize, FontStyle fontWeight, string fontFamily, bool wordWrap)
    {
        FontSize = fontSize;
        FontWeight = fontWeight;
        FontFamily = fontFamily;
        WordWrap = wordWrap;
    }
}
