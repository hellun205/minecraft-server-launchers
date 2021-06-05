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
      this.components = new System.ComponentModel.Container();
      this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
      this.tpgLog = new System.Windows.Forms.TabPage();
      this.lsvPList = new System.Windows.Forms.ListView();
      this.imlPlayer = new System.Windows.Forms.ImageList(this.components);
      this.labPStr = new MaterialSkin.Controls.MaterialLabel();
      this.prbPInt = new MaterialSkin.Controls.MaterialProgressBar();
      this.btnInput = new MaterialSkin.Controls.MaterialButton();
      this.tbInput = new MaterialSkin.Controls.MaterialTextBox();
      this.tbOutput = new MaterialSkin.Controls.MaterialMultiLineTextBox();
      this.tpgSetting = new System.Windows.Forms.TabPage();
      this.labFileEditorTitle = new MaterialSkin.Controls.MaterialLabel();
      this.btnFileEditorRefresh = new MaterialSkin.Controls.MaterialButton();
      this.pnFileEditor = new System.Windows.Forms.Panel();
      this.sliMaxRam = new MaterialSkin.Controls.MaterialSlider();
      this.sliMinRam = new MaterialSkin.Controls.MaterialSlider();
      this.btnBukkitFile = new System.Windows.Forms.Button();
      this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
      this.btnStart = new MaterialSkin.Controls.MaterialButton();
      this.ofd = new System.Windows.Forms.OpenFileDialog();
      this.lbServerStatus = new System.Windows.Forms.Label();
      this.tmStatus1 = new System.Windows.Forms.Timer(this.components);
      this.tmStatus2 = new System.Windows.Forms.Timer(this.components);
      this.prbRamUsg = new MaterialSkin.Controls.MaterialProgressBar();
      this.labRamUsg = new MaterialSkin.Controls.MaterialLabel();
      this.tabControl.SuspendLayout();
      this.tpgLog.SuspendLayout();
      this.tpgSetting.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.tpgLog);
      this.tabControl.Controls.Add(this.tpgSetting);
      this.tabControl.Depth = 0;
      this.tabControl.Location = new System.Drawing.Point(6, 68);
      this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
      this.tabControl.Multiline = true;
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(738, 348);
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
      this.tpgLog.Size = new System.Drawing.Size(730, 320);
      this.tpgLog.TabIndex = 0;
      this.tpgLog.Text = "Log";
      this.tpgLog.UseVisualStyleBackColor = true;
      // 
      // lsvPList
      // 
      this.lsvPList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lsvPList.FullRowSelect = true;
      this.lsvPList.HideSelection = false;
      this.lsvPList.LargeImageList = this.imlPlayer;
      this.lsvPList.Location = new System.Drawing.Point(527, 40);
      this.lsvPList.Name = "lsvPList";
      this.lsvPList.Size = new System.Drawing.Size(200, 271);
      this.lsvPList.SmallImageList = this.imlPlayer;
      this.lsvPList.TabIndex = 5;
      this.lsvPList.UseCompatibleStateImageBehavior = false;
      this.lsvPList.View = System.Windows.Forms.View.List;
      // 
      // imlPlayer
      // 
      this.imlPlayer.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
      this.imlPlayer.ImageSize = new System.Drawing.Size(16, 16);
      this.imlPlayer.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // labPStr
      // 
      this.labPStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labPStr.Depth = 0;
      this.labPStr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labPStr.Location = new System.Drawing.Point(527, 7);
      this.labPStr.MouseState = MaterialSkin.MouseState.HOVER;
      this.labPStr.Name = "labPStr";
      this.labPStr.Size = new System.Drawing.Size(200, 23);
      this.labPStr.TabIndex = 4;
      this.labPStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // prbPInt
      // 
      this.prbPInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.prbPInt.Depth = 0;
      this.prbPInt.Location = new System.Drawing.Point(527, 31);
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
      this.btnInput.Location = new System.Drawing.Point(457, 275);
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
      this.tbInput.Location = new System.Drawing.Point(3, 275);
      this.tbInput.MaxLength = 50;
      this.tbInput.MouseState = MaterialSkin.MouseState.OUT;
      this.tbInput.Multiline = false;
      this.tbInput.Name = "tbInput";
      this.tbInput.Size = new System.Drawing.Size(447, 36);
      this.tbInput.TabIndex = 1;
      this.tbInput.Text = "";
      this.tbInput.TrailingIcon = null;
      this.tbInput.UseTallSize = false;
      this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
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
      this.tbOutput.HideSelection = false;
      this.tbOutput.Location = new System.Drawing.Point(3, 3);
      this.tbOutput.MouseState = MaterialSkin.MouseState.HOVER;
      this.tbOutput.Name = "tbOutput";
      this.tbOutput.ReadOnly = true;
      this.tbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
      this.tbOutput.Size = new System.Drawing.Size(518, 266);
      this.tbOutput.TabIndex = 0;
      this.tbOutput.Text = "";
      // 
      // tpgSetting
      // 
      this.tpgSetting.Controls.Add(this.labFileEditorTitle);
      this.tpgSetting.Controls.Add(this.btnFileEditorRefresh);
      this.tpgSetting.Controls.Add(this.pnFileEditor);
      this.tpgSetting.Controls.Add(this.sliMaxRam);
      this.tpgSetting.Controls.Add(this.sliMinRam);
      this.tpgSetting.Controls.Add(this.btnBukkitFile);
      this.tpgSetting.Location = new System.Drawing.Point(4, 24);
      this.tpgSetting.Name = "tpgSetting";
      this.tpgSetting.Padding = new System.Windows.Forms.Padding(3);
      this.tpgSetting.Size = new System.Drawing.Size(730, 320);
      this.tpgSetting.TabIndex = 1;
      this.tpgSetting.Text = "Setting";
      this.tpgSetting.UseVisualStyleBackColor = true;
      // 
      // labFileEditorTitle
      // 
      this.labFileEditorTitle.Depth = 0;
      this.labFileEditorTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labFileEditorTitle.Location = new System.Drawing.Point(345, 6);
      this.labFileEditorTitle.MouseState = MaterialSkin.MouseState.HOVER;
      this.labFileEditorTitle.Name = "labFileEditorTitle";
      this.labFileEditorTitle.Size = new System.Drawing.Size(296, 23);
      this.labFileEditorTitle.TabIndex = 5;
      this.labFileEditorTitle.Text = "File Editor";
      // 
      // btnFileEditorRefresh
      // 
      this.btnFileEditorRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFileEditorRefresh.AutoSize = false;
      this.btnFileEditorRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnFileEditorRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      this.btnFileEditorRefresh.Depth = 0;
      this.btnFileEditorRefresh.HighEmphasis = true;
      this.btnFileEditorRefresh.Icon = null;
      this.btnFileEditorRefresh.Location = new System.Drawing.Point(648, 6);
      this.btnFileEditorRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnFileEditorRefresh.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnFileEditorRefresh.Name = "btnFileEditorRefresh";
      this.btnFileEditorRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnFileEditorRefresh.TabIndex = 4;
      this.btnFileEditorRefresh.Text = "Refresh";
      this.btnFileEditorRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      this.btnFileEditorRefresh.UseAccentColor = false;
      this.btnFileEditorRefresh.UseVisualStyleBackColor = true;
      this.btnFileEditorRefresh.Click += new System.EventHandler(this.btnFileEditorRefresh_Click);
      // 
      // pnFileEditor
      // 
      this.pnFileEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnFileEditor.Location = new System.Drawing.Point(345, 38);
      this.pnFileEditor.Name = "pnFileEditor";
      this.pnFileEditor.Size = new System.Drawing.Size(379, 276);
      this.pnFileEditor.TabIndex = 3;
      // 
      // sliMaxRam
      // 
      this.sliMaxRam.Depth = 0;
      this.sliMaxRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.sliMaxRam.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
      this.sliMaxRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.sliMaxRam.Location = new System.Drawing.Point(112, 11);
      this.sliMaxRam.MouseState = MaterialSkin.MouseState.HOVER;
      this.sliMaxRam.Name = "sliMaxRam";
      this.sliMaxRam.RangeMin = 1;
      this.sliMaxRam.Size = new System.Drawing.Size(227, 40);
      this.sliMaxRam.TabIndex = 2;
      this.sliMaxRam.Text = "Max Ram (GB)";
      this.sliMaxRam.Value = 1;
      this.sliMaxRam.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.sliMaxRam_onValueChanged);
      // 
      // sliMinRam
      // 
      this.sliMinRam.Depth = 0;
      this.sliMinRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.sliMinRam.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
      this.sliMinRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.sliMinRam.Location = new System.Drawing.Point(112, 57);
      this.sliMinRam.MouseState = MaterialSkin.MouseState.HOVER;
      this.sliMinRam.Name = "sliMinRam";
      this.sliMinRam.Size = new System.Drawing.Size(227, 40);
      this.sliMinRam.TabIndex = 1;
      this.sliMinRam.Text = "Min Ram (GB)";
      this.sliMinRam.Value = 1;
      this.sliMinRam.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.sliMinRam_onValueChanged);
      // 
      // btnBukkitFile
      // 
      this.btnBukkitFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBukkitFile.Location = new System.Drawing.Point(6, 6);
      this.btnBukkitFile.Name = "btnBukkitFile";
      this.btnBukkitFile.Size = new System.Drawing.Size(100, 100);
      this.btnBukkitFile.TabIndex = 0;
      this.btnBukkitFile.Text = "none";
      this.btnBukkitFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnBukkitFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnBukkitFile.UseVisualStyleBackColor = true;
      this.btnBukkitFile.Click += new System.EventHandler(this.btnBukkitFile_Click);
      // 
      // tabSelector
      // 
      this.tabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabSelector.BaseTabControl = this.tabControl;
      this.tabSelector.Depth = 0;
      this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.tabSelector.Location = new System.Drawing.Point(205, 27);
      this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
      this.tabSelector.Name = "tabSelector";
      this.tabSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.tabSelector.Size = new System.Drawing.Size(544, 35);
      this.tabSelector.TabIndex = 1;
      this.tabSelector.TabIndicatorHeight = 3;
      // 
      // btnStart
      // 
      this.btnStart.AutoSize = false;
      this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      this.btnStart.Depth = 0;
      this.btnStart.HighEmphasis = true;
      this.btnStart.Icon = null;
      this.btnStart.Location = new System.Drawing.Point(110, 26);
      this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(88, 36);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "Start";
      this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
      this.btnStart.UseAccentColor = false;
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // ofd
      // 
      this.ofd.Filter = "Jar File|*.jar";
      this.ofd.InitialDirectory = "./server";
      // 
      // lbServerStatus
      // 
      this.lbServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lbServerStatus.BackColor = System.Drawing.Color.Transparent;
      this.lbServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lbServerStatus.ForeColor = System.Drawing.Color.Red;
      this.lbServerStatus.Location = new System.Drawing.Point(628, 3);
      this.lbServerStatus.Name = "lbServerStatus";
      this.lbServerStatus.Size = new System.Drawing.Size(44, 18);
      this.lbServerStatus.TabIndex = 2;
      this.lbServerStatus.Text = "OFF";
      this.lbServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tmStatus1
      // 
      this.tmStatus1.Enabled = true;
      this.tmStatus1.Interval = 500;
      this.tmStatus1.Tick += new System.EventHandler(this.tmStatus1_Tick);
      // 
      // tmStatus2
      // 
      this.tmStatus2.Tick += new System.EventHandler(this.tmStatus2_Tick);
      // 
      // prbRamUsg
      // 
      this.prbRamUsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.prbRamUsg.Depth = 0;
      this.prbRamUsg.Location = new System.Drawing.Point(6, 419);
      this.prbRamUsg.MouseState = MaterialSkin.MouseState.HOVER;
      this.prbRamUsg.Name = "prbRamUsg";
      this.prbRamUsg.Size = new System.Drawing.Size(601, 5);
      this.prbRamUsg.TabIndex = 6;
      // 
      // labRamUsg
      // 
      this.labRamUsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.labRamUsg.AutoEllipsis = true;
      this.labRamUsg.Depth = 0;
      this.labRamUsg.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labRamUsg.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
      this.labRamUsg.Location = new System.Drawing.Point(613, 414);
      this.labRamUsg.MouseState = MaterialSkin.MouseState.HOVER;
      this.labRamUsg.Name = "labRamUsg";
      this.labRamUsg.Size = new System.Drawing.Size(130, 13);
      this.labRamUsg.TabIndex = 7;
      this.labRamUsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(750, 430);
      this.Controls.Add(this.labRamUsg);
      this.Controls.Add(this.prbRamUsg);
      this.Controls.Add(this.lbServerStatus);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.tabSelector);
      this.Controls.Add(this.tabControl);
      this.MinimumSize = new System.Drawing.Size(600, 275);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MSL 2.0";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
      this.tabControl.ResumeLayout(false);
      this.tpgLog.ResumeLayout(false);
      this.tpgLog.PerformLayout();
      this.tpgSetting.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MaterialSkin.Controls.MaterialTabControl tabControl;
    private System.Windows.Forms.TabPage tpgSetting;
    private MaterialSkin.Controls.MaterialTabSelector tabSelector;
    private MaterialSkin.Controls.MaterialButton btnStart;
    private System.Windows.Forms.TabPage tpgLog;
    private MaterialSkin.Controls.MaterialLabel labPStr;
    private MaterialSkin.Controls.MaterialProgressBar prbPInt;
    private MaterialSkin.Controls.MaterialButton btnInput;
    private MaterialSkin.Controls.MaterialTextBox tbInput;
    private MaterialSkin.Controls.MaterialMultiLineTextBox tbOutput;
    private System.Windows.Forms.Button btnBukkitFile;
    private System.Windows.Forms.OpenFileDialog ofd;
    private MaterialSkin.Controls.MaterialSlider sliMinRam;
    private MaterialSkin.Controls.MaterialSlider sliMaxRam;
    private System.Windows.Forms.Panel pnFileEditor;
    private MaterialSkin.Controls.MaterialLabel labFileEditorTitle;
    private MaterialSkin.Controls.MaterialButton btnFileEditorRefresh;
    private System.Windows.Forms.Label lbServerStatus;
    private System.Windows.Forms.Timer tmStatus1;
    private System.Windows.Forms.Timer tmStatus2;
    private MaterialSkin.Controls.MaterialProgressBar prbRamUsg;
    private MaterialSkin.Controls.MaterialLabel labRamUsg;
    private System.Windows.Forms.ImageList imlPlayer;
    private System.Windows.Forms.ListView lsvPList;
  }
}

