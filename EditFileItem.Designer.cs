
namespace minecraft_server_launchers
{
  partial class EditFileItem
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel = new MaterialSkin.Controls.MaterialExpansionPanel();
      this.textBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
      this.panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel
      // 
      this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.panel.Collapse = true;
      this.panel.Controls.Add(this.textBox);
      this.panel.Depth = 0;
      this.panel.Description = "";
      this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.panel.Location = new System.Drawing.Point(0, 0);
      this.panel.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
      this.panel.MouseState = MaterialSkin.MouseState.HOVER;
      this.panel.Name = "panel";
      this.panel.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
      this.panel.Size = new System.Drawing.Size(350, 48);
      this.panel.TabIndex = 0;
      this.panel.Title = "FileName";
      this.panel.ValidationButtonEnable = true;
      this.panel.SaveClick += new System.EventHandler(this.panel_SaveClick);
      this.panel.PanelExpand += new System.EventHandler(this.panel_PanelExpand);
      this.panel.Resize += new System.EventHandler(this.panel_Resize);
      // 
      // textBox
      // 
      this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox.Depth = 0;
      this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.textBox.Location = new System.Drawing.Point(9, 53);
      this.textBox.MouseState = MaterialSkin.MouseState.HOVER;
      this.textBox.Name = "textBox";
      this.textBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
      this.textBox.Size = new System.Drawing.Size(333, 114);
      this.textBox.TabIndex = 2;
      this.textBox.Text = "";
      // 
      // EditFileItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel);
      this.Name = "EditFileItem";
      this.Size = new System.Drawing.Size(350, 48);
      this.panel.ResumeLayout(false);
      this.panel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    public MaterialSkin.Controls.MaterialExpansionPanel panel;
    public MaterialSkin.Controls.MaterialMultiLineTextBox textBox;
  }
}
