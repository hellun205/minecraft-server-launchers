namespace minecraft_server_launchers
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
      this.tpgLog = new System.Windows.Forms.TabPage();
      this.labPStr = new MaterialSkin.Controls.MaterialLabel();
      this.prbPInt = new MaterialSkin.Controls.MaterialProgressBar();
      this.btnInput = new MaterialSkin.Controls.MaterialButton();
      this.tbInput = new MaterialSkin.Controls.MaterialTextBox();
      this.tbOutput = new MaterialSkin.Controls.MaterialMultiLineTextBox();
      this.tpgSetting = new System.Windows.Forms.TabPage();
      this.tpgPlgns = new System.Windows.Forms.TabPage();
      this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
      this.btnStart = new MaterialSkin.Controls.MaterialButton();
      this.lsvPList = new MaterialSkin.Controls.MaterialListView();
      this.tabControl.SuspendLayout();
      this.tpgLog.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.tpgLog);
      this.tabControl.Controls.Add(this.tpgSetting);
      this.tabControl.Controls.Add(this.tpgPlgns);
      this.tabControl.Depth = 0;
      this.tabControl.Location = new System.Drawing.Point(6, 70);
      this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
      this.tabControl.Multiline = true;
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(788, 374);
      this.tabControl.TabIndex = 0;
      // 
      // tpgLog
      // 
      this.tpgLog.Controls.Add(this.lsvPList);
      this.tpgLog.Controls.Add(this.labPStr);
      this.tpgLog.Controls.Add(this.prbPInt);
      this.tpgLog.Controls.Add(this.btnInput);
      this.tpgLog.Controls.Add(this.tbInput);
      this.tpgLog.Controls.Add(this.tbOutput);
      this.tpgLog.Location = new System.Drawing.Point(4, 24);
      this.tpgLog.Name = "tpgLog";
      this.tpgLog.Padding = new System.Windows.Forms.Padding(3);
      this.tpgLog.Size = new System.Drawing.Size(780, 346);
      this.tpgLog.TabIndex = 0;
      this.tpgLog.Text = "Log";
      this.tpgLog.UseVisualStyleBackColor = true;
      this.tpgLog.Click += new System.EventHandler(this.tpgLog_Click);
      // 
      // labPStr
      // 
      this.labPStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labPStr.Depth = 0;
      this.labPStr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labPStr.Location = new System.Drawing.Point(577, 14);
      this.labPStr.MouseState = MaterialSkin.MouseState.HOVER;
      this.labPStr.Name = "labPStr";
      this.labPStr.Size = new System.Drawing.Size(200, 23);
      this.labPStr.TabIndex = 4;
      this.labPStr.Text = "0 / 0";
      this.labPStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // prbPInt
      // 
      this.prbPInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.prbPInt.Depth = 0;
      this.prbPInt.Location = new System.Drawing.Point(577, 6);
      this.prbPInt.MouseState = MaterialSkin.MouseState.HOVER;
      this.prbPInt.Name = "prbPInt";
      this.prbPInt.Size = new System.Drawing.Size(200, 5);
      this.prbPInt.TabIndex = 3;
      // 
      // btnInput
      // 
      this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnInput.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      this.btnInput.Depth = 0;
      this.btnInput.HighEmphasis = true;
      this.btnInput.Icon = null;
      this.btnInput.Location = new System.Drawing.Point(507, 301);
      this.btnInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnInput.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnInput.Name = "btnInput";
      this.btnInput.Size = new System.Drawing.Size(64, 36);
      this.btnInput.TabIndex = 2;
      this.btnInput.Text = "Input";
      this.btnInput.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      this.btnInput.UseAccentColor = false;
      this.btnInput.UseVisualStyleBackColor = true;
      this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
      // 
      // tbInput
      // 
      this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbInput.Depth = 0;
      this.tbInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.tbInput.Hint = "Input command...";
      this.tbInput.LeadingIcon = null;
      this.tbInput.Location = new System.Drawing.Point(3, 296);
      this.tbInput.MaxLength = 50;
      this.tbInput.MouseState = MaterialSkin.MouseState.OUT;
      this.tbInput.Multiline = false;
      this.tbInput.Name = "tbInput";
      this.tbInput.Size = new System.Drawing.Size(497, 50);
      this.tbInput.TabIndex = 1;
      this.tbInput.Text = "";
      this.tbInput.TrailingIcon = null;
      this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
      // 
      // tbOutput
      // 
      this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbOutput.Depth = 0;
      this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.tbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tbOutput.Location = new System.Drawing.Point(3, 3);
      this.tbOutput.MouseState = MaterialSkin.MouseState.HOVER;
      this.tbOutput.Name = "tbOutput";
      this.tbOutput.ReadOnly = true;
      this.tbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
      this.tbOutput.Size = new System.Drawing.Size(568, 287);
      this.tbOutput.TabIndex = 0;
      this.tbOutput.Text = "";
      // 
      // tpgSetting
      // 
      this.tpgSetting.Location = new System.Drawing.Point(4, 24);
      this.tpgSetting.Name = "tpgSetting";
      this.tpgSetting.Padding = new System.Windows.Forms.Padding(3);
      this.tpgSetting.Size = new System.Drawing.Size(780, 346);
      this.tpgSetting.TabIndex = 1;
      this.tpgSetting.Text = "Setting";
      this.tpgSetting.UseVisualStyleBackColor = true;
      // 
      // tpgPlgns
      // 
      this.tpgPlgns.Location = new System.Drawing.Point(4, 24);
      this.tpgPlgns.Name = "tpgPlgns";
      this.tpgPlgns.Padding = new System.Windows.Forms.Padding(3);
      this.tpgPlgns.Size = new System.Drawing.Size(780, 346);
      this.tpgPlgns.TabIndex = 2;
      this.tpgPlgns.Text = "Plugins";
      this.tpgPlgns.UseVisualStyleBackColor = true;
      // 
      // tabSelector
      // 
      this.tabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabSelector.BaseTabControl = this.tabControl;
      this.tabSelector.Depth = 0;
      this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.tabSelector.Location = new System.Drawing.Point(171, 27);
      this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
      this.tabSelector.Name = "tabSelector";
      this.tabSelector.Size = new System.Drawing.Size(628, 31);
      this.tabSelector.TabIndex = 1;
      // 
      // btnStart
      // 
      this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      this.btnStart.Depth = 0;
      this.btnStart.HighEmphasis = true;
      this.btnStart.Icon = null;
      this.btnStart.Location = new System.Drawing.Point(97, 26);
      this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(67, 36);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "Start";
      this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      this.btnStart.UseAccentColor = false;
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lsvPList
      // 
      this.lsvPList.AutoSizeTable = false;
      this.lsvPList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.lsvPList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lsvPList.Depth = 0;
      this.lsvPList.FullRowSelect = true;
      this.lsvPList.HideSelection = false;
      this.lsvPList.Location = new System.Drawing.Point(577, 40);
      this.lsvPList.MinimumSize = new System.Drawing.Size(200, 100);
      this.lsvPList.MouseLocation = new System.Drawing.Point(-1, -1);
      this.lsvPList.MouseState = MaterialSkin.MouseState.OUT;
      this.lsvPList.Name = "lsvPList";
      this.lsvPList.OwnerDraw = true;
      this.lsvPList.Size = new System.Drawing.Size(200, 300);
      this.lsvPList.TabIndex = 5;
      this.lsvPList.UseCompatibleStateImageBehavior = false;
      this.lsvPList.View = System.Windows.Forms.View.List;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.tabSelector);
      this.Controls.Add(this.tabControl);
      this.Name = "Main";
      this.Text = "MSL 2.0";
      this.tabControl.ResumeLayout(false);
      this.tpgLog.ResumeLayout(false);
      this.tpgLog.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private MaterialSkin.Controls.MaterialTabControl tabControl;
    private System.Windows.Forms.TabPage tpgLog;
    private System.Windows.Forms.TabPage tpgSetting;
    private MaterialSkin.Controls.MaterialTabSelector tabSelector;
    private System.Windows.Forms.TabPage tpgPlgns;
    private MaterialSkin.Controls.MaterialButton btnStart;
    private MaterialSkin.Controls.MaterialMultiLineTextBox tbOutput;
    private MaterialSkin.Controls.MaterialTextBox tbInput;
    private MaterialSkin.Controls.MaterialButton btnInput;
    private MaterialSkin.Controls.MaterialProgressBar prbPInt;
    private MaterialSkin.Controls.MaterialLabel labPStr;
    private MaterialSkin.Controls.MaterialListView lsvPList;
  }
}

