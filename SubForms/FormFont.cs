namespace TinyPad.SubForms;

public partial class FormFont : Form
{
    private AppConfig? _appConfig;
    public int SelectedFontSize => (int)fontSizeInput.Value;
    public FontStyle SelectedFontStyle => (FontStyle)dropdownFontWeight.SelectedItem!;
    public string SelectedFontFamily => dropdownFontFamily.SelectedItem!.ToString()!;

    public FormFont()
    {
        InitializeComponent();
        CenterToScreen();
    }

    private void FormFont_Load(object sender, EventArgs e)
    {
        LoadConfig();
        // Populate font size input
        fontSizeInput.Minimum = 8;
        fontSizeInput.Maximum = 72;
        fontSizeInput.Increment = 2;
        fontSizeInput.Value = _appConfig?.FontSize ?? 12;

        // Populate font weight dropdown
        dropdownFontWeight.Items.Clear();
        var fontWeights = new[]
        {
            FontStyle.Regular,
            FontStyle.Bold,
            FontStyle.Italic,
            FontStyle.Underline,
            FontStyle.Strikeout
        };
        foreach (var weight in fontWeights)
        {
            dropdownFontWeight.Items.Add(weight);
        }
        dropdownFontWeight.SelectedItem = _appConfig?.FontWeight ?? FontStyle.Regular;

        // Populate font family dropdown
        dropdownFontFamily.Items.Clear();
        var installedFonts = new System.Drawing.Text.InstalledFontCollection();
        foreach (var font in installedFonts.Families)
        {
            dropdownFontFamily.Items.Add(font.Name);
        }
        dropdownFontFamily.SelectedItem = _appConfig?.FontFamily ?? "Segoe UI";
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        _appConfig!.FontSize = (int)fontSizeInput.Value;
        _appConfig.FontWeight = (FontStyle)dropdownFontWeight.SelectedItem!;
        _appConfig.FontFamily = dropdownFontFamily.SelectedItem!.ToString()!;
        Program.SaveAppConfig(_appConfig);
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void LoadConfig()
    {
        // Load current font size from config 
        _appConfig = Program.GetAppConfig();
    }
}
