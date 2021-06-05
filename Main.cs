using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace minecraft_server_launchers
{
  public partial class Main : MaterialForm
  {
    private static MaterialSkinManager msm = MaterialSkinManager.Instance;
    public Server Server = new();
    private string bukkitPath;
    private string serverPath;
    private string logPath;
    private PerformanceCounter pfcRam = new()
    {
      CategoryName = "Process",
      CounterName = "Working Set - Private"
    };
    private double usageRam;
    private int playerCnt;
    private int playerMCnt;
    private string logName;

    private EditFileList editFiles;

    public Main()
    {
      InitializeComponent();
      CheckForIllegalCrossThreadCalls = false;
      serverPath = "./server";
      logPath = $"{serverPath}/server-logs";

      msm.AddFormToManage(this);
      msm.Theme = MaterialSkinManager.Themes.DARK;
      //ChangeColor("blue");

      Server.OnOutput += Server_OnOutput;
      Server.OnStarted += Server_OnStarted;
      Server.OnExited += Server_OnExited;
      Loads();
      lbServerStatus.BackColor = Color.FromArgb(48, 63, 159);
      lbServerStatus.ForeColor = Color.Red;

    }

    private void Server_OnOutput(string data)
    {
      tbOutput.AppendText($"\n{data}");

      if (data != null && data != "")
      {
        if (data.Contains("UUID of player"))
        {
          var playerName = data.Split("UUID of player ")[1].Split(" is")[0];
          foreach (var item in lsvPList.Items.Cast<ListViewItem>())
            if (item.Text == playerName) return;

          lsvPList.Items.Add(playerName);
          playerCnt++;

          var head = new WebClient();
          imlPlayer.Images.Add(Image.FromStream(new MemoryStream(head.DownloadData($"http://mc-heads.net/avatar/{playerName}"))));
          imlPlayer.Images[^1].Tag = playerName;

          lsvPList.Items[^1].ImageIndex = imlPlayer.Images.Count - 1;
        }
        else if (data.Contains("lost connection"))
        {
          var playerName = data.Split(" lost connection")[0].Split(": ")[1];

          foreach (var item in lsvPList.Items.Cast<ListViewItem>())
            if (item.Text == playerName)
              lsvPList.Items.Remove(item);

          foreach (var image in imlPlayer.Images.Cast<Image>())
            if ((string)image.Tag == playerName)
              imlPlayer.Images.Remove(image);

          playerCnt--;
        }
      }
    }

    private void Server_OnStarted()
    {
      //ChangeColor("green");
      btnStart.Enabled = false;
      lbServerStatus.ForeColor = Color.LimeGreen;
      lbServerStatus.Text = "ON";

      sliMaxRam.Enabled = false;
      sliMinRam.Enabled = false;
      btnBukkitFile.Enabled = false;

      if (File.Exists("./server/server.properties"))
      {
        var properties = File.ReadAllText("./server/server.properties");
        var maxPlayer = properties.Split("max-players=")[1].Split("\n")[0];
        playerMCnt = Convert.ToInt32(maxPlayer);
      }

      var time = $"{DateTime.Now.Year:D4}{DateTime.Now.Month:D2}{DateTime.Now.Day:D2}-{DateTime.Now.Hour:D2}{DateTime.Now.Minute:D2}{DateTime.Now.Second:D2}";
      tbOutput.Clear();
      tbOutput.AppendText($"Server start at : {time}");
      logName = $"server-log-{time}.txt";
    }

    private void Server_OnExited()
    {
      //ChangeColor("blue");
      btnStart.Enabled = true;
      lbServerStatus.ForeColor = Color.Red;
      lbServerStatus.Text = "OFF";

      sliMaxRam.Enabled = true;
      sliMinRam.Enabled = true;
      btnBukkitFile.Enabled = true;


      if (!Directory.Exists(logPath)) Directory.CreateDirectory(logPath);
      File.WriteAllText($"{logPath}/{logName}", tbOutput.Text);
    }

    private void ChangeColor(string colorS = "blue-gray")
    {
      ColorScheme cs;
      switch (colorS)
      {
        case "blue":
          cs = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue200, TextShade.WHITE);
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
      Server.WorkingDirectory = serverPath;
      Server.Start();
      pfcRam.InstanceName = $"{Server.process.ProcessName}#{Server.process.SessionId}";
    }

    private void btnInput_Click(object sender, EventArgs e)
    {
      OnInput();
    }


    private void Loads()
    {
      if (!Directory.Exists(serverPath)) Directory.CreateDirectory(serverPath);
      var fileInfo = new DirectoryInfo(serverPath).GetFiles("*.jar");
      if (fileInfo.Length > 0)
      {
        btnBukkitFile.Image = Icon.ExtractAssociatedIcon(fileInfo[0].FullName).ToBitmap();
        btnBukkitFile.Text = fileInfo[0].Name;
        bukkitPath = fileInfo[0].FullName;
      }
      sliMaxRam.RangeMax = Ram.GetTotalGB;
      sliMinRam.RangeMax = Math.Max(1, sliMaxRam.Value);

      editFiles = new(serverPath, new string[] { "*.yml", "*.json", "*.properties", "*.txt" });
      editFiles.Dock = DockStyle.Fill;
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

    private void sliMinRam_onValueChanged(object sender, int newValue)
    {
      if (newValue == 0)
        sliMinRam.Value = 1;
    }

    private void btnFileEditorRefresh_Click(object sender, EventArgs e)
    {
      editFiles.Refresh_();
    }

    private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13)
      {
        OnInput();
        e.Handled = true;
      }
    }

    private void OnInput()
    {
      Server.Input(tbInput.Text);
      tbInput.Clear();
    }

    private void tmStatus1_Tick(object sender, EventArgs e)
    {
      try
      {
        usageRam = Math.Round(pfcRam.NextValue() / Math.Pow(1024, 2), 2);
      }
      catch
      {
        usageRam = 0;
      }
      if (!tmStatus2.Enabled) tmStatus2.Start();
    }

    private void tmStatus2_Tick(object sender, EventArgs e)
    {
      prbRamUsg.Maximum = Server.MaxRam * 1024;
      prbRamUsg.Value = (int)(Math.Max(prbRamUsg.Minimum, Math.Min(usageRam, prbRamUsg.Maximum)));
      labRamUsg.Text = $"{usageRam} / {Math.Round((double)Server.MaxRam * 1024, 2)} MB";

      prbPInt.Maximum = playerMCnt;
      prbPInt.Value = (int)(Math.Max(prbPInt.Minimum, Math.Min(playerCnt, prbPInt.Maximum)));
      labPStr.Text = $"{playerCnt} / {playerMCnt}";
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = Server.IsOnline;
      void kill()
      {
        Server.Kill();
        Server_OnExited();
        e.Cancel = false;
      }

      if (Server.IsOnline)
      {
        if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.FormOwnerClosing || e.CloseReason == CloseReason.ApplicationExitCall)
        {
          if (MessageBox.Show(this, "Are you sure you want to shut down the server?", "MSL", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            kill();
        }
        else if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing)
          kill();
      }


    }
  }
}
