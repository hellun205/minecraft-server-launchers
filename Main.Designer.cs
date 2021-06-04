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
      this.lsvPList = new MaterialSkin.Controls.MaterialListView();
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
      this.tabControl.Location = new System.Drawing.Point(6, 70);
      this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
      this.tabControl.Multiline = true;
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(738, 363);
      this.tabControl.TabIndex = 0;
      this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
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
      this.tpgLog.Size = new System.Drawing.Size(730, 335);
      this.tpgLog.TabIndex = 0;
      this.tpgLog.Text = "Log";
      this.tpgLog.UseVisualStyleBackColor = true;
      this.tpgLog.Click += new System.EventHandler(this.tpgLog_Click);
      // 
      // lsvPList
      // 
      this.lsvPList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lsvPList.AutoSizeTable = false;
      this.lsvPList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.lsvPList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lsvPList.Depth = 0;
      this.lsvPList.FullRowSelect = true;
      this.lsvPList.HideSelection = false;
      this.lsvPList.Location = new System.Drawing.Point(527, 40);
      this.lsvPList.MinimumSize = new System.Drawing.Size(200, 100);
      this.lsvPList.MouseLocation = new System.Drawing.Point(-1, -1);
      this.lsvPList.MouseState = MaterialSkin.MouseState.OUT;
      this.lsvPList.Name = "lsvPList";
      this.lsvPList.OwnerDraw = true;
      this.lsvPList.Size = new System.Drawing.Size(200, 289);
      this.lsvPList.TabIndex = 5;
      this.lsvPList.UseCompatibleStateImageBehavior = false;
      this.lsvPList.View = System.Windows.Forms.View.Details;
      // 
      // labPStr
      // 
      this.labPStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labPStr.Depth = 0;
      this.labPStr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labPStr.Location = new System.Drawing.Point(527, 14);
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
      this.prbPInt.Location = new System.Drawing.Point(527, 6);
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
      this.btnInput.Location = new System.Drawing.Point(457, 290);
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
      this.tbInput.Location = new System.Drawing.Point(3, 290);
      this.tbInput.MaxLength = 50;
      this.tbInput.MouseState = MaterialSkin.MouseState.OUT;
      this.tbInput.Multiline = false;
      this.tbInput.Name = "tbInput";
      this.tbInput.Size = new System.Drawing.Size(447, 36);
      this.tbInput.TabIndex = 1;
      this.tbInput.Text = "";
      this.tbInput.TrailingIcon = null;
      this.tbInput.UseTallSize = false;
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
      this.tbOutput.Size = new System.Drawing.Size(518, 281);
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
      this.tpgSetting.Size = new System.Drawing.Size(730, 335);
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
      this.pnFileEditor.Size = new System.Drawing.Size(379, 291);
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
      this.tabSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.tabSelector.Size = new System.Drawing.Size(578, 35);
      this.tabSelector.TabIndex = 1;
      this.tabSelector.TabIndicatorHeight = 3;
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
      // ofd
      // 
      this.ofd.FileName = "openFileDialog1";
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(750, 430);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.tabSelector);
      this.Controls.Add(this.tabControl);
      this.MinimumSize = new System.Drawing.Size(600, 275);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MSL 2.0";
      this.Load += new System.EventHandler(this.Main_Load);
      this.tabControl.ResumeLayout(false);
      this.tpgLog.ResumeLayout(false);
      this.tpgLog.PerformLayout();
      this.tpgSetting.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private MaterialSkin.Controls.MaterialTabControl tabControl;
    private System.Windows.Forms.TabPage tpgSetting;
    private MaterialSkin.Controls.MaterialTabSelector tabSelector;
    private MaterialSkin.Controls.MaterialButton btnStart;
    private System.Windows.Forms.TabPage tpgLog;
    private MaterialSkin.Controls.MaterialListView lsvPList;
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
  }
}

