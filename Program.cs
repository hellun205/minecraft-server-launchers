using System;
using System.Windows.Forms;

namespace minecraft_server_launchers
{
  static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MultiServerLaunchers());
    }

    public static string programName => "MSL 2.1";
  }
}
