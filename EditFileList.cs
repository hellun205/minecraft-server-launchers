using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace minecraft_server_launchers
{
  public partial class EditFileList : UserControl
  {
    public List<EditFileItem> Items { get; set; }
    public string DirectoryPath { get; set; }
    public List<string> Exts { get; set; }

    public EditFileList()
    {
      InitializeComponent();
      DirectoryPath = String.Empty;
      Items = new();
      Exts = new();
    }

    public EditFileList(string directoryPath, string[] exts) : this()
    {
      DirectoryPath = directoryPath;
      Exts = exts.ToList();
      Refresh_();
    }

    private void Add(string path)
    {
      Items.Add(new(path));
      //Items[Items.Count - 1].panel.PanelExpand += OnReLoc_;
      //Items[Items.Count - 1].panel.PanelCollapse += OnReLoc_;
      Items[^1].Resize += OnReLoc_;
      Controls.Add(Items[^1]);
      OnReLoc();
    }

    private void OnReLoc_(object sender, EventArgs e)
    {
      OnReLoc();
    }

    private void OnReLoc()
    {
      if (Items.Count > 1)
      {
        for (var i = 1; i < Items.Count - 1; i++)
        {
          Items[i].Top = Items[i - 1].Top + Items[i - 1].Height + 5;
        }
      }
    }

    private void EditFileList_Resize(object sender, EventArgs e)
    {
      foreach (var item in Items)
      {
        item.Width = Width - 22;
        item.panel.Width = Width - 22;
        //item.panel.ExpandHeight = (int)((double)Height * 0.3);
      }
    }

    public void Refresh_()
    {
      Controls.Clear();
      Items.Clear();

      var dirInfo = new DirectoryInfo(DirectoryPath);
      foreach (var str in Exts)
      {
        var files = dirInfo.GetFiles(str);
        foreach (var file in files)
        {
          Add(file.FullName);
        }
      }
    }
  }
}