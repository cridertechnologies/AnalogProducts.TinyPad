namespace TinyPad;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
        CenterToScreen();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        Resize += OnWindowResize;
        SetWordWrapFromConfig();
    }

    private void OnWindowResize(object? sender, EventArgs e)
    {
        content.Height = ClientSize.Height - menuStrip1.Height - 5;
        content.Width = ClientSize.Width;
    }

    #region ToolStrip Menu Events
    #region File Menu
    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog();
        ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        ofd.DefaultExt = "txt";
        if (ofd.ShowDialog(this) == DialogResult.OK)
        {
            try
            {
                content.Text = File.ReadAllText(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to open file: {ex.Message}", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFile();
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFile();
    }

    private void NewToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // Ask the user to confirm if they want to clear the content
        var result = MessageBox.Show(this, "Are you sure you want to create a new document? Unsaved changes will be lost.", "Confirm New Document", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
            content.Clear();
        }
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }
    #endregion
    #region Format Menu
    private void FontToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var fontForm = new SubForms.FormFont();
        if (fontForm.ShowDialog(this) == DialogResult.OK)
        {
            float newSize = fontForm.SelectedFontSize;
            FontStyle newStyle = fontForm.SelectedFontStyle;
            string fontFamily = fontForm.SelectedFontFamily;
            content.Font = new Font(fontFamily, newSize, newStyle);
        }
    }

    private void WordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        var appConfig = Program.GetAppConfig();
        appConfig.WordWrap = wordWrapToolStripMenuItem.Checked;
        Program.SaveAppConfig(appConfig);
        content.WordWrap = appConfig.WordWrap;
    }

    private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
    {
        wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked;
    }

    private void ClearAllFormattingToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // Reset to default font
        content.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        var appConfig = Program.GetAppConfig();
        appConfig.FontSize = 12;
        appConfig.FontFamily = "Segoe UI";
        appConfig.FontWeight = FontStyle.Regular;

        Program.SaveAppConfig(appConfig);
    }
    #endregion
    #region Help Menu
    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var aboutForm = new SubForms.FormAbout();
        aboutForm.ShowDialog(this);
    }
    #endregion
    #endregion

    private void SaveFile()
    {
        using var sfd = new SaveFileDialog();
        sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        sfd.DefaultExt = "txt";
        if (sfd.ShowDialog(this) == DialogResult.OK)
        {
            try
            {
                File.WriteAllText(sfd.FileName, content.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to save file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void SetWordWrapFromConfig()
    {
        var appConfig = Program.GetAppConfig();
        content.WordWrap = appConfig.WordWrap;

    }
}
