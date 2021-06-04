using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Drawing;
using Microsoft.VisualBasic.Devices;

namespace minecraft_server_launchers
{
  public partial class Main : MaterialForm
  {
    private static MaterialSkinManager msm = MaterialSkinManager.Instance;
    public Server Server = new();
    private string bukkitPath;

    private EditFileList editFiles;

    public Main()
    {
      InitializeComponent();

      msm.AddFormToManage(this);
      msm.Theme = MaterialSkinManager.Themes.DARK;
      ChangeColor("blue");

      Server.OnOutput = () =>
      {
        tbOutput.AppendText($"\n{Server.Data}");
      };
      Server.OnStarted = () =>
      {
        ChangeColor("green");
      };
      Server.OnExited = () =>
      {
        ChangeColor("blue");
      };
      Loads();
    }

    private void ChangeColor(string colorS = "blue-gray")
    {
      ColorScheme cs;
      switch (colorS)
      {
        case "blue":
          cs = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
          break;
        case "green":
          cs = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
          break;
        case "red":
          cs = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Orange200, TextShade.WHITE);
          break;
        case "yellow":
          cs = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Orange200, TextShade.BLACK);
          break;
        case "blue-gray":
        default:
          cs = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
          break;
      }
      msm.ColorScheme = cs;
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      Server.BukkitPath = bukkitPath;
      Server.MaxRam = Math.Max(1, sliMaxRam.Value);
      Server.MinRam = Math.Min(1, sliMinRam.Value);
      Server.Start();
    }

    private void btnInput_Click(object sender, EventArgs e)
    {

    }

    private void tbInput_TextChanged(object sender, EventArgs e)
    {

    }

    private void tpgLog_Click(object sender, EventArgs e)
    {

    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void Loads()
    {
      var path = "./server";
      if (!Directory.Exists(path)) Directory.CreateDirectory(path);
      var fileInfo = new DirectoryInfo(path).GetFiles("*.jar");
      if (fileInfo.Length > 0)
      {
        btnBukkitFile.Image = Icon.ExtractAssociatedIcon(fileInfo[0].FullName).ToBitmap();
        btnBukkitFile.Text = fileInfo[0].Name;
        bukkitPath = fileInfo[0].FullName;
      }
      sliMaxRam.RangeMax = Ram.GetTotalGB;
      sliMinRam.RangeMax = Math.Max(1, sliMaxRam.Value);

      editFiles = new(path, new string[] { "*.yml", "*.json", "*.properties" , "*.txt"});
      editFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      pnFileEditor.Controls.Add(editFiles);
    }

    private void sliMaxRam_onValueChanged(object sender, int newValue)
    {
      if (newValue == 0)
        sliMinRam.Value = 1;
      sliMinRam.RangeMax = Math.Max(1, newValue);
      if (sliMinRam.Value > sliMinRam.RangeMax)
        sliMinRam.Value = sliMinRam.RangeMax;
    }

    private void Main_Load(object sender, EventArgs e)
    {

    }

    private void sliMinRam_onValueChanged(object sender, int newValue)
    {
      if (newValue == 0)
        sliMinRam.Value = 1;
    }

    private void btnFileEditorRefresh_Click(object sender, EventArgs e)
    {
      editFiles.Refresh_();
    }
  }
}
