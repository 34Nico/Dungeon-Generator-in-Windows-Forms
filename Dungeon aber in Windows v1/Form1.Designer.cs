namespace Dungeon_aber_in_Windows_v1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabsUI = new System.Windows.Forms.TabControl();
            this.tabPageGenerate = new System.Windows.Forms.TabPage();
            this.tabGenLabelHeight = new System.Windows.Forms.Label();
            this.tabGenLabelWidth = new System.Windows.Forms.Label();
            this.tabGenTextTrapPercent = new System.Windows.Forms.TextBox();
            this.tabGenTextTreasurePercent = new System.Windows.Forms.TextBox();
            this.tabGenTextHeight = new System.Windows.Forms.TextBox();
            this.tabGenTextWidth = new System.Windows.Forms.TextBox();
            this.tabGenLabelTrap = new System.Windows.Forms.Label();
            this.tabGenLabelTreasure = new System.Windows.Forms.Label();
            this.tabGenButtonTrapNo = new System.Windows.Forms.Button();
            this.tabGenButtonTrapYes = new System.Windows.Forms.Button();
            this.tabGenButtonTreasureNo = new System.Windows.Forms.Button();
            this.tabGenButtonTreasureYes = new System.Windows.Forms.Button();
            this.tabGenButtonGenerate = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabSettingDropWalls = new System.Windows.Forms.ComboBox();
            this.tabSettingLabelWalls = new System.Windows.Forms.Label();
            this.tabSettingDropFloor = new System.Windows.Forms.ComboBox();
            this.tabSettingLabelFloor = new System.Windows.Forms.Label();
            this.tabSettingDropTrap = new System.Windows.Forms.ComboBox();
            this.tabSettingDropTreasure = new System.Windows.Forms.ComboBox();
            this.tabSettingDropEnd = new System.Windows.Forms.ComboBox();
            this.tabSettingLabelTraps = new System.Windows.Forms.Label();
            this.tabSettingLabelTreasure = new System.Windows.Forms.Label();
            this.tabSettingLabelEnd = new System.Windows.Forms.Label();
            this.tabSettingLabelStart = new System.Windows.Forms.Label();
            this.tabSettingDropStart = new System.Windows.Forms.ComboBox();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.tabExportButtonExport = new System.Windows.Forms.Button();
            this.tabExportTextFilePath = new System.Windows.Forms.TextBox();
            this.tabExportTextFileName = new System.Windows.Forms.TextBox();
            this.tabExportError = new System.Windows.Forms.Label();
            this.panelDungeon = new System.Windows.Forms.Panel();
            this.panelUserInterface = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabsUI.SuspendLayout();
            this.tabPageGenerate.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageExport.SuspendLayout();
            this.panelUserInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsUI
            // 
            this.tabsUI.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabsUI.Controls.Add(this.tabPageGenerate);
            this.tabsUI.Controls.Add(this.tabPageSettings);
            this.tabsUI.Controls.Add(this.tabPageExport);
            this.tabsUI.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabsUI.Location = new System.Drawing.Point(0, 0);
            this.tabsUI.Margin = new System.Windows.Forms.Padding(2);
            this.tabsUI.MaximumSize = new System.Drawing.Size(280, 600);
            this.tabsUI.Name = "tabsUI";
            this.tabsUI.SelectedIndex = 0;
            this.tabsUI.Size = new System.Drawing.Size(280, 600);
            this.tabsUI.TabIndex = 0;
            // 
            // tabPageGenerate
            // 
            this.tabPageGenerate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageGenerate.Controls.Add(this.tabGenLabelHeight);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelWidth);
            this.tabPageGenerate.Controls.Add(this.tabGenTextTrapPercent);
            this.tabPageGenerate.Controls.Add(this.tabGenTextTreasurePercent);
            this.tabPageGenerate.Controls.Add(this.tabGenTextHeight);
            this.tabPageGenerate.Controls.Add(this.tabGenTextWidth);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelTrap);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelTreasure);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonTrapNo);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonTrapYes);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonTreasureNo);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonTreasureYes);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonGenerate);
            this.tabPageGenerate.Location = new System.Drawing.Point(4, 25);
            this.tabPageGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageGenerate.Name = "tabPageGenerate";
            this.tabPageGenerate.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageGenerate.Size = new System.Drawing.Size(272, 571);
            this.tabPageGenerate.TabIndex = 0;
            this.tabPageGenerate.Text = "Genierung";
            // 
            // tabGenLabelHeight
            // 
            this.tabGenLabelHeight.AutoSize = true;
            this.tabGenLabelHeight.Location = new System.Drawing.Point(8, 56);
            this.tabGenLabelHeight.Name = "tabGenLabelHeight";
            this.tabGenLabelHeight.Size = new System.Drawing.Size(83, 13);
            this.tabGenLabelHeight.TabIndex = 15;
            this.tabGenLabelHeight.Text = "Dungeon  Höhe";
            // 
            // tabGenLabelWidth
            // 
            this.tabGenLabelWidth.AutoSize = true;
            this.tabGenLabelWidth.Location = new System.Drawing.Point(8, 23);
            this.tabGenLabelWidth.Name = "tabGenLabelWidth";
            this.tabGenLabelWidth.Size = new System.Drawing.Size(84, 13);
            this.tabGenLabelWidth.TabIndex = 14;
            this.tabGenLabelWidth.Text = "Dungeon  Breite";
            // 
            // tabGenTextTrapPercent
            // 
            this.tabGenTextTrapPercent.Location = new System.Drawing.Point(171, 119);
            this.tabGenTextTrapPercent.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenTextTrapPercent.Name = "tabGenTextTrapPercent";
            this.tabGenTextTrapPercent.Size = new System.Drawing.Size(34, 20);
            this.tabGenTextTrapPercent.TabIndex = 13;
            // 
            // tabGenTextTreasurePercent
            // 
            this.tabGenTextTreasurePercent.Location = new System.Drawing.Point(171, 86);
            this.tabGenTextTreasurePercent.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenTextTreasurePercent.Name = "tabGenTextTreasurePercent";
            this.tabGenTextTreasurePercent.Size = new System.Drawing.Size(34, 20);
            this.tabGenTextTreasurePercent.TabIndex = 12;
            // 
            // tabGenTextHeight
            // 
            this.tabGenTextHeight.Location = new System.Drawing.Point(110, 53);
            this.tabGenTextHeight.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenTextHeight.Name = "tabGenTextHeight";
            this.tabGenTextHeight.Size = new System.Drawing.Size(95, 20);
            this.tabGenTextHeight.TabIndex = 11;
            // 
            // tabGenTextWidth
            // 
            this.tabGenTextWidth.Location = new System.Drawing.Point(110, 20);
            this.tabGenTextWidth.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenTextWidth.Name = "tabGenTextWidth";
            this.tabGenTextWidth.Size = new System.Drawing.Size(95, 20);
            this.tabGenTextWidth.TabIndex = 10;
            // 
            // tabGenLabelTrap
            // 
            this.tabGenLabelTrap.AutoSize = true;
            this.tabGenLabelTrap.Location = new System.Drawing.Point(7, 122);
            this.tabGenLabelTrap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabGenLabelTrap.Name = "tabGenLabelTrap";
            this.tabGenLabelTrap.Size = new System.Drawing.Size(35, 13);
            this.tabGenLabelTrap.TabIndex = 9;
            this.tabGenLabelTrap.Text = "Fallen";
            // 
            // tabGenLabelTreasure
            // 
            this.tabGenLabelTreasure.AutoSize = true;
            this.tabGenLabelTreasure.Location = new System.Drawing.Point(7, 89);
            this.tabGenLabelTreasure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabGenLabelTreasure.Name = "tabGenLabelTreasure";
            this.tabGenLabelTreasure.Size = new System.Drawing.Size(41, 13);
            this.tabGenLabelTreasure.TabIndex = 8;
            this.tabGenLabelTreasure.Text = "Truhen";
            // 
            // tabGenButtonTrapNo
            // 
            this.tabGenButtonTrapNo.Location = new System.Drawing.Point(110, 119);
            this.tabGenButtonTrapNo.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenButtonTrapNo.Name = "tabGenButtonTrapNo";
            this.tabGenButtonTrapNo.Size = new System.Drawing.Size(56, 19);
            this.tabGenButtonTrapNo.TabIndex = 5;
            this.tabGenButtonTrapNo.Text = "Aus";
            this.tabGenButtonTrapNo.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTrapYes
            // 
            this.tabGenButtonTrapYes.Location = new System.Drawing.Point(55, 119);
            this.tabGenButtonTrapYes.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenButtonTrapYes.Name = "tabGenButtonTrapYes";
            this.tabGenButtonTrapYes.Size = new System.Drawing.Size(56, 19);
            this.tabGenButtonTrapYes.TabIndex = 4;
            this.tabGenButtonTrapYes.Text = "An";
            this.tabGenButtonTrapYes.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTreasureNo
            // 
            this.tabGenButtonTreasureNo.Location = new System.Drawing.Point(110, 86);
            this.tabGenButtonTreasureNo.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenButtonTreasureNo.Name = "tabGenButtonTreasureNo";
            this.tabGenButtonTreasureNo.Size = new System.Drawing.Size(56, 19);
            this.tabGenButtonTreasureNo.TabIndex = 3;
            this.tabGenButtonTreasureNo.Text = "Aus";
            this.tabGenButtonTreasureNo.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTreasureYes
            // 
            this.tabGenButtonTreasureYes.Location = new System.Drawing.Point(55, 86);
            this.tabGenButtonTreasureYes.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenButtonTreasureYes.Name = "tabGenButtonTreasureYes";
            this.tabGenButtonTreasureYes.Size = new System.Drawing.Size(56, 19);
            this.tabGenButtonTreasureYes.TabIndex = 2;
            this.tabGenButtonTreasureYes.Text = "An";
            this.tabGenButtonTreasureYes.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonGenerate
            // 
            this.tabGenButtonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGenButtonGenerate.Location = new System.Drawing.Point(47, 433);
            this.tabGenButtonGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.tabGenButtonGenerate.Name = "tabGenButtonGenerate";
            this.tabGenButtonGenerate.Size = new System.Drawing.Size(177, 54);
            this.tabGenButtonGenerate.TabIndex = 1;
            this.tabGenButtonGenerate.Text = "Generieren starten";
            this.tabGenButtonGenerate.UseVisualStyleBackColor = true;
            this.tabGenButtonGenerate.Click += new System.EventHandler(this.tabGenButtonGenerate_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tabPageSettings.Controls.Add(this.tabSettingDropWalls);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelWalls);
            this.tabPageSettings.Controls.Add(this.tabSettingDropFloor);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelFloor);
            this.tabPageSettings.Controls.Add(this.tabSettingDropTrap);
            this.tabPageSettings.Controls.Add(this.tabSettingDropTreasure);
            this.tabPageSettings.Controls.Add(this.tabSettingDropEnd);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelTraps);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelTreasure);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelEnd);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelStart);
            this.tabPageSettings.Controls.Add(this.tabSettingDropStart);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSettings.Size = new System.Drawing.Size(272, 571);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Einstellungen";
            // 
            // tabSettingDropWalls
            // 
            this.tabSettingDropWalls.FormattingEnabled = true;
            this.tabSettingDropWalls.Location = new System.Drawing.Point(91, 139);
            this.tabSettingDropWalls.Margin = new System.Windows.Forms.Padding(2);
            this.tabSettingDropWalls.Name = "tabSettingDropWalls";
            this.tabSettingDropWalls.Size = new System.Drawing.Size(92, 21);
            this.tabSettingDropWalls.TabIndex = 11;
            // 
            // tabSettingLabelWalls
            // 
            this.tabSettingLabelWalls.AutoSize = true;
            this.tabSettingLabelWalls.Location = new System.Drawing.Point(16, 142);
            this.tabSettingLabelWalls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabSettingLabelWalls.Name = "tabSettingLabelWalls";
            this.tabSettingLabelWalls.Size = new System.Drawing.Size(42, 13);
            this.tabSettingLabelWalls.TabIndex = 10;
            this.tabSettingLabelWalls.Text = "Wände";
            // 
            // tabSettingDropFloor
            // 
            this.tabSettingDropFloor.FormattingEnabled = true;
            this.tabSettingDropFloor.Location = new System.Drawing.Point(91, 114);
            this.tabSettingDropFloor.Margin = new System.Windows.Forms.Padding(2);
            this.tabSettingDropFloor.Name = "tabSettingDropFloor";
            this.tabSettingDropFloor.Size = new System.Drawing.Size(92, 21);
            this.tabSettingDropFloor.TabIndex = 9;
            // 
            // tabSettingLabelFloor
            // 
            this.tabSettingLabelFloor.AutoSize = true;
            this.tabSettingLabelFloor.Location = new System.Drawing.Point(16, 117);
            this.tabSettingLabelFloor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabSettingLabelFloor.Name = "tabSettingLabelFloor";
            this.tabSettingLabelFloor.Size = new System.Drawing.Size(36, 13);
            this.tabSettingLabelFloor.TabIndex = 8;
            this.tabSettingLabelFloor.Text = "Wege";
            // 
            // tabSettingDropTrap
            // 
            this.tabSettingDropTrap.FormattingEnabled = true;
            this.tabSettingDropTrap.Location = new System.Drawing.Point(91, 89);
            this.tabSettingDropTrap.Margin = new System.Windows.Forms.Padding(2);
            this.tabSettingDropTrap.Name = "tabSettingDropTrap";
            this.tabSettingDropTrap.Size = new System.Drawing.Size(92, 21);
            this.tabSettingDropTrap.TabIndex = 7;
            // 
            // tabSettingDropTreasure
            // 
            this.tabSettingDropTreasure.FormattingEnabled = true;
            this.tabSettingDropTreasure.Location = new System.Drawing.Point(91, 64);
            this.tabSettingDropTreasure.Margin = new System.Windows.Forms.Padding(2);
            this.tabSettingDropTreasure.Name = "tabSettingDropTreasure";
            this.tabSettingDropTreasure.Size = new System.Drawing.Size(92, 21);
            this.tabSettingDropTreasure.TabIndex = 6;
            // 
            // tabSettingDropEnd
            // 
            this.tabSettingDropEnd.FormattingEnabled = true;
            this.tabSettingDropEnd.Location = new System.Drawing.Point(91, 39);
            this.tabSettingDropEnd.Margin = new System.Windows.Forms.Padding(2);
            this.tabSettingDropEnd.Name = "tabSettingDropEnd";
            this.tabSettingDropEnd.Size = new System.Drawing.Size(92, 21);
            this.tabSettingDropEnd.TabIndex = 5;
            // 
            // tabSettingLabelTraps
            // 
            this.tabSettingLabelTraps.AutoSize = true;
            this.tabSettingLabelTraps.Location = new System.Drawing.Point(16, 92);
            this.tabSettingLabelTraps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabSettingLabelTraps.Name = "tabSettingLabelTraps";
            this.tabSettingLabelTraps.Size = new System.Drawing.Size(35, 13);
            this.tabSettingLabelTraps.TabIndex = 4;
            this.tabSettingLabelTraps.Text = "Fallen";
            // 
            // tabSettingLabelTreasure
            // 
            this.tabSettingLabelTreasure.AutoSize = true;
            this.tabSettingLabelTreasure.Location = new System.Drawing.Point(16, 67);
            this.tabSettingLabelTreasure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabSettingLabelTreasure.Name = "tabSettingLabelTreasure";
            this.tabSettingLabelTreasure.Size = new System.Drawing.Size(41, 13);
            this.tabSettingLabelTreasure.TabIndex = 3;
            this.tabSettingLabelTreasure.Text = "Truhen";
            // 
            // tabSettingLabelEnd
            // 
            this.tabSettingLabelEnd.AutoSize = true;
            this.tabSettingLabelEnd.Location = new System.Drawing.Point(16, 42);
            this.tabSettingLabelEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabSettingLabelEnd.Name = "tabSettingLabelEnd";
            this.tabSettingLabelEnd.Size = new System.Drawing.Size(24, 13);
            this.tabSettingLabelEnd.TabIndex = 2;
            this.tabSettingLabelEnd.Text = "Ziel";
            // 
            // tabSettingLabelStart
            // 
            this.tabSettingLabelStart.AutoSize = true;
            this.tabSettingLabelStart.Location = new System.Drawing.Point(16, 17);
            this.tabSettingLabelStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabSettingLabelStart.Name = "tabSettingLabelStart";
            this.tabSettingLabelStart.Size = new System.Drawing.Size(29, 13);
            this.tabSettingLabelStart.TabIndex = 1;
            this.tabSettingLabelStart.Text = "Start";
            // 
            // tabSettingDropStart
            // 
            this.tabSettingDropStart.FormattingEnabled = true;
            this.tabSettingDropStart.Location = new System.Drawing.Point(91, 14);
            this.tabSettingDropStart.Margin = new System.Windows.Forms.Padding(2);
            this.tabSettingDropStart.Name = "tabSettingDropStart";
            this.tabSettingDropStart.Size = new System.Drawing.Size(92, 21);
            this.tabSettingDropStart.TabIndex = 0;
            // 
            // tabPageExport
            // 
            this.tabPageExport.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tabPageExport.Controls.Add(this.tabExportButtonExport);
            this.tabPageExport.Controls.Add(this.tabExportTextFilePath);
            this.tabPageExport.Controls.Add(this.tabExportTextFileName);
            this.tabPageExport.Controls.Add(this.tabExportError);
            this.tabPageExport.Location = new System.Drawing.Point(4, 25);
            this.tabPageExport.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageExport.Size = new System.Drawing.Size(272, 571);
            this.tabPageExport.TabIndex = 2;
            this.tabPageExport.Text = "Export";
            // 
            // tabExportButtonExport
            // 
            this.tabExportButtonExport.Location = new System.Drawing.Point(94, 136);
            this.tabExportButtonExport.Margin = new System.Windows.Forms.Padding(2);
            this.tabExportButtonExport.Name = "tabExportButtonExport";
            this.tabExportButtonExport.Size = new System.Drawing.Size(85, 19);
            this.tabExportButtonExport.TabIndex = 3;
            this.tabExportButtonExport.Text = "Exportieren";
            this.tabExportButtonExport.UseVisualStyleBackColor = true;
            // 
            // tabExportTextFilePath
            // 
            this.tabExportTextFilePath.Location = new System.Drawing.Point(37, 95);
            this.tabExportTextFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.tabExportTextFilePath.Name = "tabExportTextFilePath";
            this.tabExportTextFilePath.Size = new System.Drawing.Size(194, 20);
            this.tabExportTextFilePath.TabIndex = 2;
            this.tabExportTextFilePath.Text = "Path";
            // 
            // tabExportTextFileName
            // 
            this.tabExportTextFileName.Location = new System.Drawing.Point(37, 61);
            this.tabExportTextFileName.Margin = new System.Windows.Forms.Padding(2);
            this.tabExportTextFileName.Name = "tabExportTextFileName";
            this.tabExportTextFileName.Size = new System.Drawing.Size(194, 20);
            this.tabExportTextFileName.TabIndex = 1;
            this.tabExportTextFileName.Text = "Name";
            // 
            // tabExportError
            // 
            this.tabExportError.AutoSize = true;
            this.tabExportError.Location = new System.Drawing.Point(4, 18);
            this.tabExportError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabExportError.Name = "tabExportError";
            this.tabExportError.Size = new System.Drawing.Size(91, 13);
            this.tabExportError.TabIndex = 0;
            this.tabExportError.Text = "BischtDuDeppat?";
            // 
            // panelDungeon
            // 
            this.panelDungeon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelDungeon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDungeon.Location = new System.Drawing.Point(0, 0);
            this.panelDungeon.Margin = new System.Windows.Forms.Padding(2);
            this.panelDungeon.Name = "panelDungeon";
            this.panelDungeon.Size = new System.Drawing.Size(1184, 661);
            this.panelDungeon.TabIndex = 1;
            // 
            // panelUserInterface
            // 
            this.panelUserInterface.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelUserInterface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserInterface.Controls.Add(this.buttonQuit);
            this.panelUserInterface.Controls.Add(this.tabsUI);
            this.panelUserInterface.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserInterface.Location = new System.Drawing.Point(0, 0);
            this.panelUserInterface.Margin = new System.Windows.Forms.Padding(2);
            this.panelUserInterface.Name = "panelUserInterface";
            this.panelUserInterface.Size = new System.Drawing.Size(282, 661);
            this.panelUserInterface.TabIndex = 2;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.White;
            this.buttonQuit.Location = new System.Drawing.Point(38, 612);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(202, 37);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "Beenden";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelUserInterface);
            this.Controls.Add(this.panelDungeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dungeon Generator";
            this.tabsUI.ResumeLayout(false);
            this.tabPageGenerate.ResumeLayout(false);
            this.tabPageGenerate.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageExport.ResumeLayout(false);
            this.tabPageExport.PerformLayout();
            this.panelUserInterface.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsUI;
        private System.Windows.Forms.TabPage tabPageGenerate;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageExport;
        private System.Windows.Forms.Panel panelDungeon;
        private System.Windows.Forms.Panel panelUserInterface;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button tabGenButtonTrapNo;
        private System.Windows.Forms.Button tabGenButtonTrapYes;
        private System.Windows.Forms.Button tabGenButtonTreasureNo;
        private System.Windows.Forms.Button tabGenButtonTreasureYes;
        private System.Windows.Forms.Button tabGenButtonGenerate;
        private System.Windows.Forms.TextBox tabGenTextTrapPercent;
        private System.Windows.Forms.TextBox tabGenTextTreasurePercent;
        private System.Windows.Forms.TextBox tabGenTextHeight;
        private System.Windows.Forms.TextBox tabGenTextWidth;
        private System.Windows.Forms.Label tabGenLabelTrap;
        private System.Windows.Forms.Label tabGenLabelTreasure;
        private System.Windows.Forms.ComboBox tabSettingDropStart;
        private System.Windows.Forms.Label tabSettingLabelEnd;
        private System.Windows.Forms.Label tabSettingLabelStart;
        private System.Windows.Forms.ComboBox tabSettingDropTrap;
        private System.Windows.Forms.ComboBox tabSettingDropTreasure;
        private System.Windows.Forms.ComboBox tabSettingDropEnd;
        private System.Windows.Forms.Label tabSettingLabelTraps;
        private System.Windows.Forms.Label tabSettingLabelTreasure;
        private System.Windows.Forms.Button tabExportButtonExport;
        private System.Windows.Forms.TextBox tabExportTextFilePath;
        private System.Windows.Forms.TextBox tabExportTextFileName;
        private System.Windows.Forms.Label tabExportError;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label tabGenLabelHeight;
        private System.Windows.Forms.Label tabGenLabelWidth;
        private System.Windows.Forms.ComboBox tabSettingDropFloor;
        private System.Windows.Forms.Label tabSettingLabelFloor;
        private System.Windows.Forms.ComboBox tabSettingDropWalls;
        private System.Windows.Forms.Label tabSettingLabelWalls;
    }
}

