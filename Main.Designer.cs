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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
      this.labPlugins = new MaterialSkin.Controls.MaterialLabel();
      this.pnPlugins = new System.Windows.Forms.Panel();
      this.lsvPlugins = new System.Windows.Forms.ListView();
      this.cmsPlugins = new MaterialSkin.Controls.MaterialContextMenuStrip();
      this.tsiOPF = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPluginDelete2 = new System.Windows.Forms.ToolStripMenuItem();
      this.imlPlugins = new System.Windows.Forms.ImageList(this.components);
      this.msPlugins = new System.Windows.Forms.MenuStrip();
      this.tsiPluginsRefresh = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPluginsAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPluginsDelete = new System.Windows.Forms.ToolStripMenuItem();
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
      this.ofdPlugins = new System.Windows.Forms.OpenFileDialog();
      this.tabControl.SuspendLayout();
      this.tpgLog.SuspendLayout();
      this.tpgSetting.SuspendLayout();
      this.pnPlugins.SuspendLayout();
      this.cmsPlugins.SuspendLayout();
      this.msPlugins.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.tpgLog);
      this.tabControl.Controls.Add(this.tpgSetting);
      this.tabControl.Depth = 0;
      this.tabControl.Location = new System.Drawing.Point(6, 54);
      this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
      this.tabControl.Multiline = true;
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(738, 278);
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
      this.tpgLog.Location = new System.Drawing.Point(4, 22);
      this.tpgLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgLog.Name = "tpgLog";
      this.tpgLog.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgLog.Size = new System.Drawing.Size(730, 252);
      this.tpgLog.TabIndex = 0;
      this.tpgLog.Text = "Log";
      this.tpgLog.UseVisualStyleBackColor = true;
      // 
      // lsvPList
      // 
      this.lsvPList.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
      this.lsvPList.FullRowSelect = true;
      this.lsvPList.HideSelection = false;
      this.lsvPList.LargeImageList = this.imlPlayer;
      this.lsvPList.Location = new System.Drawing.Point(527, 32);
      this.lsvPList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lsvPList.Name = "lsvPList";
      this.lsvPList.Size = new System.Drawing.Size(200, 219);
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
      this.labPStr.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labPStr.Depth = 0;
      this.labPStr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labPStr.Location = new System.Drawing.Point(527, 6);
      this.labPStr.MouseState = MaterialSkin.MouseState.HOVER;
      this.labPStr.Name = "labPStr";
      this.labPStr.Size = new System.Drawing.Size(200, 18);
      this.labPStr.TabIndex = 4;
      this.labPStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // prbPInt
      // 
      this.prbPInt.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.prbPInt.Depth = 0;
      this.prbPInt.Location = new System.Drawing.Point(527, 25);
      this.prbPInt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.prbPInt.MouseState = MaterialSkin.MouseState.HOVER;
      this.prbPInt.Name = "prbPInt";
      this.prbPInt.Size = new System.Drawing.Size(200, 5);
      this.prbPInt.TabIndex = 3;
      // 
      // btnInput
      // 
      this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnInput.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      this.btnInput.Depth = 0;
      this.btnInput.HighEmphasis = true;
      this.btnInput.Icon = null;
      this.btnInput.Location = new System.Drawing.Point(457, 215);
      this.btnInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
      this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbInput.Depth = 0;
      this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.tbInput.Hint = "Input command...";
      this.tbInput.LeadingIcon = null;
      this.tbInput.Location = new System.Drawing.Point(3, 222);
      this.tbInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
      this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.tbOutput.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
      this.tbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbOutput.Depth = 0;
      this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
      this.tbOutput.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
      this.tbOutput.HideSelection = false;
      this.tbOutput.Location = new System.Drawing.Point(3, 2);
      this.tbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbOutput.MouseState = MaterialSkin.MouseState.HOVER;
      this.tbOutput.Name = "tbOutput";
      this.tbOutput.ReadOnly = true;
      this.tbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
      this.tbOutput.Size = new System.Drawing.Size(518, 214);
      this.tbOutput.TabIndex = 0;
      this.tbOutput.Text = "";
      // 
      // tpgSetting
      // 
      this.tpgSetting.Controls.Add(this.labPlugins);
      this.tpgSetting.Controls.Add(this.pnPlugins);
      this.tpgSetting.Controls.Add(this.labFileEditorTitle);
      this.tpgSetting.Controls.Add(this.btnFileEditorRefresh);
      this.tpgSetting.Controls.Add(this.pnFileEditor);
      this.tpgSetting.Controls.Add(this.sliMaxRam);
      this.tpgSetting.Controls.Add(this.sliMinRam);
      this.tpgSetting.Controls.Add(this.btnBukkitFile);
      this.tpgSetting.Location = new System.Drawing.Point(4, 22);
      this.tpgSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgSetting.Name = "tpgSetting";
      this.tpgSetting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgSetting.Size = new System.Drawing.Size(730, 252);
      this.tpgSetting.TabIndex = 1;
      this.tpgSetting.Text = "Setting";
      this.tpgSetting.UseVisualStyleBackColor = true;
      // 
      // labPlugins
      // 
      this.labPlugins.Depth = 0;
      this.labPlugins.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labPlugins.Location = new System.Drawing.Point(6, 88);
      this.labPlugins.MouseState = MaterialSkin.MouseState.HOVER;
      this.labPlugins.Name = "labPlugins";
      this.labPlugins.Size = new System.Drawing.Size(333, 18);
      this.labPlugins.TabIndex = 7;
      this.labPlugins.Text = "Plugins";
      // 
      // pnPlugins
      // 
      this.pnPlugins.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
      this.pnPlugins.Controls.Add(this.lsvPlugins);
      this.pnPlugins.Controls.Add(this.msPlugins);
      this.pnPlugins.Location = new System.Drawing.Point(6, 109);
      this.pnPlugins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnPlugins.Name = "pnPlugins";
      this.pnPlugins.Size = new System.Drawing.Size(333, 144);
      this.pnPlugins.TabIndex = 6;
      // 
      // lsvPlugins
      // 
      this.lsvPlugins.AllowDrop = true;
      this.lsvPlugins.ContextMenuStrip = this.cmsPlugins;
      this.lsvPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lsvPlugins.HideSelection = false;
      this.lsvPlugins.LargeImageList = this.imlPlugins;
      this.lsvPlugins.Location = new System.Drawing.Point(0, 24);
      this.lsvPlugins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lsvPlugins.Name = "lsvPlugins";
      this.lsvPlugins.Size = new System.Drawing.Size(333, 120);
      this.lsvPlugins.SmallImageList = this.imlPlugins;
      this.lsvPlugins.TabIndex = 1;
      this.lsvPlugins.UseCompatibleStateImageBehavior = false;
      this.lsvPlugins.DragDrop += new System.Windows.Forms.DragEventHandler(this.lsvPlugins_DragDrop);
      this.lsvPlugins.DragEnter += new System.Windows.Forms.DragEventHandler(this.lsvPlugins_DragEnter);
      // 
      // cmsPlugins
      // 
      this.cmsPlugins.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
      this.cmsPlugins.Depth = 0;
      this.cmsPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsiOPF, this.tsiPluginDelete2});
      this.cmsPlugins.MouseState = MaterialSkin.MouseState.HOVER;
      this.cmsPlugins.Name = "cmsPlugins";
      this.cmsPlugins.Size = new System.Drawing.Size(185, 48);
      // 
      // tsiOPF
      // 
      this.tsiOPF.Name = "tsiOPF";
      this.tsiOPF.Size = new System.Drawing.Size(184, 22);
      this.tsiOPF.Text = "Open plugin\'s folder";
      this.tsiOPF.Click += new System.EventHandler(this.tsiOPF_Click);
      // 
      // tsiPluginDelete2
      // 
      this.tsiPluginDelete2.Name = "tsiPluginDelete2";
      this.tsiPluginDelete2.Size = new System.Drawing.Size(184, 22);
      this.tsiPluginDelete2.Text = "Delete";
      this.tsiPluginDelete2.Click += new System.EventHandler(this.DPlugins);
      // 
      // imlPlugins
      // 
      this.imlPlugins.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
      this.imlPlugins.ImageSize = new System.Drawing.Size(32, 32);
      this.imlPlugins.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // msPlugins
      // 
      this.msPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsiPluginsRefresh, this.tsiPluginsAdd, this.tsiPluginsDelete});
      this.msPlugins.Location = new System.Drawing.Point(0, 0);
      this.msPlugins.Name = "msPlugins";
      this.msPlugins.Size = new System.Drawing.Size(333, 24);
      this.msPlugins.TabIndex = 0;
      this.msPlugins.Text = "menuStrip1";
      // 
      // tsiPluginsRefresh
      // 
      this.tsiPluginsRefresh.Name = "tsiPluginsRefresh";
      this.tsiPluginsRefresh.Size = new System.Drawing.Size(58, 20);
      this.tsiPluginsRefresh.Text = "Refresh";
      // 
      // tsiPluginsAdd
      // 
      this.tsiPluginsAdd.Name = "tsiPluginsAdd";
      this.tsiPluginsAdd.Size = new System.Drawing.Size(41, 20);
      this.tsiPluginsAdd.Text = "Add";
      this.tsiPluginsAdd.Click += new System.EventHandler(this.tsiPluginsAdd_Click);
      // 
      // tsiPluginsDelete
      // 
      this.tsiPluginsDelete.Name = "tsiPluginsDelete";
      this.tsiPluginsDelete.Size = new System.Drawing.Size(53, 20);
      this.tsiPluginsDelete.Text = "Delete";
      this.tsiPluginsDelete.Click += new System.EventHandler(this.DPlugins);
      // 
      // labFileEditorTitle
      // 
      this.labFileEditorTitle.Depth = 0;
      this.labFileEditorTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labFileEditorTitle.Location = new System.Drawing.Point(345, 5);
      this.labFileEditorTitle.MouseState = MaterialSkin.MouseState.HOVER;
      this.labFileEditorTitle.Name = "labFileEditorTitle";
      this.labFileEditorTitle.Size = new System.Drawing.Size(296, 18);
      this.labFileEditorTitle.TabIndex = 5;
      this.labFileEditorTitle.Text = "File Editor";
      // 
      // btnFileEditorRefresh
      // 
      this.btnFileEditorRefresh.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFileEditorRefresh.AutoSize = false;
      this.btnFileEditorRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnFileEditorRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      this.btnFileEditorRefresh.Depth = 0;
      this.btnFileEditorRefresh.HighEmphasis = true;
      this.btnFileEditorRefresh.Icon = null;
      this.btnFileEditorRefresh.Location = new System.Drawing.Point(648, 5);
      this.btnFileEditorRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnFileEditorRefresh.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnFileEditorRefresh.Name = "btnFileEditorRefresh";
      this.btnFileEditorRefresh.Size = new System.Drawing.Size(75, 18);
      this.btnFileEditorRefresh.TabIndex = 4;
      this.btnFileEditorRefresh.Text = "Refresh";
      this.btnFileEditorRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      this.btnFileEditorRefresh.UseAccentColor = false;
      this.btnFileEditorRefresh.UseVisualStyleBackColor = true;
      this.btnFileEditorRefresh.Click += new System.EventHandler(this.btnFileEditorRefresh_Click);
      // 
      // pnFileEditor
      // 
      this.pnFileEditor.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.pnFileEditor.Location = new System.Drawing.Point(345, 30);
      this.pnFileEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnFileEditor.Name = "pnFileEditor";
      this.pnFileEditor.Size = new System.Drawing.Size(379, 222);
      this.pnFileEditor.TabIndex = 3;
      // 
      // sliMaxRam
      // 
      this.sliMaxRam.Depth = 0;
      this.sliMaxRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.sliMaxRam.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
      this.sliMaxRam.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
      this.sliMaxRam.Location = new System.Drawing.Point(112, 9);
      this.sliMaxRam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
      this.sliMinRam.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
      this.sliMinRam.Location = new System.Drawing.Point(112, 46);
      this.sliMinRam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
      this.btnBukkitFile.Location = new System.Drawing.Point(6, 5);
      this.btnBukkitFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnBukkitFile.Name = "btnBukkitFile";
      this.btnBukkitFile.Size = new System.Drawing.Size(100, 80);
      this.btnBukkitFile.TabIndex = 0;
      this.btnBukkitFile.Text = "none";
      this.btnBukkitFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnBukkitFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnBukkitFile.UseVisualStyleBackColor = true;
      this.btnBukkitFile.Click += new System.EventHandler(this.btnBukkitFile_Click);
      // 
      // tabSelector
      // 
      this.tabSelector.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.tabSelector.BaseTabControl = this.tabControl;
      this.tabSelector.Depth = 0;
      this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.tabSelector.Location = new System.Drawing.Point(205, 22);
      this.tabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
      this.tabSelector.Name = "tabSelector";
      this.tabSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.tabSelector.Size = new System.Drawing.Size(544, 28);
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
      this.btnStart.Location = new System.Drawing.Point(110, 21);
      this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(88, 29);
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
      this.lbServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lbServerStatus.BackColor = System.Drawing.Color.Transparent;
      this.lbServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lbServerStatus.ForeColor = System.Drawing.Color.Red;
      this.lbServerStatus.Location = new System.Drawing.Point(628, 2);
      this.lbServerStatus.Name = "lbServerStatus";
      this.lbServerStatus.Size = new System.Drawing.Size(44, 14);
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
      this.prbRamUsg.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.prbRamUsg.Depth = 0;
      this.prbRamUsg.Location = new System.Drawing.Point(6, 335);
      this.prbRamUsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.prbRamUsg.MouseState = MaterialSkin.MouseState.HOVER;
      this.prbRamUsg.Name = "prbRamUsg";
      this.prbRamUsg.Size = new System.Drawing.Size(601, 5);
      this.prbRamUsg.TabIndex = 6;
      // 
      // labRamUsg
      // 
      this.labRamUsg.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.labRamUsg.AutoEllipsis = true;
      this.labRamUsg.Depth = 0;
      this.labRamUsg.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labRamUsg.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
      this.labRamUsg.Location = new System.Drawing.Point(613, 331);
      this.labRamUsg.MouseState = MaterialSkin.MouseState.HOVER;
      this.labRamUsg.Name = "labRamUsg";
      this.labRamUsg.Size = new System.Drawing.Size(130, 10);
      this.labRamUsg.TabIndex = 7;
      this.labRamUsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ofdPlugins
      // 
      this.ofdPlugins.Filter = "Jar File|*.jar";
      this.ofdPlugins.InitialDirectory = "./server/plugins";
      this.ofdPlugins.Multiselect = true;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(750, 344);
      this.Controls.Add(this.labRamUsg);
      this.Controls.Add(this.prbRamUsg);
      this.Controls.Add(this.lbServerStatus);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.tabSelector);
      this.Controls.Add(this.tabControl);
      this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.msPlugins;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MinimumSize = new System.Drawing.Size(600, 220);
      this.Name = "Main";
      this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MSL 2.1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
      this.tabControl.ResumeLayout(false);
      this.tpgLog.ResumeLayout(false);
      this.tpgLog.PerformLayout();
      this.tpgSetting.ResumeLayout(false);
      this.pnPlugins.ResumeLayout(false);
      this.pnPlugins.PerformLayout();
      this.cmsPlugins.ResumeLayout(false);
      this.msPlugins.ResumeLayout(false);
      this.msPlugins.PerformLayout();
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
    private MaterialSkin.Controls.MaterialLabel labPlugins;
    private System.Windows.Forms.Panel pnPlugins;
    private System.Windows.Forms.MenuStrip msPlugins;
    private System.Windows.Forms.ListView lsvPlugins;
    private System.Windows.Forms.ToolStripMenuItem tsiPluginsRefresh;
    private System.Windows.Forms.ToolStripMenuItem tsiPluginsAdd;
    private System.Windows.Forms.ToolStripMenuItem tsiPluginsDelete;
    private System.Windows.Forms.ImageList imlPlugins;
    private MaterialSkin.Controls.MaterialContextMenuStrip cmsPlugins;
    private System.Windows.Forms.ToolStripMenuItem tsiOPF;
    private System.Windows.Forms.ToolStripMenuItem tsiPluginDelete2;
    private System.Windows.Forms.OpenFileDialog ofdPlugins;
  }
}

