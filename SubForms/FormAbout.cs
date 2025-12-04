using System.Reflection;

namespace TinyPad.SubForms;

public partial class FormAbout : Form
{
    public FormAbout()
    {
        InitializeComponent();
        CenterToParent();
    }

    private void FormAbout_Load(object sender, EventArgs e)
    {
        // Get the version & build date from assembly info
        var version = Assembly.GetExecutingAssembly().GetName().Version;
        var buildDate = Assembly.GetExecutingAssembly()
            .GetCustomAttributes<AssemblyMetadataAttribute>()
            .FirstOrDefault(a => a.Key == "BuildDate")?
            .Value ?? "Unknown";

        lblVersion.Text = $"Version: {version}";
        lblBuildDate.Text = $"Build Date: {buildDate:yyyy-MM-dd HH:mm}";
    }
}
