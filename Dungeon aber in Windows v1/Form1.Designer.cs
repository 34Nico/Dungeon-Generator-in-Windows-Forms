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
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.tabGenButtonGenerate = new System.Windows.Forms.Button();
            this.tabGenButtonTreasureYes = new System.Windows.Forms.Button();
            this.tabGenButtonTreasureNo = new System.Windows.Forms.Button();
            this.tabGenButtonTrapYes = new System.Windows.Forms.Button();
            this.tabGenButtonTrapNo = new System.Windows.Forms.Button();
            this.tabGenLabelTreasure = new System.Windows.Forms.Label();
            this.tabGenLabelTrap = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabSettingDropStart = new System.Windows.Forms.ComboBox();
            this.tabSettingLabelStart = new System.Windows.Forms.Label();
            this.tabSettingLabelEnd = new System.Windows.Forms.Label();
            this.tabSettingLabelTreasure = new System.Windows.Forms.Label();
            this.tabSettingLabelTraps = new System.Windows.Forms.Label();
            this.tabSettingDropEnd = new System.Windows.Forms.ComboBox();
            this.tabSettingDropTreasure = new System.Windows.Forms.ComboBox();
            this.tabSettingDropTrap = new System.Windows.Forms.ComboBox();
            this.tabExportError = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabExportTextFileName = new System.Windows.Forms.TextBox();
            this.tabExportTextFilePath = new System.Windows.Forms.TextBox();
            this.tabExportButtonExport = new System.Windows.Forms.Button();
            this.tabsUI.SuspendLayout();
            this.tabPageGenerate.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageExport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsUI
            // 
            this.tabsUI.Controls.Add(this.tabPageGenerate);
            this.tabsUI.Controls.Add(this.tabPageSettings);
            this.tabsUI.Controls.Add(this.tabPageExport);
            this.tabsUI.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabsUI.Location = new System.Drawing.Point(0, 0);
            this.tabsUI.MaximumSize = new System.Drawing.Size(275, 600);
            this.tabsUI.Name = "tabsUI";
            this.tabsUI.SelectedIndex = 0;
            this.tabsUI.Size = new System.Drawing.Size(275, 600);
            this.tabsUI.TabIndex = 0;
            // 
            // tabPageGenerate
            // 
            this.tabPageGenerate.Controls.Add(this.textBox4);
            this.tabPageGenerate.Controls.Add(this.textBox3);
            this.tabPageGenerate.Controls.Add(this.textBoxHeight);
            this.tabPageGenerate.Controls.Add(this.textBoxWidth);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelTrap);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelTreasure);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonTrapNo);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonTrapYes);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonTreasureNo);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonTreasureYes);
            this.tabPageGenerate.Controls.Add(this.tabGenButtonGenerate);
            this.tabPageGenerate.Location = new System.Drawing.Point(4, 25);
            this.tabPageGenerate.Name = "tabPageGenerate";
            this.tabPageGenerate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenerate.Size = new System.Drawing.Size(267, 571);
            this.tabPageGenerate.TabIndex = 0;
            this.tabPageGenerate.Text = "Genierung";
            this.tabPageGenerate.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.tabSettingDropTrap);
            this.tabPageSettings.Controls.Add(this.tabSettingDropTreasure);
            this.tabPageSettings.Controls.Add(this.tabSettingDropEnd);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelTraps);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelTreasure);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelEnd);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelStart);
            this.tabPageSettings.Controls.Add(this.tabSettingDropStart);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(267, 571);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Einstellungen";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageExport
            // 
            this.tabPageExport.Controls.Add(this.tabExportButtonExport);
            this.tabPageExport.Controls.Add(this.tabExportTextFilePath);
            this.tabPageExport.Controls.Add(this.tabExportTextFileName);
            this.tabPageExport.Controls.Add(this.tabExportError);
            this.tabPageExport.Location = new System.Drawing.Point(4, 25);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExport.Size = new System.Drawing.Size(267, 571);
            this.tabPageExport.TabIndex = 2;
            this.tabPageExport.Text = "Export";
            this.tabPageExport.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(282, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 653);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonQuit);
            this.panel2.Controls.Add(this.tabsUI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 653);
            this.panel2.TabIndex = 2;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(4, 602);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(270, 45);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "Alt F4 ersatz";
            this.buttonQuit.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonGenerate
            // 
            this.tabGenButtonGenerate.Location = new System.Drawing.Point(8, 477);
            this.tabGenButtonGenerate.Name = "tabGenButtonGenerate";
            this.tabGenButtonGenerate.Size = new System.Drawing.Size(236, 66);
            this.tabGenButtonGenerate.TabIndex = 1;
            this.tabGenButtonGenerate.Text = "Generieren starten";
            this.tabGenButtonGenerate.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTreasureYes
            // 
            this.tabGenButtonTreasureYes.Location = new System.Drawing.Point(58, 111);
            this.tabGenButtonTreasureYes.Name = "tabGenButtonTreasureYes";
            this.tabGenButtonTreasureYes.Size = new System.Drawing.Size(75, 23);
            this.tabGenButtonTreasureYes.TabIndex = 2;
            this.tabGenButtonTreasureYes.Text = "An";
            this.tabGenButtonTreasureYes.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTreasureNo
            // 
            this.tabGenButtonTreasureNo.Location = new System.Drawing.Point(132, 111);
            this.tabGenButtonTreasureNo.Name = "tabGenButtonTreasureNo";
            this.tabGenButtonTreasureNo.Size = new System.Drawing.Size(75, 23);
            this.tabGenButtonTreasureNo.TabIndex = 3;
            this.tabGenButtonTreasureNo.Text = "Aus";
            this.tabGenButtonTreasureNo.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTrapYes
            // 
            this.tabGenButtonTrapYes.Location = new System.Drawing.Point(58, 169);
            this.tabGenButtonTrapYes.Name = "tabGenButtonTrapYes";
            this.tabGenButtonTrapYes.Size = new System.Drawing.Size(75, 23);
            this.tabGenButtonTrapYes.TabIndex = 4;
            this.tabGenButtonTrapYes.Text = "An";
            this.tabGenButtonTrapYes.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTrapNo
            // 
            this.tabGenButtonTrapNo.Location = new System.Drawing.Point(132, 169);
            this.tabGenButtonTrapNo.Name = "tabGenButtonTrapNo";
            this.tabGenButtonTrapNo.Size = new System.Drawing.Size(75, 23);
            this.tabGenButtonTrapNo.TabIndex = 5;
            this.tabGenButtonTrapNo.Text = "Aus";
            this.tabGenButtonTrapNo.UseVisualStyleBackColor = true;
            this.tabGenButtonTrapNo.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabGenLabelTreasure
            // 
            this.tabGenLabelTreasure.AutoSize = true;
            this.tabGenLabelTreasure.Location = new System.Drawing.Point(8, 118);
            this.tabGenLabelTreasure.Name = "tabGenLabelTreasure";
            this.tabGenLabelTreasure.Size = new System.Drawing.Size(42, 16);
            this.tabGenLabelTreasure.TabIndex = 8;
            this.tabGenLabelTreasure.Text = "Truhe";
            // 
            // tabGenLabelTrap
            // 
            this.tabGenLabelTrap.AutoSize = true;
            this.tabGenLabelTrap.Location = new System.Drawing.Point(8, 176);
            this.tabGenLabelTrap.Name = "tabGenLabelTrap";
            this.tabGenLabelTrap.Size = new System.Drawing.Size(44, 16);
            this.tabGenLabelTrap.TabIndex = 9;
            this.tabGenLabelTrap.Text = "Fallen";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(8, 18);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(236, 22);
            this.textBoxWidth.TabIndex = 10;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(8, 68);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(236, 22);
            this.textBoxHeight.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(213, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 22);
            this.textBox4.TabIndex = 13;
            // 
            // tabSettingDropStart
            // 
            this.tabSettingDropStart.FormattingEnabled = true;
            this.tabSettingDropStart.Location = new System.Drawing.Point(127, 43);
            this.tabSettingDropStart.Name = "tabSettingDropStart";
            this.tabSettingDropStart.Size = new System.Drawing.Size(121, 24);
            this.tabSettingDropStart.TabIndex = 0;
            // 
            // tabSettingLabelStart
            // 
            this.tabSettingLabelStart.AutoSize = true;
            this.tabSettingLabelStart.Location = new System.Drawing.Point(38, 43);
            this.tabSettingLabelStart.Name = "tabSettingLabelStart";
            this.tabSettingLabelStart.Size = new System.Drawing.Size(34, 16);
            this.tabSettingLabelStart.TabIndex = 1;
            this.tabSettingLabelStart.Text = "Start";
            // 
            // tabSettingLabelEnd
            // 
            this.tabSettingLabelEnd.AutoSize = true;
            this.tabSettingLabelEnd.Location = new System.Drawing.Point(41, 79);
            this.tabSettingLabelEnd.Name = "tabSettingLabelEnd";
            this.tabSettingLabelEnd.Size = new System.Drawing.Size(29, 16);
            this.tabSettingLabelEnd.TabIndex = 2;
            this.tabSettingLabelEnd.Text = "Ziel";
            // 
            // tabSettingLabelTreasure
            // 
            this.tabSettingLabelTreasure.AutoSize = true;
            this.tabSettingLabelTreasure.Location = new System.Drawing.Point(27, 125);
            this.tabSettingLabelTreasure.Name = "tabSettingLabelTreasure";
            this.tabSettingLabelTreasure.Size = new System.Drawing.Size(49, 16);
            this.tabSettingLabelTreasure.TabIndex = 3;
            this.tabSettingLabelTreasure.Text = "Truhen";
            // 
            // tabSettingLabelTraps
            // 
            this.tabSettingLabelTraps.AutoSize = true;
            this.tabSettingLabelTraps.Location = new System.Drawing.Point(27, 169);
            this.tabSettingLabelTraps.Name = "tabSettingLabelTraps";
            this.tabSettingLabelTraps.Size = new System.Drawing.Size(44, 16);
            this.tabSettingLabelTraps.TabIndex = 4;
            this.tabSettingLabelTraps.Text = "Fallen";
            // 
            // tabSettingDropEnd
            // 
            this.tabSettingDropEnd.FormattingEnabled = true;
            this.tabSettingDropEnd.Location = new System.Drawing.Point(127, 79);
            this.tabSettingDropEnd.Name = "tabSettingDropEnd";
            this.tabSettingDropEnd.Size = new System.Drawing.Size(121, 24);
            this.tabSettingDropEnd.TabIndex = 5;
            // 
            // tabSettingDropTreasure
            // 
            this.tabSettingDropTreasure.FormattingEnabled = true;
            this.tabSettingDropTreasure.Location = new System.Drawing.Point(127, 117);
            this.tabSettingDropTreasure.Name = "tabSettingDropTreasure";
            this.tabSettingDropTreasure.Size = new System.Drawing.Size(121, 24);
            this.tabSettingDropTreasure.TabIndex = 6;
            this.tabSettingDropTreasure.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tabSettingDropTrap
            // 
            this.tabSettingDropTrap.FormattingEnabled = true;
            this.tabSettingDropTrap.Location = new System.Drawing.Point(127, 161);
            this.tabSettingDropTrap.Name = "tabSettingDropTrap";
            this.tabSettingDropTrap.Size = new System.Drawing.Size(121, 24);
            this.tabSettingDropTrap.TabIndex = 7;
            // 
            // tabExportError
            // 
            this.tabExportError.AutoSize = true;
            this.tabExportError.Location = new System.Drawing.Point(6, 22);
            this.tabExportError.Name = "tabExportError";
            this.tabExportError.Size = new System.Drawing.Size(112, 16);
            this.tabExportError.TabIndex = 0;
            this.tabExportError.Text = "BischtDuDeppat?";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabExportTextFileName
            // 
            this.tabExportTextFileName.Location = new System.Drawing.Point(3, 76);
            this.tabExportTextFileName.Name = "tabExportTextFileName";
            this.tabExportTextFileName.Size = new System.Drawing.Size(258, 22);
            this.tabExportTextFileName.TabIndex = 1;
            this.tabExportTextFileName.Text = "Name";
            // 
            // tabExportTextFilePath
            // 
            this.tabExportTextFilePath.Location = new System.Drawing.Point(3, 120);
            this.tabExportTextFilePath.Name = "tabExportTextFilePath";
            this.tabExportTextFilePath.Size = new System.Drawing.Size(258, 22);
            this.tabExportTextFilePath.TabIndex = 2;
            this.tabExportTextFilePath.Text = "Path";
            // 
            // tabExportButtonExport
            // 
            this.tabExportButtonExport.Location = new System.Drawing.Point(76, 174);
            this.tabExportButtonExport.Name = "tabExportButtonExport";
            this.tabExportButtonExport.Size = new System.Drawing.Size(113, 23);
            this.tabExportButtonExport.TabIndex = 3;
            this.tabExportButtonExport.Text = "Exportieren";
            this.tabExportButtonExport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsUI;
        private System.Windows.Forms.TabPage tabPageGenerate;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button tabGenButtonTrapNo;
        private System.Windows.Forms.Button tabGenButtonTrapYes;
        private System.Windows.Forms.Button tabGenButtonTreasureNo;
        private System.Windows.Forms.Button tabGenButtonTreasureYes;
        private System.Windows.Forms.Button tabGenButtonGenerate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
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
    }
}

