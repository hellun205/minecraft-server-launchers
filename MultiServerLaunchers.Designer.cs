using System.ComponentModel;

namespace minecraft_server_launchers
{
  partial class MultiServerLaunchers
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiServerLaunchers));
      this.listView1 = new System.Windows.Forms.ListView();
      this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
      this.SuspendLayout();
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(283, 186);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(212, 177);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // materialButton1
      // 
      this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      this.materialButton1.Depth = 0;
      this.materialButton1.HighEmphasis = true;
      this.materialButton1.Icon = null;
      this.materialButton1.Location = new System.Drawing.Point(75, 125);
      this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialButton1.Name = "materialButton1";
      this.materialButton1.Size = new System.Drawing.Size(158, 36);
      this.materialButton1.TabIndex = 1;
      this.materialButton1.Text = "materialButton1";
      this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      this.materialButton1.UseAccentColor = false;
      this.materialButton1.UseVisualStyleBackColor = true;
      this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
      // 
      // MultiServerLaunchers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.materialButton1);
      this.Controls.Add(this.listView1);
      this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
      this.Name = "MultiServerLaunchers";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private MaterialSkin.Controls.MaterialButton materialButton1;

    private System.Windows.Forms.ListView listView1;

    #endregion
  }
}