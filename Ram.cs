using Microsoft.VisualBasic.Devices;
using System;

namespace minecraft_server_launchers
{
  static class Ram
  {
    public static int GetTotalGB => Convert.ToInt32((new ComputerInfo().TotalPhysicalMemory / (Math.Pow(1024, 3))) + 0.5);
  }
}
