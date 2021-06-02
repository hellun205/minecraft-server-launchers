using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace minecraft_server_launchers
{
  public partial class Main : MaterialForm
  {
    private static MaterialSkinManager msm = MaterialSkinManager.Instance;
    public Main()
    {
      InitializeComponent();

      msm.AddFormToManage(this);
      msm.Theme = MaterialSkinManager.Themes.DARK;
      ChangeColor("blue");
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

  }
}
