using System;
using System.Diagnostics;

namespace minecraft_server_launchers
{
  public delegate void OnStarted();
  public delegate void OnExited();
  public delegate void OnOutput();
  public class Server
  {
    private Process process = new Process();
    public string WorkingDirectory { get; set; }
    public int MaxRam { get; set; }
    public int MinRam { get; set; }
    public string BukkitPath { get; set; }
    public string Data { get; private set; }

    public bool IsOnline = false;

    public event OnStarted OnStarted;
    public event OnExited OnExited;
    public event OnOutput OnOutput;

    public void Start()
    {
      try
      {
        ExecuteServ();
      }
      catch
      {
        process.Dispose();
        process = new Process();       
      }
    }

    private void ExecuteServ()
    {
      process.StartInfo.FileName = "java.exe";
      process.StartInfo.Arguments = $"-Djline.terminal=jline.UnsupportedTerminal -Xmx{MaxRam}G -Xms{MinRam}G -jar \"{BukkitPath}\" nogui";
      process.StartInfo.WorkingDirectory = WorkingDirectory;
      process.StartInfo.CreateNoWindow = true;
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.RedirectStandardInput = true;
      process.StartInfo.RedirectStandardError = true;

      process.OutputDataReceived += new DataReceivedEventHandler(Output);
      process.ErrorDataReceived += new DataReceivedEventHandler(Output);
      process.Exited += new EventHandler(Exited);

      process.Start();
      process.EnableRaisingEvents = true;
      process.BeginErrorReadLine();
      process.BeginOutputReadLine();
      IsOnline = true;
      OnStarted();
    }

    public void Stop()
    {
      process.Kill();
    }

    private void Output(object sender, DataReceivedEventArgs e)
    {
      Data = e.Data;
      OnOutput();
    }

    public void Input(string inputCommand)
    {
      if (IsOnline) process.StandardInput.WriteLine(inputCommand);
    }

    private void Exited(object sender, EventArgs e)
    {
      process.Kill();
      process.Dispose();
      process = new Process();
      IsOnline = false;
      OnExited();
    }

  }
}
