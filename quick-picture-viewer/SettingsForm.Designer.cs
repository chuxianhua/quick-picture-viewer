﻿namespace quick_picture_viewer
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			this.settingsTabs = new QuickLibrary.QlibTabs();
			this.themePage = new System.Windows.Forms.TabPage();
			this.restartLabel1 = new System.Windows.Forms.Label();
			this.systemThemeRadio = new QuickLibrary.QlibRadio();
			this.darkThemeRadio = new QuickLibrary.QlibRadio();
			this.lightThemeRadio = new QuickLibrary.QlibRadio();
			this.themeRestart = new System.Windows.Forms.LinkLabel();
			this.mousePage = new System.Windows.Forms.TabPage();
			this.mouseWheelActionRadio3 = new QuickLibrary.QlibRadio();
			this.mouseWheelActionRadio2 = new QuickLibrary.QlibRadio();
			this.mouseWheelActionRadio1 = new QuickLibrary.QlibRadio();
			this.mouseWheelActionLabel = new System.Windows.Forms.Label();
			this.escToExitCheckBox = new QuickLibrary.QlibCheckBox();
			this.fullscrCursorCheckBox = new QuickLibrary.QlibCheckBox();
			this.slideshowPage = new System.Windows.Forms.TabPage();
			this.slideshowSecondsLabel = new System.Windows.Forms.Label();
			this.slideshowTimeLabel = new System.Windows.Forms.Label();
			this.slideshowTimeNumeric = new QuickLibrary.QlibNumeric();
			this.slideshowCounterCheckBox = new QuickLibrary.QlibCheckBox();
			this.startupPage = new System.Windows.Forms.TabPage();
			this.startupBoundsCheckBox = new QuickLibrary.QlibCheckBox();
			this.updatesCheckBox = new QuickLibrary.QlibCheckBox();
			this.startupMaximizeCheckBox = new QuickLibrary.QlibCheckBox();
			this.startupPasteCheckBox = new QuickLibrary.QlibCheckBox();
			this.startupLabel = new System.Windows.Forms.Label();
			this.externalPage = new System.Windows.Forms.TabPage();
			this.browseWithCheckBox = new QuickLibrary.QlibCheckBox();
			this.contextMenuLabel = new System.Windows.Forms.Label();
			this.openWithCheckBox = new QuickLibrary.QlibCheckBox();
			this.browseBtn = new System.Windows.Forms.Button();
			this.favExtTextBox = new QuickLibrary.QlibTextBox();
			this.favExtLabel = new System.Windows.Forms.Label();
			this.langPage = new System.Windows.Forms.TabPage();
			this.translateAuthorsPanel = new System.Windows.Forms.Panel();
			this.translatedByLabel = new System.Windows.Forms.Label();
			this.langLabel = new System.Windows.Forms.Label();
			this.restartLabel2 = new System.Windows.Forms.Label();
			this.langComboBox = new QuickLibrary.QlibComboBox();
			this.localizationRestart = new System.Windows.Forms.LinkLabel();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.titleLabel = new System.Windows.Forms.Label();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.settingsTabs.SuspendLayout();
			this.themePage.SuspendLayout();
			this.mousePage.SuspendLayout();
			this.slideshowPage.SuspendLayout();
			this.startupPage.SuspendLayout();
			this.externalPage.SuspendLayout();
			this.langPage.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// settingsTabs
			// 
			this.settingsTabs.Controls.Add(this.themePage);
			this.settingsTabs.Controls.Add(this.mousePage);
			this.settingsTabs.Controls.Add(this.slideshowPage);
			this.settingsTabs.Controls.Add(this.startupPage);
			this.settingsTabs.Controls.Add(this.externalPage);
			this.settingsTabs.Controls.Add(this.langPage);
			this.settingsTabs.DarkMode = false;
			this.settingsTabs.Location = new System.Drawing.Point(10, 42);
			this.settingsTabs.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.settingsTabs.Name = "settingsTabs";
			this.settingsTabs.Padding = new System.Drawing.Point(0, 0);
			this.settingsTabs.SelectedIndex = 0;
			this.settingsTabs.Size = new System.Drawing.Size(370, 290);
			this.settingsTabs.TabIndex = 1;
			// 
			// themePage
			// 
			this.themePage.BackColor = System.Drawing.SystemColors.Control;
			this.themePage.Controls.Add(this.restartLabel1);
			this.themePage.Controls.Add(this.systemThemeRadio);
			this.themePage.Controls.Add(this.darkThemeRadio);
			this.themePage.Controls.Add(this.lightThemeRadio);
			this.themePage.Controls.Add(this.themeRestart);
			this.themePage.Location = new System.Drawing.Point(4, 52);
			this.themePage.Margin = new System.Windows.Forms.Padding(0);
			this.themePage.Name = "themePage";
			this.themePage.Padding = new System.Windows.Forms.Padding(10);
			this.themePage.Size = new System.Drawing.Size(362, 234);
			this.themePage.TabIndex = 0;
			this.themePage.Text = "theme";
			this.themePage.ToolTipText = "App theming";
			// 
			// restartLabel1
			// 
			this.restartLabel1.AutoSize = true;
			this.restartLabel1.Location = new System.Drawing.Point(10, 197);
			this.restartLabel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.restartLabel1.Name = "restartLabel1";
			this.restartLabel1.Size = new System.Drawing.Size(114, 19);
			this.restartLabel1.TabIndex = 38;
			this.restartLabel1.Text = "* restart required";
			// 
			// systemThemeRadio
			// 
			this.systemThemeRadio.Checked = true;
			this.systemThemeRadio.DarkMode = false;
			this.systemThemeRadio.Location = new System.Drawing.Point(10, 10);
			this.systemThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.systemThemeRadio.Name = "systemThemeRadio";
			this.systemThemeRadio.Size = new System.Drawing.Size(342, 32);
			this.systemThemeRadio.TabIndex = 0;
			this.systemThemeRadio.TabStop = true;
			this.systemThemeRadio.Text = "system";
			this.systemThemeRadio.UseVisualStyleBackColor = true;
			this.systemThemeRadio.CheckedChanged += new System.EventHandler(this.systemThemeRadio_CheckedChanged);
			// 
			// darkThemeRadio
			// 
			this.darkThemeRadio.DarkMode = false;
			this.darkThemeRadio.Location = new System.Drawing.Point(10, 74);
			this.darkThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.darkThemeRadio.Name = "darkThemeRadio";
			this.darkThemeRadio.Size = new System.Drawing.Size(342, 32);
			this.darkThemeRadio.TabIndex = 2;
			this.darkThemeRadio.Text = "dark";
			this.darkThemeRadio.UseVisualStyleBackColor = true;
			this.darkThemeRadio.CheckedChanged += new System.EventHandler(this.darkThemeRadio_CheckedChanged);
			// 
			// lightThemeRadio
			// 
			this.lightThemeRadio.DarkMode = false;
			this.lightThemeRadio.Location = new System.Drawing.Point(10, 42);
			this.lightThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.lightThemeRadio.Name = "lightThemeRadio";
			this.lightThemeRadio.Size = new System.Drawing.Size(342, 32);
			this.lightThemeRadio.TabIndex = 1;
			this.lightThemeRadio.Text = "light";
			this.lightThemeRadio.UseVisualStyleBackColor = true;
			this.lightThemeRadio.CheckedChanged += new System.EventHandler(this.lightThemeRadio_CheckedChanged);
			// 
			// themeRestart
			// 
			this.themeRestart.Location = new System.Drawing.Point(10, 197);
			this.themeRestart.Margin = new System.Windows.Forms.Padding(0);
			this.themeRestart.Name = "themeRestart";
			this.themeRestart.Size = new System.Drawing.Size(342, 19);
			this.themeRestart.TabIndex = 39;
			this.themeRestart.TabStop = true;
			this.themeRestart.Text = "restart";
			this.themeRestart.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.themeRestart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.restartLink_LinkClicked);
			// 
			// mousePage
			// 
			this.mousePage.BackColor = System.Drawing.SystemColors.Control;
			this.mousePage.Controls.Add(this.mouseWheelActionRadio3);
			this.mousePage.Controls.Add(this.mouseWheelActionRadio2);
			this.mousePage.Controls.Add(this.mouseWheelActionRadio1);
			this.mousePage.Controls.Add(this.mouseWheelActionLabel);
			this.mousePage.Controls.Add(this.escToExitCheckBox);
			this.mousePage.Controls.Add(this.fullscrCursorCheckBox);
			this.mousePage.Location = new System.Drawing.Point(4, 52);
			this.mousePage.Margin = new System.Windows.Forms.Padding(0);
			this.mousePage.Name = "mousePage";
			this.mousePage.Padding = new System.Windows.Forms.Padding(10);
			this.mousePage.Size = new System.Drawing.Size(362, 234);
			this.mousePage.TabIndex = 2;
			this.mousePage.Text = "mouse & keyboard";
			this.mousePage.ToolTipText = "Cursor options";
			// 
			// mouseWheelActionRadio3
			// 
			this.mouseWheelActionRadio3.DarkMode = false;
			this.mouseWheelActionRadio3.Location = new System.Drawing.Point(10, 177);
			this.mouseWheelActionRadio3.Margin = new System.Windows.Forms.Padding(0);
			this.mouseWheelActionRadio3.Name = "mouseWheelActionRadio3";
			this.mouseWheelActionRadio3.Size = new System.Drawing.Size(342, 32);
			this.mouseWheelActionRadio3.TabIndex = 45;
			this.mouseWheelActionRadio3.Text = "next / previous image";
			this.mouseWheelActionRadio3.UseVisualStyleBackColor = true;
			this.mouseWheelActionRadio3.CheckedChanged += new System.EventHandler(this.mouseWheelActionRadio3_CheckedChanged);
			// 
			// mouseWheelActionRadio2
			// 
			this.mouseWheelActionRadio2.DarkMode = false;
			this.mouseWheelActionRadio2.Location = new System.Drawing.Point(10, 145);
			this.mouseWheelActionRadio2.Margin = new System.Windows.Forms.Padding(0);
			this.mouseWheelActionRadio2.Name = "mouseWheelActionRadio2";
			this.mouseWheelActionRadio2.Size = new System.Drawing.Size(342, 32);
			this.mouseWheelActionRadio2.TabIndex = 44;
			this.mouseWheelActionRadio2.Text = "zoom in / out";
			this.mouseWheelActionRadio2.UseVisualStyleBackColor = true;
			this.mouseWheelActionRadio2.CheckedChanged += new System.EventHandler(this.mouseWheelActionRadio2_CheckedChanged);
			// 
			// mouseWheelActionRadio1
			// 
			this.mouseWheelActionRadio1.Checked = true;
			this.mouseWheelActionRadio1.DarkMode = false;
			this.mouseWheelActionRadio1.Location = new System.Drawing.Point(10, 113);
			this.mouseWheelActionRadio1.Margin = new System.Windows.Forms.Padding(0);
			this.mouseWheelActionRadio1.Name = "mouseWheelActionRadio1";
			this.mouseWheelActionRadio1.Size = new System.Drawing.Size(342, 32);
			this.mouseWheelActionRadio1.TabIndex = 43;
			this.mouseWheelActionRadio1.TabStop = true;
			this.mouseWheelActionRadio1.Text = "scroll up / down";
			this.mouseWheelActionRadio1.UseVisualStyleBackColor = true;
			this.mouseWheelActionRadio1.CheckedChanged += new System.EventHandler(this.mouseWheelActionRadio1_CheckedChanged);
			// 
			// mouseWheelActionLabel
			// 
			this.mouseWheelActionLabel.AutoSize = true;
			this.mouseWheelActionLabel.Location = new System.Drawing.Point(10, 84);
			this.mouseWheelActionLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.mouseWheelActionLabel.Name = "mouseWheelActionLabel";
			this.mouseWheelActionLabel.Size = new System.Drawing.Size(168, 19);
			this.mouseWheelActionLabel.TabIndex = 42;
			this.mouseWheelActionLabel.Text = "mouse wheel scroll action:";
			// 
			// escToExitCheckBox
			// 
			this.escToExitCheckBox.DarkMode = false;
			this.escToExitCheckBox.Location = new System.Drawing.Point(10, 42);
			this.escToExitCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.escToExitCheckBox.Name = "escToExitCheckBox";
			this.escToExitCheckBox.Size = new System.Drawing.Size(342, 32);
			this.escToExitCheckBox.TabIndex = 3;
			this.escToExitCheckBox.Text = "press esc to exit";
			this.escToExitCheckBox.UseVisualStyleBackColor = true;
			this.escToExitCheckBox.CheckedChanged += new System.EventHandler(this.escToExitCheckBox_CheckedChanged);
			// 
			// fullscrCursorCheckBox
			// 
			this.fullscrCursorCheckBox.DarkMode = false;
			this.fullscrCursorCheckBox.Location = new System.Drawing.Point(10, 10);
			this.fullscrCursorCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.fullscrCursorCheckBox.Name = "fullscrCursorCheckBox";
			this.fullscrCursorCheckBox.Size = new System.Drawing.Size(342, 32);
			this.fullscrCursorCheckBox.TabIndex = 1;
			this.fullscrCursorCheckBox.Text = "show cursor in fullscreen";
			this.fullscrCursorCheckBox.UseVisualStyleBackColor = true;
			this.fullscrCursorCheckBox.CheckedChanged += new System.EventHandler(this.fullscrCursorCheckBox_CheckedChanged);
			// 
			// slideshowPage
			// 
			this.slideshowPage.BackColor = System.Drawing.SystemColors.Control;
			this.slideshowPage.Controls.Add(this.slideshowSecondsLabel);
			this.slideshowPage.Controls.Add(this.slideshowTimeLabel);
			this.slideshowPage.Controls.Add(this.slideshowTimeNumeric);
			this.slideshowPage.Controls.Add(this.slideshowCounterCheckBox);
			this.slideshowPage.Location = new System.Drawing.Point(4, 52);
			this.slideshowPage.Margin = new System.Windows.Forms.Padding(0);
			this.slideshowPage.Name = "slideshowPage";
			this.slideshowPage.Padding = new System.Windows.Forms.Padding(10);
			this.slideshowPage.Size = new System.Drawing.Size(362, 234);
			this.slideshowPage.TabIndex = 5;
			this.slideshowPage.Text = "slideshow";
			// 
			// slideshowSecondsLabel
			// 
			this.slideshowSecondsLabel.AutoSize = true;
			this.slideshowSecondsLabel.Location = new System.Drawing.Point(100, 45);
			this.slideshowSecondsLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.slideshowSecondsLabel.Name = "slideshowSecondsLabel";
			this.slideshowSecondsLabel.Size = new System.Drawing.Size(58, 19);
			this.slideshowSecondsLabel.TabIndex = 4;
			this.slideshowSecondsLabel.Text = "seconds";
			// 
			// slideshowTimeLabel
			// 
			this.slideshowTimeLabel.AutoSize = true;
			this.slideshowTimeLabel.Location = new System.Drawing.Point(10, 10);
			this.slideshowTimeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.slideshowTimeLabel.Name = "slideshowTimeLabel";
			this.slideshowTimeLabel.Size = new System.Drawing.Size(100, 19);
			this.slideshowTimeLabel.TabIndex = 3;
			this.slideshowTimeLabel.Text = "switching time:";
			// 
			// slideshowTimeNumeric
			// 
			this.slideshowTimeNumeric.DarkMode = false;
			this.slideshowTimeNumeric.Location = new System.Drawing.Point(10, 39);
			this.slideshowTimeNumeric.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.slideshowTimeNumeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.slideshowTimeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.slideshowTimeNumeric.Name = "slideshowTimeNumeric";
			this.slideshowTimeNumeric.Size = new System.Drawing.Size(80, 32);
			this.slideshowTimeNumeric.TabIndex = 2;
			this.slideshowTimeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.slideshowTimeNumeric.ValueChanged += new System.EventHandler(this.slideshowTimeNumeric_ValueChanged);
			// 
			// slideshowCounterCheckBox
			// 
			this.slideshowCounterCheckBox.DarkMode = false;
			this.slideshowCounterCheckBox.Location = new System.Drawing.Point(10, 81);
			this.slideshowCounterCheckBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.slideshowCounterCheckBox.Name = "slideshowCounterCheckBox";
			this.slideshowCounterCheckBox.Size = new System.Drawing.Size(342, 32);
			this.slideshowCounterCheckBox.TabIndex = 1;
			this.slideshowCounterCheckBox.Text = "show slideshow counter";
			this.slideshowCounterCheckBox.UseVisualStyleBackColor = true;
			this.slideshowCounterCheckBox.CheckedChanged += new System.EventHandler(this.slideshowCounterCheckBox_CheckedChanged);
			// 
			// startupPage
			// 
			this.startupPage.BackColor = System.Drawing.SystemColors.Control;
			this.startupPage.Controls.Add(this.startupBoundsCheckBox);
			this.startupPage.Controls.Add(this.updatesCheckBox);
			this.startupPage.Controls.Add(this.startupMaximizeCheckBox);
			this.startupPage.Controls.Add(this.startupPasteCheckBox);
			this.startupPage.Controls.Add(this.startupLabel);
			this.startupPage.Location = new System.Drawing.Point(4, 52);
			this.startupPage.Margin = new System.Windows.Forms.Padding(0);
			this.startupPage.Name = "startupPage";
			this.startupPage.Padding = new System.Windows.Forms.Padding(10);
			this.startupPage.Size = new System.Drawing.Size(362, 234);
			this.startupPage.TabIndex = 3;
			this.startupPage.Text = "startup";
			this.startupPage.ToolTipText = "App startup action";
			// 
			// startupBoundsCheckBox
			// 
			this.startupBoundsCheckBox.DarkMode = false;
			this.startupBoundsCheckBox.Location = new System.Drawing.Point(10, 103);
			this.startupBoundsCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.startupBoundsCheckBox.Name = "startupBoundsCheckBox";
			this.startupBoundsCheckBox.Size = new System.Drawing.Size(342, 32);
			this.startupBoundsCheckBox.TabIndex = 46;
			this.startupBoundsCheckBox.Text = "bounds";
			this.startupBoundsCheckBox.UseVisualStyleBackColor = true;
			this.startupBoundsCheckBox.CheckedChanged += new System.EventHandler(this.startupBoundsCheckBox_CheckedChanged);
			// 
			// updatesCheckBox
			// 
			this.updatesCheckBox.DarkMode = false;
			this.updatesCheckBox.Location = new System.Drawing.Point(10, 39);
			this.updatesCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.updatesCheckBox.Name = "updatesCheckBox";
			this.updatesCheckBox.Size = new System.Drawing.Size(342, 32);
			this.updatesCheckBox.TabIndex = 45;
			this.updatesCheckBox.Text = "check for app updates";
			this.updatesCheckBox.UseVisualStyleBackColor = true;
			this.updatesCheckBox.CheckedChanged += new System.EventHandler(this.updatesCheckBox_CheckedChanged);
			// 
			// startupMaximizeCheckBox
			// 
			this.startupMaximizeCheckBox.DarkMode = false;
			this.startupMaximizeCheckBox.Location = new System.Drawing.Point(10, 71);
			this.startupMaximizeCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.startupMaximizeCheckBox.Name = "startupMaximizeCheckBox";
			this.startupMaximizeCheckBox.Size = new System.Drawing.Size(342, 32);
			this.startupMaximizeCheckBox.TabIndex = 44;
			this.startupMaximizeCheckBox.Text = "maximize";
			this.startupMaximizeCheckBox.UseVisualStyleBackColor = true;
			this.startupMaximizeCheckBox.CheckedChanged += new System.EventHandler(this.startupMaximizeCheckBox_CheckedChanged);
			// 
			// startupPasteCheckBox
			// 
			this.startupPasteCheckBox.DarkMode = false;
			this.startupPasteCheckBox.Location = new System.Drawing.Point(10, 135);
			this.startupPasteCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.startupPasteCheckBox.Name = "startupPasteCheckBox";
			this.startupPasteCheckBox.Size = new System.Drawing.Size(342, 32);
			this.startupPasteCheckBox.TabIndex = 43;
			this.startupPasteCheckBox.Text = "paste";
			this.startupPasteCheckBox.UseVisualStyleBackColor = true;
			this.startupPasteCheckBox.CheckedChanged += new System.EventHandler(this.startupPasteCheckBox_CheckedChanged);
			// 
			// startupLabel
			// 
			this.startupLabel.AutoSize = true;
			this.startupLabel.Location = new System.Drawing.Point(10, 10);
			this.startupLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.startupLabel.Name = "startupLabel";
			this.startupLabel.Size = new System.Drawing.Size(103, 19);
			this.startupLabel.TabIndex = 42;
			this.startupLabel.Text = "startup actions:";
			// 
			// externalPage
			// 
			this.externalPage.BackColor = System.Drawing.SystemColors.Control;
			this.externalPage.Controls.Add(this.browseWithCheckBox);
			this.externalPage.Controls.Add(this.contextMenuLabel);
			this.externalPage.Controls.Add(this.openWithCheckBox);
			this.externalPage.Controls.Add(this.browseBtn);
			this.externalPage.Controls.Add(this.favExtTextBox);
			this.externalPage.Controls.Add(this.favExtLabel);
			this.externalPage.Location = new System.Drawing.Point(4, 52);
			this.externalPage.Margin = new System.Windows.Forms.Padding(0);
			this.externalPage.Name = "externalPage";
			this.externalPage.Padding = new System.Windows.Forms.Padding(10);
			this.externalPage.Size = new System.Drawing.Size(362, 234);
			this.externalPage.TabIndex = 4;
			this.externalPage.Text = "Windows";
			// 
			// browseWithCheckBox
			// 
			this.browseWithCheckBox.DarkMode = false;
			this.browseWithCheckBox.Location = new System.Drawing.Point(10, 71);
			this.browseWithCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.browseWithCheckBox.Name = "browseWithCheckBox";
			this.browseWithCheckBox.Size = new System.Drawing.Size(342, 32);
			this.browseWithCheckBox.TabIndex = 46;
			this.browseWithCheckBox.Text = "Browse folder with QuickPictureViewer";
			this.browseWithCheckBox.UseVisualStyleBackColor = true;
			this.browseWithCheckBox.CheckedChanged += new System.EventHandler(this.browseWithCheckBox_CheckedChanged);
			// 
			// contextMenuLabel
			// 
			this.contextMenuLabel.AutoSize = true;
			this.contextMenuLabel.Location = new System.Drawing.Point(10, 10);
			this.contextMenuLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.contextMenuLabel.Name = "contextMenuLabel";
			this.contextMenuLabel.Size = new System.Drawing.Size(96, 19);
			this.contextMenuLabel.TabIndex = 45;
			this.contextMenuLabel.Text = "context menu:";
			// 
			// openWithCheckBox
			// 
			this.openWithCheckBox.DarkMode = false;
			this.openWithCheckBox.Location = new System.Drawing.Point(10, 39);
			this.openWithCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.openWithCheckBox.Name = "openWithCheckBox";
			this.openWithCheckBox.Size = new System.Drawing.Size(342, 32);
			this.openWithCheckBox.TabIndex = 44;
			this.openWithCheckBox.Text = "Open with QuickPictureViewer";
			this.openWithCheckBox.UseVisualStyleBackColor = true;
			this.openWithCheckBox.CheckedChanged += new System.EventHandler(this.openWithCheckBox_CheckedChanged);
			// 
			// browseBtn
			// 
			this.browseBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.browseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.browseBtn.FlatAppearance.BorderSize = 0;
			this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.browseBtn.Image = global::quick_picture_viewer.Properties.Resources.black_open;
			this.browseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.browseBtn.Location = new System.Drawing.Point(232, 184);
			this.browseBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.browseBtn.Name = "browseBtn";
			this.browseBtn.Size = new System.Drawing.Size(120, 32);
			this.browseBtn.TabIndex = 2;
			this.browseBtn.TabStop = false;
			this.browseBtn.Text = " browse";
			this.browseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.browseBtn.UseVisualStyleBackColor = false;
			this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
			// 
			// favExtTextBox
			// 
			this.favExtTextBox.DarkMode = false;
			this.favExtTextBox.Location = new System.Drawing.Point(10, 142);
			this.favExtTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.favExtTextBox.Name = "favExtTextBox";
			this.favExtTextBox.ReadOnly = false;
			this.favExtTextBox.Size = new System.Drawing.Size(342, 32);
			this.favExtTextBox.TabIndex = 1;
			this.favExtTextBox.WordWrap = true;
			this.favExtTextBox.TextChanged += new System.EventHandler(this.favExtTextBox_TextChanged);
			// 
			// favExtLabel
			// 
			this.favExtLabel.AutoSize = true;
			this.favExtLabel.Location = new System.Drawing.Point(6, 113);
			this.favExtLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.favExtLabel.Name = "favExtLabel";
			this.favExtLabel.Size = new System.Drawing.Size(137, 19);
			this.favExtLabel.TabIndex = 0;
			this.favExtLabel.Text = "favorite external app:";
			// 
			// langPage
			// 
			this.langPage.BackColor = System.Drawing.SystemColors.Control;
			this.langPage.Controls.Add(this.translateAuthorsPanel);
			this.langPage.Controls.Add(this.translatedByLabel);
			this.langPage.Controls.Add(this.langLabel);
			this.langPage.Controls.Add(this.restartLabel2);
			this.langPage.Controls.Add(this.langComboBox);
			this.langPage.Controls.Add(this.localizationRestart);
			this.langPage.Location = new System.Drawing.Point(4, 52);
			this.langPage.Margin = new System.Windows.Forms.Padding(0);
			this.langPage.Name = "langPage";
			this.langPage.Padding = new System.Windows.Forms.Padding(10);
			this.langPage.Size = new System.Drawing.Size(362, 234);
			this.langPage.TabIndex = 6;
			this.langPage.Text = "localization";
			// 
			// translateAuthorsPanel
			// 
			this.translateAuthorsPanel.Location = new System.Drawing.Point(102, 81);
			this.translateAuthorsPanel.Margin = new System.Windows.Forms.Padding(0);
			this.translateAuthorsPanel.Name = "translateAuthorsPanel";
			this.translateAuthorsPanel.Size = new System.Drawing.Size(250, 19);
			this.translateAuthorsPanel.TabIndex = 43;
			// 
			// translatedByLabel
			// 
			this.translatedByLabel.AutoSize = true;
			this.translatedByLabel.Location = new System.Drawing.Point(10, 81);
			this.translatedByLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.translatedByLabel.Name = "translatedByLabel";
			this.translatedByLabel.Size = new System.Drawing.Size(92, 19);
			this.translatedByLabel.TabIndex = 42;
			this.translatedByLabel.Text = "translated by:";
			// 
			// langLabel
			// 
			this.langLabel.AutoSize = true;
			this.langLabel.Location = new System.Drawing.Point(10, 10);
			this.langLabel.Margin = new System.Windows.Forms.Padding(0);
			this.langLabel.Name = "langLabel";
			this.langLabel.Size = new System.Drawing.Size(68, 19);
			this.langLabel.TabIndex = 41;
			this.langLabel.Text = "language:";
			// 
			// restartLabel2
			// 
			this.restartLabel2.AutoSize = true;
			this.restartLabel2.Location = new System.Drawing.Point(10, 197);
			this.restartLabel2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.restartLabel2.Name = "restartLabel2";
			this.restartLabel2.Size = new System.Drawing.Size(114, 19);
			this.restartLabel2.TabIndex = 39;
			this.restartLabel2.Text = "* restart required";
			// 
			// langComboBox
			// 
			this.langComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.langComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.langComboBox.FormattingEnabled = true;
			this.langComboBox.ItemHeight = 26;
			this.langComboBox.Items.AddRange(new object[] {
            "English",
            "Russian (Русский)",
            "[Beta] Spanish (Española)"});
			this.langComboBox.Location = new System.Drawing.Point(10, 39);
			this.langComboBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.langComboBox.Name = "langComboBox";
			this.langComboBox.Size = new System.Drawing.Size(342, 32);
			this.langComboBox.TabIndex = 0;
			this.langComboBox.SelectedIndexChanged += new System.EventHandler(this.langComboBox_SelectedIndexChanged);
			// 
			// localizationRestart
			// 
			this.localizationRestart.Location = new System.Drawing.Point(10, 197);
			this.localizationRestart.Margin = new System.Windows.Forms.Padding(0);
			this.localizationRestart.Name = "localizationRestart";
			this.localizationRestart.Size = new System.Drawing.Size(342, 19);
			this.localizationRestart.TabIndex = 44;
			this.localizationRestart.TabStop = true;
			this.localizationRestart.Text = "restart";
			this.localizationRestart.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.localizationRestart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.restartLink_LinkClicked);
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(390, 32);
			this.titlePanel.TabIndex = 0;
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(358, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 17;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(9, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(90, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "SettingsForm";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "App executable|*.exe";
			// 
			// SettingsForm
			// 
			this.AlternativeAppearance = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(390, 342);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.settingsTabs);
			this.Draggable = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SettingsForm";
			this.TitleLabel = this.titleLabel;
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
			this.settingsTabs.ResumeLayout(false);
			this.themePage.ResumeLayout(false);
			this.themePage.PerformLayout();
			this.mousePage.ResumeLayout(false);
			this.mousePage.PerformLayout();
			this.slideshowPage.ResumeLayout(false);
			this.slideshowPage.PerformLayout();
			this.startupPage.ResumeLayout(false);
			this.startupPage.PerformLayout();
			this.externalPage.ResumeLayout(false);
			this.externalPage.PerformLayout();
			this.langPage.ResumeLayout(false);
			this.langPage.PerformLayout();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private QuickLibrary.QlibRadio lightThemeRadio;
		private QuickLibrary.QlibRadio systemThemeRadio;
		private QuickLibrary.QlibRadio darkThemeRadio;
		private System.Windows.Forms.Label restartLabel1;
		private QuickLibrary.QlibCheckBox fullscrCursorCheckBox;
		private QuickLibrary.QlibTabs settingsTabs;
		private System.Windows.Forms.TabPage themePage;
		private System.Windows.Forms.TabPage mousePage;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.ToolTip infoTooltip;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.TabPage startupPage;
		private System.Windows.Forms.Label startupLabel;
		private System.Windows.Forms.TabPage externalPage;
		private System.Windows.Forms.Label favExtLabel;
		private QuickLibrary.QlibTextBox favExtTextBox;
		private System.Windows.Forms.Button browseBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabPage slideshowPage;
		private QuickLibrary.QlibCheckBox slideshowCounterCheckBox;
		private QuickLibrary.QlibNumeric slideshowTimeNumeric;
		private System.Windows.Forms.Label slideshowTimeLabel;
		private System.Windows.Forms.Label slideshowSecondsLabel;
		private System.Windows.Forms.TabPage langPage;
		private QuickLibrary.QlibComboBox langComboBox;
		private System.Windows.Forms.Label restartLabel2;
		private System.Windows.Forms.Label langLabel;
		private System.Windows.Forms.Label translatedByLabel;
		private System.Windows.Forms.Panel translateAuthorsPanel;
		private QuickLibrary.QlibCheckBox escToExitCheckBox;
		private System.Windows.Forms.Label mouseWheelActionLabel;
		private QuickLibrary.QlibRadio mouseWheelActionRadio1;
		private QuickLibrary.QlibRadio mouseWheelActionRadio2;
		private QuickLibrary.QlibRadio mouseWheelActionRadio3;
		private System.Windows.Forms.LinkLabel themeRestart;
		private System.Windows.Forms.LinkLabel localizationRestart;
		private QuickLibrary.QlibCheckBox startupPasteCheckBox;
		private QuickLibrary.QlibCheckBox startupMaximizeCheckBox;
		private QuickLibrary.QlibCheckBox updatesCheckBox;
		private QuickLibrary.QlibCheckBox startupBoundsCheckBox;
		private QuickLibrary.QlibCheckBox openWithCheckBox;
		private System.Windows.Forms.Label contextMenuLabel;
		private QuickLibrary.QlibCheckBox browseWithCheckBox;
	}
}
