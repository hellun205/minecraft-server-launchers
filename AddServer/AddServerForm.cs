using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace minecraft_server_launchers.AddServer
{
  public partial class AddServerForm : Form
  {
    private ServerInfo ResultServerInfo = new ServerInfo();
    private List<Panel> Pages;
    private string[] PageTitle = new[] {"1페이지", "2페이지"};
    private int Page;

    public AddServerForm()
    {
      InitializeComponent();

      Pages = (from ctrl in Controls.OfType<Panel>()
        where ctrl.Tag == "page"
        orderby ctrl.Name
        select ctrl).ToList();

      GoPage(0);
    }

    public ServerInfo ShowForm(Form owner)
    {
      Owner = owner;
      return (ShowDialog() == DialogResult.Yes ? ResultServerInfo : null);
    }

    private void GoPage(int pageIndex)
    {
      Page = pageIndex;

      for (var i = 0; i < Pages.Count; i++)
      {
        Pages[i].Visible = (i == pageIndex);
      }

      label1.Text = PageTitle[pageIndex];

      if (pageIndex == 0)
      {
        buttonPrevious.Enabled = false;
        buttonPrevious.Visible = false;
        buttonNext.Enabled = true;
        buttonAdd.Visible = false;
        buttonNext.Visible = true;
        buttonCancel.Visible = true;
      }
      else if (pageIndex == Pages.Count - 1)
      {
        buttonPrevious.Enabled = true;
        buttonPrevious.Visible = true;
        buttonNext.Enabled = false;
        buttonNext.Visible = false;
        buttonAdd.Visible = true;
        buttonCancel.Visible = false;
      }
      else if (pageIndex > 0)
      {
        buttonPrevious.Enabled = true;
        buttonPrevious.Visible = true;
        buttonNext.Enabled = true;
        buttonAdd.Visible = false;
        buttonNext.Visible = true;
        buttonCancel.Visible = false;
      }
    }

    private void buttonNext_Click_1(object sender, EventArgs e)
    {
      GoPage(Page + 1);
    }

    private void buttonPrevious_Click_1(object sender, EventArgs e)
    {
      GoPage(Page - 1);
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}