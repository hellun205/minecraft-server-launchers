using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
      foreach (var str in exts)
        Exts.Add(str);

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

    private void Add(string path)
    {
      Items.Add(new(path));
      Controls.Add(Items[Items.Count - 1]);
      //Items[Items.Count - 1].panel.PanelExpand += OnReLoc;
      //Items[Items.Count - 1].panel.PanelCollapse += OnReLoc;
      Items[Items.Count - 1].Resize += OnReLoc_;
      OnReLoc();
    }

    private void OnReLoc_(object sender, EventArgs e)
    {
      OnReLoc();
    }
    private void OnReLoc()
    {
      for (var i = 1; i > Items.Count; i++)
        Items[i].Top = Items[i - 1].Top + Items[i - 1].Height;
    }

    private void EditFileList_Resize(object sender, EventArgs e)
    {
      foreach (var item in Items)
        item.Width = Width;
    }
  }
}
