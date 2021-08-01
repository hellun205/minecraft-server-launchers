using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft;
using minecraft_server_launchers.AddServer;

namespace minecraft_server_launchers
{
  public partial class MultiServerLaunchers : MaterialForm
  {
    private static MaterialSkinManager msm = MaterialSkinManager.Instance;

    public MultiServerLaunchers()
    {
      InitializeComponent();
      msm.AddFormToManage(this);
      msm.Theme = MaterialSkinManager.Themes.DARK;
    }

    private void ReadServersList(ListView listView, string serversListPath)
    {
      if (!Directory.Exists(serversListPath)) Directory.CreateDirectory(serversListPath);

      var dirInfo = new DirectoryInfo(serversListPath);
      var arrDirectory = dirInfo.GetDirectories();
      listView.Items.Clear();
      foreach (var dir in arrDirectory)
      {
        var path = $"{dir.FullName}/msl2";
        if (File.Exists($"{path}/setting.json"))
        {
          using (var file = File.OpenText($"{path}/setting.json"))
          using (var reader = new JsonTextReader(file))
          {
            var json = (JObject) JToken.ReadFrom(reader);
            
            var lvi = listView.Items.Add(json["server"].ToString());
            // sliMaxRam.Value = Convert.ToInt32(json["max-ram"].ToString());
            // sliMinRam.RangeMax = Math.Max(1, sliMaxRam.Value);
            // sliMinRam.Value = Convert.ToInt32(json["min-ram"].ToString());
          }
        }
      }
    }

    private void materialButton1_Click(object sender, EventArgs e)
    {
      using (var addServerForm = new AddServerForm())
      {
        addServerForm.ShowForm(this);
      }
    }
  }
}