using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace minecraft_server_launchers
{
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
  public class MEMORYSTATUSEX
  {
    public uint dwLength;
    public uint dwMemoryLoad;
    public ulong ullTotalPhys;
    public ulong ullAvailPhys;
    public ulong ullTotalPageFile;
    public ulong ullAvailPageFile;
    public ulong ullTotalVirtual;
    public ulong ullAvailVirtual;
    public ulong ullAvailExtendedVirtual;
    public MEMORYSTATUSEX() => this.dwLength = (uint)Marshal.SizeOf(typeof(NativeMethods.MEMORYSTATUSEX));


    
  }
  public static class Ram
  {
    public static int GetMemory
    {
      get
      {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);
        MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
        if (GlobalMemoryStatusEx(memStatus))
          return (int)(memStatus.ullTotalPhys/ 1024/1024);
        else return 0;
      }
    }
  }
}
