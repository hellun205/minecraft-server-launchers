using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace minecraft_server_launchers
{
  public partial class Main : MaterialForm
  {
    private static MaterialSkinManager msm = MaterialSkinManager.Instance;
    public Server Server = new();

    public Main()
    {
      InitializeComponent();

      msm.AddFormToManage(this);
      msm.Theme = MaterialSkinManager.Themes.DARK;
      ChangeColor("blue");

      Server.OnOutput = () =>
      {
        tbOutput.AppendText(Server.Data);
      };
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
  }
}
