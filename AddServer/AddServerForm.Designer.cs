using System.ComponentModel;

namespace minecraft_server_launchers.AddServer
{
  partial class AddServerForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonNext = new System.Windows.Forms.Button();
      this.buttonPrevious = new System.Windows.Forms.Button();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(12, 29);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(396, 345);
      this.panel1.TabIndex = 0;
      this.panel1.Tag = "page";
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(396, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // buttonNext
      // 
      this.buttonNext.Location = new System.Drawing.Point(309, 380);
      this.buttonNext.Name = "buttonNext";
      this.buttonNext.Size = new System.Drawing.Size(99, 31);
      this.buttonNext.TabIndex = 2;
      this.buttonNext.Text = "다음";
      this.buttonNext.UseVisualStyleBackColor = true;
      this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
      // 
      // buttonPrevious
      // 
      this.buttonPrevious.Location = new System.Drawing.Point(204, 380);
      this.buttonPrevious.Name = "buttonPrevious";
      this.buttonPrevious.Size = new System.Drawing.Size(99, 31);
      this.buttonPrevious.TabIndex = 2;
      this.buttonPrevious.Text = "이전";
      this.buttonPrevious.UseVisualStyleBackColor = true;
      this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click_1);
      // 
      // buttonAdd
      // 
      this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.buttonAdd.Location = new System.Drawing.Point(309, 380);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(99, 31);
      this.buttonAdd.TabIndex = 3;
      this.buttonAdd.Text = "생성";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.button1);
      this.panel2.Location = new System.Drawing.Point(326, 12);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(396, 321);
      this.panel2.TabIndex = 0;
      this.panel2.Tag = "page";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(54, 70);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(74, 86);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.No;
      this.buttonCancel.Location = new System.Drawing.Point(204, 380);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(99, 31);
      this.buttonCancel.TabIndex = 2;
      this.buttonCancel.Text = "취소";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // AddServerForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(420, 423);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonPrevious);
      this.Controls.Add(this.buttonNext);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "AddServerForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "서버 추가";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonCancel;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.Button button;

    private System.Windows.Forms.Button buttonNext;
    private System.Windows.Forms.Button buttonPrevious;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel1;

    #endregion
  }
}