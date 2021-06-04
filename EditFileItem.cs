using System;
using System.IO;
using System.Windows.Forms;

namespace minecraft_server_launchers
{
  public partial class EditFileItem : UserControl
  {
    public string Path { get; set; }
    public string FileName { get => panel.Title; set => panel.Title = value; }
    new public string Text { get => textBox.Text; set => textBox.Text = value; }

    public EditFileItem()
    {
      InitializeComponent();
    }

    public EditFileItem(string path)
    {
      if (File.Exists(path))
      {
        var fInfo = new FileInfo(path);
        FileName = fInfo.Name;
        Text = File.ReadAllText(path);
      }
    }

    private void panel_Resize(object sender, EventArgs e)
    {
      Size = panel.Size;
    }

    private void panel_PanelExpand(object sender, EventArgs e)
    {
      Text = File.ReadAllText(Path);
    }

    private void panel_SaveClick(object sender, EventArgs e)
    {
      File.WriteAllText(Path, Text);
      panel.Collapse = true;
    }
  }
}
