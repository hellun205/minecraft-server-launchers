using Microsoft.VisualBasic.Devices;
using System;

namespace minecraft_server_launchers
{
  static class Ram
  {
    public static ComputerInfo computerInfo = new();
    public static int GetTotalGB => Convert.ToInt32((computerInfo.TotalPhysicalMemory / (Math.Pow(1024, 3))) + 0.5);
    public static ulong GetTotal => computerInfo.TotalPhysicalMemory;
  }
}
