namespace Dungeon_aber_in_Windows_v1
{
    partial class HauptForm
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
            this.tabGenTextRoomCountMax = new System.Windows.Forms.TextBox();
            this.tabGenLabelRoomCountMax = new System.Windows.Forms.Label();
            this.tabGenTextRoomCountMin = new System.Windows.Forms.TextBox();
            this.tabGenLabelRoomCountMin = new System.Windows.Forms.Label();
            this.tabGenLabelRoomCount = new System.Windows.Forms.Label();
            this.tabGenTitleLabelObjects = new System.Windows.Forms.Label();
            this.tabGenTextRoomHeightMax = new System.Windows.Forms.TextBox();
            this.tabGenLabelRoomHeightMax = new System.Windows.Forms.Label();
            this.tabGenTextRoomHeightMin = new System.Windows.Forms.TextBox();
            this.tabGenLabelRoomHeightMin = new System.Windows.Forms.Label();
            this.tabGenLabelRoomHeight = new System.Windows.Forms.Label();
            this.tabGenTextRoomWidthMax = new System.Windows.Forms.TextBox();
            this.tabGenLabelRoomWidthMax = new System.Windows.Forms.Label();
            this.tabGenTextRoomWidthMin = new System.Windows.Forms.TextBox();
            this.tabGenLabelRoomWidthMin = new System.Windows.Forms.Label();
            this.tabGenLabelRoomWidth = new System.Windows.Forms.Label();
            this.tabGenTitleLabelRooms = new System.Windows.Forms.Label();
            this.tabGenTitleLabelGeneral = new System.Windows.Forms.Label();
            this.tabGenLabelSeed = new System.Windows.Forms.Label();
            this.tabGenTextSeed = new System.Windows.Forms.TextBox();
            this.tabGenDropPreset = new System.Windows.Forms.ComboBox();
            this.tabGenLabelPreset = new System.Windows.Forms.Label();
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
            this.tabSettingTitleLableColor = new System.Windows.Forms.Label();
            this.tabSettingButtonConfigImport = new System.Windows.Forms.Button();
            this.tabSettingButtonConfigExport = new System.Windows.Forms.Button();
            this.tabSettingLabelConfigExpImp = new System.Windows.Forms.Label();
            this.tabSettingTextConfigExpImp = new System.Windows.Forms.TextBox();
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
            this.tabExportButtonRandomName = new System.Windows.Forms.Button();
            this.tabExportButtonExport = new System.Windows.Forms.Button();
            this.tabExportTextFilePath = new System.Windows.Forms.TextBox();
            this.tabExportTextFileName = new System.Windows.Forms.TextBox();
            this.tabExportError = new System.Windows.Forms.Label();
            this.panelDungeon = new System.Windows.Forms.Panel();
            this.panelDungeonAnzeigePicture = new System.Windows.Forms.Panel();
            this.dungeonAnzeigePicture = new System.Windows.Forms.PictureBox();
            this.dungeonAnzeigePictureCheckbox = new System.Windows.Forms.CheckBox();
            this.playButton = new System.Windows.Forms.Button();
            this.statsAusgabeLabel = new System.Windows.Forms.Label();
            this.statsAnzeige = new System.Windows.Forms.RichTextBox();
            this.dungeonAnzeige = new System.Windows.Forms.RichTextBox();
            this.panelUserInterface = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabsUI.SuspendLayout();
            this.tabPageGenerate.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageExport.SuspendLayout();
            this.panelDungeon.SuspendLayout();
            this.panelDungeonAnzeigePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonAnzeigePicture)).BeginInit();
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
            this.tabsUI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsUI.MaximumSize = new System.Drawing.Size(373, 738);
            this.tabsUI.Name = "tabsUI";
            this.tabsUI.SelectedIndex = 0;
            this.tabsUI.Size = new System.Drawing.Size(373, 738);
            this.tabsUI.TabIndex = 0;
            // 
            // tabPageGenerate
            // 
            this.tabPageGenerate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageGenerate.Controls.Add(this.tabGenTextRoomCountMax);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomCountMax);
            this.tabPageGenerate.Controls.Add(this.tabGenTextRoomCountMin);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomCountMin);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomCount);
            this.tabPageGenerate.Controls.Add(this.tabGenTitleLabelObjects);
            this.tabPageGenerate.Controls.Add(this.tabGenTextRoomHeightMax);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomHeightMax);
            this.tabPageGenerate.Controls.Add(this.tabGenTextRoomHeightMin);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomHeightMin);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomHeight);
            this.tabPageGenerate.Controls.Add(this.tabGenTextRoomWidthMax);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomWidthMax);
            this.tabPageGenerate.Controls.Add(this.tabGenTextRoomWidthMin);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomWidthMin);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelRoomWidth);
            this.tabPageGenerate.Controls.Add(this.tabGenTitleLabelRooms);
            this.tabPageGenerate.Controls.Add(this.tabGenTitleLabelGeneral);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelSeed);
            this.tabPageGenerate.Controls.Add(this.tabGenTextSeed);
            this.tabPageGenerate.Controls.Add(this.tabGenDropPreset);
            this.tabPageGenerate.Controls.Add(this.tabGenLabelPreset);
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
            this.tabPageGenerate.Location = new System.Drawing.Point(4, 28);
            this.tabPageGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGenerate.Name = "tabPageGenerate";
            this.tabPageGenerate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGenerate.Size = new System.Drawing.Size(365, 706);
            this.tabPageGenerate.TabIndex = 0;
            this.tabPageGenerate.Text = "Genierung";
            // 
            // tabGenTextRoomCountMax
            // 
            this.tabGenTextRoomCountMax.Location = new System.Drawing.Point(195, 202);
            this.tabGenTextRoomCountMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextRoomCountMax.Name = "tabGenTextRoomCountMax";
            this.tabGenTextRoomCountMax.Size = new System.Drawing.Size(53, 22);
            this.tabGenTextRoomCountMax.TabIndex = 37;
            // 
            // tabGenLabelRoomCountMax
            // 
            this.tabGenLabelRoomCountMax.AutoSize = true;
            this.tabGenLabelRoomCountMax.Location = new System.Drawing.Point(144, 206);
            this.tabGenLabelRoomCountMax.Name = "tabGenLabelRoomCountMax";
            this.tabGenLabelRoomCountMax.Size = new System.Drawing.Size(32, 16);
            this.tabGenLabelRoomCountMax.TabIndex = 36;
            this.tabGenLabelRoomCountMax.Text = "Max";
            // 
            // tabGenTextRoomCountMin
            // 
            this.tabGenTextRoomCountMin.Location = new System.Drawing.Point(67, 201);
            this.tabGenTextRoomCountMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextRoomCountMin.Name = "tabGenTextRoomCountMin";
            this.tabGenTextRoomCountMin.Size = new System.Drawing.Size(47, 22);
            this.tabGenTextRoomCountMin.TabIndex = 35;
            // 
            // tabGenLabelRoomCountMin
            // 
            this.tabGenLabelRoomCountMin.AutoSize = true;
            this.tabGenLabelRoomCountMin.Location = new System.Drawing.Point(29, 206);
            this.tabGenLabelRoomCountMin.Name = "tabGenLabelRoomCountMin";
            this.tabGenLabelRoomCountMin.Size = new System.Drawing.Size(28, 16);
            this.tabGenLabelRoomCountMin.TabIndex = 34;
            this.tabGenLabelRoomCountMin.Text = "Min";
            // 
            // tabGenLabelRoomCount
            // 
            this.tabGenLabelRoomCount.AutoSize = true;
            this.tabGenLabelRoomCount.Location = new System.Drawing.Point(13, 177);
            this.tabGenLabelRoomCount.Name = "tabGenLabelRoomCount";
            this.tabGenLabelRoomCount.Size = new System.Drawing.Size(50, 16);
            this.tabGenLabelRoomCount.TabIndex = 33;
            this.tabGenLabelRoomCount.Text = "Anzahl:";
            // 
            // tabGenTitleLabelObjects
            // 
            this.tabGenTitleLabelObjects.AutoSize = true;
            this.tabGenTitleLabelObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGenTitleLabelObjects.Location = new System.Drawing.Point(5, 357);
            this.tabGenTitleLabelObjects.Name = "tabGenTitleLabelObjects";
            this.tabGenTitleLabelObjects.Size = new System.Drawing.Size(139, 17);
            this.tabGenTitleLabelObjects.TabIndex = 32;
            this.tabGenTitleLabelObjects.Text = "Dungeon Objekte:";
            // 
            // tabGenTextRoomHeightMax
            // 
            this.tabGenTextRoomHeightMax.Location = new System.Drawing.Point(195, 322);
            this.tabGenTextRoomHeightMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextRoomHeightMax.Name = "tabGenTextRoomHeightMax";
            this.tabGenTextRoomHeightMax.Size = new System.Drawing.Size(53, 22);
            this.tabGenTextRoomHeightMax.TabIndex = 31;
            // 
            // tabGenLabelRoomHeightMax
            // 
            this.tabGenLabelRoomHeightMax.AutoSize = true;
            this.tabGenLabelRoomHeightMax.Location = new System.Drawing.Point(144, 322);
            this.tabGenLabelRoomHeightMax.Name = "tabGenLabelRoomHeightMax";
            this.tabGenLabelRoomHeightMax.Size = new System.Drawing.Size(32, 16);
            this.tabGenLabelRoomHeightMax.TabIndex = 30;
            this.tabGenLabelRoomHeightMax.Text = "Max";
            // 
            // tabGenTextRoomHeightMin
            // 
            this.tabGenTextRoomHeightMin.Location = new System.Drawing.Point(67, 319);
            this.tabGenTextRoomHeightMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextRoomHeightMin.Name = "tabGenTextRoomHeightMin";
            this.tabGenTextRoomHeightMin.Size = new System.Drawing.Size(47, 22);
            this.tabGenTextRoomHeightMin.TabIndex = 29;
            // 
            // tabGenLabelRoomHeightMin
            // 
            this.tabGenLabelRoomHeightMin.AutoSize = true;
            this.tabGenLabelRoomHeightMin.Location = new System.Drawing.Point(29, 322);
            this.tabGenLabelRoomHeightMin.Name = "tabGenLabelRoomHeightMin";
            this.tabGenLabelRoomHeightMin.Size = new System.Drawing.Size(28, 16);
            this.tabGenLabelRoomHeightMin.TabIndex = 28;
            this.tabGenLabelRoomHeightMin.Text = "Min";
            // 
            // tabGenLabelRoomHeight
            // 
            this.tabGenLabelRoomHeight.AutoSize = true;
            this.tabGenLabelRoomHeight.Location = new System.Drawing.Point(13, 294);
            this.tabGenLabelRoomHeight.Name = "tabGenLabelRoomHeight";
            this.tabGenLabelRoomHeight.Size = new System.Drawing.Size(43, 16);
            this.tabGenLabelRoomHeight.TabIndex = 27;
            this.tabGenLabelRoomHeight.Text = "Höhe:";
            // 
            // tabGenTextRoomWidthMax
            // 
            this.tabGenTextRoomWidthMax.Location = new System.Drawing.Point(195, 261);
            this.tabGenTextRoomWidthMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextRoomWidthMax.Name = "tabGenTextRoomWidthMax";
            this.tabGenTextRoomWidthMax.Size = new System.Drawing.Size(53, 22);
            this.tabGenTextRoomWidthMax.TabIndex = 26;
            // 
            // tabGenLabelRoomWidthMax
            // 
            this.tabGenLabelRoomWidthMax.AutoSize = true;
            this.tabGenLabelRoomWidthMax.Location = new System.Drawing.Point(144, 265);
            this.tabGenLabelRoomWidthMax.Name = "tabGenLabelRoomWidthMax";
            this.tabGenLabelRoomWidthMax.Size = new System.Drawing.Size(32, 16);
            this.tabGenLabelRoomWidthMax.TabIndex = 25;
            this.tabGenLabelRoomWidthMax.Text = "Max";
            // 
            // tabGenTextRoomWidthMin
            // 
            this.tabGenTextRoomWidthMin.Location = new System.Drawing.Point(67, 260);
            this.tabGenTextRoomWidthMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextRoomWidthMin.Name = "tabGenTextRoomWidthMin";
            this.tabGenTextRoomWidthMin.Size = new System.Drawing.Size(47, 22);
            this.tabGenTextRoomWidthMin.TabIndex = 24;
            // 
            // tabGenLabelRoomWidthMin
            // 
            this.tabGenLabelRoomWidthMin.AutoSize = true;
            this.tabGenLabelRoomWidthMin.Location = new System.Drawing.Point(29, 265);
            this.tabGenLabelRoomWidthMin.Name = "tabGenLabelRoomWidthMin";
            this.tabGenLabelRoomWidthMin.Size = new System.Drawing.Size(28, 16);
            this.tabGenLabelRoomWidthMin.TabIndex = 23;
            this.tabGenLabelRoomWidthMin.Text = "Min";
            // 
            // tabGenLabelRoomWidth
            // 
            this.tabGenLabelRoomWidth.AutoSize = true;
            this.tabGenLabelRoomWidth.Location = new System.Drawing.Point(13, 236);
            this.tabGenLabelRoomWidth.Name = "tabGenLabelRoomWidth";
            this.tabGenLabelRoomWidth.Size = new System.Drawing.Size(45, 16);
            this.tabGenLabelRoomWidth.TabIndex = 22;
            this.tabGenLabelRoomWidth.Text = "Breite:";
            // 
            // tabGenTitleLabelRooms
            // 
            this.tabGenTitleLabelRooms.AutoSize = true;
            this.tabGenTitleLabelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGenTitleLabelRooms.Location = new System.Drawing.Point(5, 151);
            this.tabGenTitleLabelRooms.Name = "tabGenTitleLabelRooms";
            this.tabGenTitleLabelRooms.Size = new System.Drawing.Size(63, 17);
            this.tabGenTitleLabelRooms.TabIndex = 21;
            this.tabGenTitleLabelRooms.Text = "Räume:";
            // 
            // tabGenTitleLabelGeneral
            // 
            this.tabGenTitleLabelGeneral.AutoSize = true;
            this.tabGenTitleLabelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGenTitleLabelGeneral.Location = new System.Drawing.Point(5, 11);
            this.tabGenTitleLabelGeneral.Name = "tabGenTitleLabelGeneral";
            this.tabGenTitleLabelGeneral.Size = new System.Drawing.Size(83, 17);
            this.tabGenTitleLabelGeneral.TabIndex = 20;
            this.tabGenTitleLabelGeneral.Text = "Allgemein:";
            // 
            // tabGenLabelSeed
            // 
            this.tabGenLabelSeed.AutoSize = true;
            this.tabGenLabelSeed.Location = new System.Drawing.Point(11, 37);
            this.tabGenLabelSeed.Name = "tabGenLabelSeed";
            this.tabGenLabelSeed.Size = new System.Drawing.Size(98, 16);
            this.tabGenLabelSeed.TabIndex = 19;
            this.tabGenLabelSeed.Text = "Dungeon Seed";
            // 
            // tabGenTextSeed
            // 
            this.tabGenTextSeed.Location = new System.Drawing.Point(148, 31);
            this.tabGenTextSeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextSeed.Name = "tabGenTextSeed";
            this.tabGenTextSeed.Size = new System.Drawing.Size(144, 22);
            this.tabGenTextSeed.TabIndex = 18;
            // 
            // tabGenDropPreset
            // 
            this.tabGenDropPreset.FormattingEnabled = true;
            this.tabGenDropPreset.Location = new System.Drawing.Point(148, 60);
            this.tabGenDropPreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenDropPreset.Name = "tabGenDropPreset";
            this.tabGenDropPreset.Size = new System.Drawing.Size(144, 24);
            this.tabGenDropPreset.TabIndex = 17;
            this.tabGenDropPreset.SelectedIndexChanged += new System.EventHandler(this.tabGenDropPreset_SelectedIndexChanged);
            // 
            // tabGenLabelPreset
            // 
            this.tabGenLabelPreset.AutoSize = true;
            this.tabGenLabelPreset.Location = new System.Drawing.Point(11, 64);
            this.tabGenLabelPreset.Name = "tabGenLabelPreset";
            this.tabGenLabelPreset.Size = new System.Drawing.Size(104, 16);
            this.tabGenLabelPreset.TabIndex = 16;
            this.tabGenLabelPreset.Text = "Dungeon Preset";
            // 
            // tabGenLabelHeight
            // 
            this.tabGenLabelHeight.AutoSize = true;
            this.tabGenLabelHeight.Location = new System.Drawing.Point(11, 124);
            this.tabGenLabelHeight.Name = "tabGenLabelHeight";
            this.tabGenLabelHeight.Size = new System.Drawing.Size(101, 16);
            this.tabGenLabelHeight.TabIndex = 15;
            this.tabGenLabelHeight.Text = "Dungeon  Höhe";
            // 
            // tabGenLabelWidth
            // 
            this.tabGenLabelWidth.AutoSize = true;
            this.tabGenLabelWidth.Location = new System.Drawing.Point(11, 95);
            this.tabGenLabelWidth.Name = "tabGenLabelWidth";
            this.tabGenLabelWidth.Size = new System.Drawing.Size(103, 16);
            this.tabGenLabelWidth.TabIndex = 14;
            this.tabGenLabelWidth.Text = "Dungeon  Breite";
            // 
            // tabGenTextTrapPercent
            // 
            this.tabGenTextTrapPercent.Location = new System.Drawing.Point(195, 418);
            this.tabGenTextTrapPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextTrapPercent.Name = "tabGenTextTrapPercent";
            this.tabGenTextTrapPercent.Size = new System.Drawing.Size(63, 22);
            this.tabGenTextTrapPercent.TabIndex = 13;
            // 
            // tabGenTextTreasurePercent
            // 
            this.tabGenTextTreasurePercent.Location = new System.Drawing.Point(195, 384);
            this.tabGenTextTreasurePercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextTreasurePercent.Name = "tabGenTextTreasurePercent";
            this.tabGenTextTreasurePercent.Size = new System.Drawing.Size(63, 22);
            this.tabGenTextTreasurePercent.TabIndex = 12;
            // 
            // tabGenTextHeight
            // 
            this.tabGenTextHeight.Location = new System.Drawing.Point(148, 121);
            this.tabGenTextHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextHeight.Name = "tabGenTextHeight";
            this.tabGenTextHeight.Size = new System.Drawing.Size(144, 22);
            this.tabGenTextHeight.TabIndex = 11;
            // 
            // tabGenTextWidth
            // 
            this.tabGenTextWidth.Location = new System.Drawing.Point(148, 91);
            this.tabGenTextWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenTextWidth.Name = "tabGenTextWidth";
            this.tabGenTextWidth.Size = new System.Drawing.Size(144, 22);
            this.tabGenTextWidth.TabIndex = 10;
            // 
            // tabGenLabelTrap
            // 
            this.tabGenLabelTrap.AutoSize = true;
            this.tabGenLabelTrap.Location = new System.Drawing.Point(16, 418);
            this.tabGenLabelTrap.Name = "tabGenLabelTrap";
            this.tabGenLabelTrap.Size = new System.Drawing.Size(44, 16);
            this.tabGenLabelTrap.TabIndex = 9;
            this.tabGenLabelTrap.Text = "Fallen";
            // 
            // tabGenLabelTreasure
            // 
            this.tabGenLabelTreasure.AutoSize = true;
            this.tabGenLabelTreasure.Location = new System.Drawing.Point(13, 388);
            this.tabGenLabelTreasure.Name = "tabGenLabelTreasure";
            this.tabGenLabelTreasure.Size = new System.Drawing.Size(49, 16);
            this.tabGenLabelTreasure.TabIndex = 8;
            this.tabGenLabelTreasure.Text = "Truhen";
            // 
            // tabGenButtonTrapNo
            // 
            this.tabGenButtonTrapNo.Location = new System.Drawing.Point(137, 418);
            this.tabGenButtonTrapNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenButtonTrapNo.Name = "tabGenButtonTrapNo";
            this.tabGenButtonTrapNo.Size = new System.Drawing.Size(49, 22);
            this.tabGenButtonTrapNo.TabIndex = 5;
            this.tabGenButtonTrapNo.Text = "Aus";
            this.tabGenButtonTrapNo.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTrapYes
            // 
            this.tabGenButtonTrapYes.Location = new System.Drawing.Point(72, 418);
            this.tabGenButtonTrapYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenButtonTrapYes.Name = "tabGenButtonTrapYes";
            this.tabGenButtonTrapYes.Size = new System.Drawing.Size(51, 22);
            this.tabGenButtonTrapYes.TabIndex = 4;
            this.tabGenButtonTrapYes.Text = "An";
            this.tabGenButtonTrapYes.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTreasureNo
            // 
            this.tabGenButtonTreasureNo.Location = new System.Drawing.Point(137, 384);
            this.tabGenButtonTreasureNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenButtonTreasureNo.Name = "tabGenButtonTreasureNo";
            this.tabGenButtonTreasureNo.Size = new System.Drawing.Size(49, 22);
            this.tabGenButtonTreasureNo.TabIndex = 3;
            this.tabGenButtonTreasureNo.Text = "Aus";
            this.tabGenButtonTreasureNo.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonTreasureYes
            // 
            this.tabGenButtonTreasureYes.Location = new System.Drawing.Point(72, 384);
            this.tabGenButtonTreasureYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenButtonTreasureYes.Name = "tabGenButtonTreasureYes";
            this.tabGenButtonTreasureYes.Size = new System.Drawing.Size(49, 22);
            this.tabGenButtonTreasureYes.TabIndex = 2;
            this.tabGenButtonTreasureYes.Text = "An";
            this.tabGenButtonTreasureYes.UseVisualStyleBackColor = true;
            // 
            // tabGenButtonGenerate
            // 
            this.tabGenButtonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGenButtonGenerate.Location = new System.Drawing.Point(65, 598);
            this.tabGenButtonGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenButtonGenerate.Name = "tabGenButtonGenerate";
            this.tabGenButtonGenerate.Size = new System.Drawing.Size(236, 66);
            this.tabGenButtonGenerate.TabIndex = 1;
            this.tabGenButtonGenerate.Text = "Generieren starten";
            this.tabGenButtonGenerate.UseVisualStyleBackColor = true;
            this.tabGenButtonGenerate.Click += new System.EventHandler(this.tabGenButtonGenerate_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tabPageSettings.Controls.Add(this.tabSettingTitleLableColor);
            this.tabPageSettings.Controls.Add(this.tabSettingButtonConfigImport);
            this.tabPageSettings.Controls.Add(this.tabSettingButtonConfigExport);
            this.tabPageSettings.Controls.Add(this.tabSettingLabelConfigExpImp);
            this.tabPageSettings.Controls.Add(this.tabSettingTextConfigExpImp);
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
            this.tabPageSettings.Location = new System.Drawing.Point(4, 28);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSettings.Size = new System.Drawing.Size(365, 706);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Einstellungen";
            // 
            // tabSettingTitleLableColor
            // 
            this.tabSettingTitleLableColor.AutoSize = true;
            this.tabSettingTitleLableColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettingTitleLableColor.Location = new System.Drawing.Point(8, 11);
            this.tabSettingTitleLableColor.Name = "tabSettingTitleLableColor";
            this.tabSettingTitleLableColor.Size = new System.Drawing.Size(134, 17);
            this.tabSettingTitleLableColor.TabIndex = 18;
            this.tabSettingTitleLableColor.Text = "Dungeon Farben:";
            // 
            // tabSettingButtonConfigImport
            // 
            this.tabSettingButtonConfigImport.Location = new System.Drawing.Point(181, 667);
            this.tabSettingButtonConfigImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettingButtonConfigImport.Name = "tabSettingButtonConfigImport";
            this.tabSettingButtonConfigImport.Size = new System.Drawing.Size(175, 25);
            this.tabSettingButtonConfigImport.TabIndex = 15;
            this.tabSettingButtonConfigImport.Text = "Importieren (paste)";
            this.tabSettingButtonConfigImport.UseVisualStyleBackColor = true;
            this.tabSettingButtonConfigImport.Click += new System.EventHandler(this.tabSettingButtonConfigImport_Click);
            // 
            // tabSettingButtonConfigExport
            // 
            this.tabSettingButtonConfigExport.Location = new System.Drawing.Point(7, 667);
            this.tabSettingButtonConfigExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettingButtonConfigExport.Name = "tabSettingButtonConfigExport";
            this.tabSettingButtonConfigExport.Size = new System.Drawing.Size(169, 25);
            this.tabSettingButtonConfigExport.TabIndex = 14;
            this.tabSettingButtonConfigExport.Text = "Exportieren (copy)";
            this.tabSettingButtonConfigExport.UseVisualStyleBackColor = true;
            this.tabSettingButtonConfigExport.Click += new System.EventHandler(this.tabSettingButtonConfigExport_Click);
            // 
            // tabSettingLabelConfigExpImp
            // 
            this.tabSettingLabelConfigExpImp.AutoSize = true;
            this.tabSettingLabelConfigExpImp.Location = new System.Drawing.Point(3, 606);
            this.tabSettingLabelConfigExpImp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabSettingLabelConfigExpImp.Name = "tabSettingLabelConfigExpImp";
            this.tabSettingLabelConfigExpImp.Size = new System.Drawing.Size(226, 16);
            this.tabSettingLabelConfigExpImp.TabIndex = 13;
            this.tabSettingLabelConfigExpImp.Text = "Konfiguration Importieren/Exportieren";
            // 
            // tabSettingTextConfigExpImp
            // 
            this.tabSettingTextConfigExpImp.Location = new System.Drawing.Point(7, 636);
            this.tabSettingTextConfigExpImp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSettingTextConfigExpImp.Name = "tabSettingTextConfigExpImp";
            this.tabSettingTextConfigExpImp.Size = new System.Drawing.Size(348, 22);
            this.tabSettingTextConfigExpImp.TabIndex = 12;
            // 
            // tabSettingDropWalls
            // 
            this.tabSettingDropWalls.FormattingEnabled = true;
            this.tabSettingDropWalls.Location = new System.Drawing.Point(68, 187);
            this.tabSettingDropWalls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettingDropWalls.Name = "tabSettingDropWalls";
            this.tabSettingDropWalls.Size = new System.Drawing.Size(180, 24);
            this.tabSettingDropWalls.TabIndex = 11;
            // 
            // tabSettingLabelWalls
            // 
            this.tabSettingLabelWalls.AutoSize = true;
            this.tabSettingLabelWalls.Location = new System.Drawing.Point(12, 191);
            this.tabSettingLabelWalls.Name = "tabSettingLabelWalls";
            this.tabSettingLabelWalls.Size = new System.Drawing.Size(51, 16);
            this.tabSettingLabelWalls.TabIndex = 10;
            this.tabSettingLabelWalls.Text = "Wände";
            // 
            // tabSettingDropFloor
            // 
            this.tabSettingDropFloor.FormattingEnabled = true;
            this.tabSettingDropFloor.Location = new System.Drawing.Point(68, 156);
            this.tabSettingDropFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettingDropFloor.Name = "tabSettingDropFloor";
            this.tabSettingDropFloor.Size = new System.Drawing.Size(180, 24);
            this.tabSettingDropFloor.TabIndex = 9;
            // 
            // tabSettingLabelFloor
            // 
            this.tabSettingLabelFloor.AutoSize = true;
            this.tabSettingLabelFloor.Location = new System.Drawing.Point(12, 160);
            this.tabSettingLabelFloor.Name = "tabSettingLabelFloor";
            this.tabSettingLabelFloor.Size = new System.Drawing.Size(44, 16);
            this.tabSettingLabelFloor.TabIndex = 8;
            this.tabSettingLabelFloor.Text = "Wege";
            // 
            // tabSettingDropTrap
            // 
            this.tabSettingDropTrap.FormattingEnabled = true;
            this.tabSettingDropTrap.Location = new System.Drawing.Point(68, 126);
            this.tabSettingDropTrap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettingDropTrap.Name = "tabSettingDropTrap";
            this.tabSettingDropTrap.Size = new System.Drawing.Size(180, 24);
            this.tabSettingDropTrap.TabIndex = 7;
            // 
            // tabSettingDropTreasure
            // 
            this.tabSettingDropTreasure.FormattingEnabled = true;
            this.tabSettingDropTreasure.Location = new System.Drawing.Point(68, 95);
            this.tabSettingDropTreasure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettingDropTreasure.Name = "tabSettingDropTreasure";
            this.tabSettingDropTreasure.Size = new System.Drawing.Size(180, 24);
            this.tabSettingDropTreasure.TabIndex = 6;
            // 
            // tabSettingDropEnd
            // 
            this.tabSettingDropEnd.FormattingEnabled = true;
            this.tabSettingDropEnd.Location = new System.Drawing.Point(68, 64);
            this.tabSettingDropEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettingDropEnd.Name = "tabSettingDropEnd";
            this.tabSettingDropEnd.Size = new System.Drawing.Size(180, 24);
            this.tabSettingDropEnd.TabIndex = 5;
            // 
            // tabSettingLabelTraps
            // 
            this.tabSettingLabelTraps.AutoSize = true;
            this.tabSettingLabelTraps.Location = new System.Drawing.Point(12, 129);
            this.tabSettingLabelTraps.Name = "tabSettingLabelTraps";
            this.tabSettingLabelTraps.Size = new System.Drawing.Size(44, 16);
            this.tabSettingLabelTraps.TabIndex = 4;
            this.tabSettingLabelTraps.Text = "Fallen";
            // 
            // tabSettingLabelTreasure
            // 
            this.tabSettingLabelTreasure.AutoSize = true;
            this.tabSettingLabelTreasure.Location = new System.Drawing.Point(12, 98);
            this.tabSettingLabelTreasure.Name = "tabSettingLabelTreasure";
            this.tabSettingLabelTreasure.Size = new System.Drawing.Size(49, 16);
            this.tabSettingLabelTreasure.TabIndex = 3;
            this.tabSettingLabelTreasure.Text = "Truhen";
            // 
            // tabSettingLabelEnd
            // 
            this.tabSettingLabelEnd.AutoSize = true;
            this.tabSettingLabelEnd.Location = new System.Drawing.Point(12, 68);
            this.tabSettingLabelEnd.Name = "tabSettingLabelEnd";
            this.tabSettingLabelEnd.Size = new System.Drawing.Size(29, 16);
            this.tabSettingLabelEnd.TabIndex = 2;
            this.tabSettingLabelEnd.Text = "Ziel";
            // 
            // tabSettingLabelStart
            // 
            this.tabSettingLabelStart.AutoSize = true;
            this.tabSettingLabelStart.Location = new System.Drawing.Point(12, 37);
            this.tabSettingLabelStart.Name = "tabSettingLabelStart";
            this.tabSettingLabelStart.Size = new System.Drawing.Size(34, 16);
            this.tabSettingLabelStart.TabIndex = 1;
            this.tabSettingLabelStart.Text = "Start";
            // 
            // tabSettingDropStart
            // 
            this.tabSettingDropStart.FormattingEnabled = true;
            this.tabSettingDropStart.Location = new System.Drawing.Point(68, 33);
            this.tabSettingDropStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettingDropStart.Name = "tabSettingDropStart";
            this.tabSettingDropStart.Size = new System.Drawing.Size(180, 24);
            this.tabSettingDropStart.TabIndex = 0;
            // 
            // tabPageExport
            // 
            this.tabPageExport.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tabPageExport.Controls.Add(this.tabExportButtonRandomName);
            this.tabPageExport.Controls.Add(this.tabExportButtonExport);
            this.tabPageExport.Controls.Add(this.tabExportTextFilePath);
            this.tabPageExport.Controls.Add(this.tabExportTextFileName);
            this.tabPageExport.Controls.Add(this.tabExportError);
            this.tabPageExport.Location = new System.Drawing.Point(4, 28);
            this.tabPageExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageExport.Size = new System.Drawing.Size(365, 706);
            this.tabPageExport.TabIndex = 2;
            this.tabPageExport.Text = "Export";
            // 
            // tabExportButtonRandomName
            // 
            this.tabExportButtonRandomName.Location = new System.Drawing.Point(195, 76);
            this.tabExportButtonRandomName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExportButtonRandomName.Name = "tabExportButtonRandomName";
            this.tabExportButtonRandomName.Size = new System.Drawing.Size(113, 23);
            this.tabExportButtonRandomName.TabIndex = 4;
            this.tabExportButtonRandomName.Text = "Zufällig";
            this.tabExportButtonRandomName.UseVisualStyleBackColor = true;
            this.tabExportButtonRandomName.Click += new System.EventHandler(this.tabExportButtonRandomName_Click);
            // 
            // tabExportButtonExport
            // 
            this.tabExportButtonExport.Location = new System.Drawing.Point(125, 167);
            this.tabExportButtonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExportButtonExport.Name = "tabExportButtonExport";
            this.tabExportButtonExport.Size = new System.Drawing.Size(113, 23);
            this.tabExportButtonExport.TabIndex = 3;
            this.tabExportButtonExport.Text = "Exportieren";
            this.tabExportButtonExport.UseVisualStyleBackColor = true;
            this.tabExportButtonExport.Click += new System.EventHandler(this.tabExportButtonExport_Click);
            // 
            // tabExportTextFilePath
            // 
            this.tabExportTextFilePath.Location = new System.Drawing.Point(49, 117);
            this.tabExportTextFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExportTextFilePath.Name = "tabExportTextFilePath";
            this.tabExportTextFilePath.Size = new System.Drawing.Size(257, 22);
            this.tabExportTextFilePath.TabIndex = 2;
            this.tabExportTextFilePath.Text = "Path";
            // 
            // tabExportTextFileName
            // 
            this.tabExportTextFileName.Location = new System.Drawing.Point(49, 75);
            this.tabExportTextFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExportTextFileName.Name = "tabExportTextFileName";
            this.tabExportTextFileName.Size = new System.Drawing.Size(133, 22);
            this.tabExportTextFileName.TabIndex = 1;
            this.tabExportTextFileName.Text = "Name";
            // 
            // tabExportError
            // 
            this.tabExportError.AutoSize = true;
            this.tabExportError.Location = new System.Drawing.Point(5, 22);
            this.tabExportError.Name = "tabExportError";
            this.tabExportError.Size = new System.Drawing.Size(112, 16);
            this.tabExportError.TabIndex = 0;
            this.tabExportError.Text = "BischtDuDeppat?";
            // 
            // panelDungeon
            // 
            this.panelDungeon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelDungeon.Controls.Add(this.panelDungeonAnzeigePicture);
            this.panelDungeon.Controls.Add(this.dungeonAnzeigePictureCheckbox);
            this.panelDungeon.Controls.Add(this.playButton);
            this.panelDungeon.Controls.Add(this.statsAusgabeLabel);
            this.panelDungeon.Controls.Add(this.statsAnzeige);
            this.panelDungeon.Controls.Add(this.dungeonAnzeige);
            this.panelDungeon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDungeon.Location = new System.Drawing.Point(0, 0);
            this.panelDungeon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDungeon.Name = "panelDungeon";
            this.panelDungeon.Size = new System.Drawing.Size(1579, 814);
            this.panelDungeon.TabIndex = 1;
            // 
            // panelDungeonAnzeigePicture
            // 
            this.panelDungeonAnzeigePicture.AutoScroll = true;
            this.panelDungeonAnzeigePicture.Controls.Add(this.dungeonAnzeigePicture);
            this.panelDungeonAnzeigePicture.Location = new System.Drawing.Point(383, 15);
            this.panelDungeonAnzeigePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDungeonAnzeigePicture.Name = "panelDungeonAnzeigePicture";
            this.panelDungeonAnzeigePicture.Size = new System.Drawing.Size(759, 743);
            this.panelDungeonAnzeigePicture.TabIndex = 7;
            this.panelDungeonAnzeigePicture.Visible = false;
            // 
            // dungeonAnzeigePicture
            // 
            this.dungeonAnzeigePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dungeonAnzeigePicture.Location = new System.Drawing.Point(-1, 0);
            this.dungeonAnzeigePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dungeonAnzeigePicture.Name = "dungeonAnzeigePicture";
            this.dungeonAnzeigePicture.Size = new System.Drawing.Size(760, 745);
            this.dungeonAnzeigePicture.TabIndex = 6;
            this.dungeonAnzeigePicture.TabStop = false;
            this.dungeonAnzeigePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.dungeonAnzeigePicture_Paint);
            // 
            // dungeonAnzeigePictureCheckbox
            // 
            this.dungeonAnzeigePictureCheckbox.AutoSize = true;
            this.dungeonAnzeigePictureCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonAnzeigePictureCheckbox.Location = new System.Drawing.Point(403, 766);
            this.dungeonAnzeigePictureCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dungeonAnzeigePictureCheckbox.Name = "dungeonAnzeigePictureCheckbox";
            this.dungeonAnzeigePictureCheckbox.Size = new System.Drawing.Size(186, 40);
            this.dungeonAnzeigePictureCheckbox.TabIndex = 6;
            this.dungeonAnzeigePictureCheckbox.Text = "Bildmodus";
            this.dungeonAnzeigePictureCheckbox.UseVisualStyleBackColor = true;
            this.dungeonAnzeigePictureCheckbox.CheckedChanged += new System.EventHandler(this.dungeonAnzeigePictureCheckbox_CheckedChanged);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Teal;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(1173, 710);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(365, 78);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Spielen";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // statsAusgabeLabel
            // 
            this.statsAusgabeLabel.AutoSize = true;
            this.statsAusgabeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.statsAusgabeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsAusgabeLabel.Location = new System.Drawing.Point(1219, 14);
            this.statsAusgabeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statsAusgabeLabel.Name = "statsAusgabeLabel";
            this.statsAusgabeLabel.Size = new System.Drawing.Size(266, 36);
            this.statsAusgabeLabel.TabIndex = 3;
            this.statsAusgabeLabel.Text = "Dungeon Statistik";
            // 
            // statsAnzeige
            // 
            this.statsAnzeige.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.statsAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statsAnzeige.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.statsAnzeige.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsAnzeige.ForeColor = System.Drawing.Color.White;
            this.statsAnzeige.Location = new System.Drawing.Point(1147, 14);
            this.statsAnzeige.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statsAnzeige.Name = "statsAnzeige";
            this.statsAnzeige.ReadOnly = true;
            this.statsAnzeige.Size = new System.Drawing.Size(417, 679);
            this.statsAnzeige.TabIndex = 1;
            this.statsAnzeige.Text = "";
            this.statsAnzeige.WordWrap = false;
            // 
            // dungeonAnzeige
            // 
            this.dungeonAnzeige.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dungeonAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dungeonAnzeige.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dungeonAnzeige.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonAnzeige.ForeColor = System.Drawing.Color.White;
            this.dungeonAnzeige.Location = new System.Drawing.Point(381, 14);
            this.dungeonAnzeige.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dungeonAnzeige.Name = "dungeonAnzeige";
            this.dungeonAnzeige.ReadOnly = true;
            this.dungeonAnzeige.Size = new System.Drawing.Size(760, 745);
            this.dungeonAnzeige.TabIndex = 0;
            this.dungeonAnzeige.Text = "";
            this.dungeonAnzeige.WordWrap = false;
            // 
            // panelUserInterface
            // 
            this.panelUserInterface.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelUserInterface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserInterface.Controls.Add(this.buttonQuit);
            this.panelUserInterface.Controls.Add(this.tabsUI);
            this.panelUserInterface.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserInterface.Location = new System.Drawing.Point(0, 0);
            this.panelUserInterface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserInterface.Name = "panelUserInterface";
            this.panelUserInterface.Size = new System.Drawing.Size(375, 814);
            this.panelUserInterface.TabIndex = 2;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.White;
            this.buttonQuit.Location = new System.Drawing.Point(51, 753);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(269, 46);
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
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // HauptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.panelUserInterface);
            this.Controls.Add(this.panelDungeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "HauptForm";
            this.Text = "Dungeon Generator";
            this.tabsUI.ResumeLayout(false);
            this.tabPageGenerate.ResumeLayout(false);
            this.tabPageGenerate.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageExport.ResumeLayout(false);
            this.tabPageExport.PerformLayout();
            this.panelDungeon.ResumeLayout(false);
            this.panelDungeon.PerformLayout();
            this.panelDungeonAnzeigePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dungeonAnzeigePicture)).EndInit();
            this.panelUserInterface.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsUI;
        private System.Windows.Forms.TabPage tabPageGenerate;
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
        private System.Windows.Forms.Button tabExportButtonExport;
        private System.Windows.Forms.TextBox tabExportTextFilePath;
        private System.Windows.Forms.TextBox tabExportTextFileName;
        private System.Windows.Forms.Label tabExportError;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label tabGenLabelHeight;
        private System.Windows.Forms.Label tabGenLabelWidth;
        private System.Windows.Forms.Button tabExportButtonRandomName;
        private System.Windows.Forms.Label tabGenLabelPreset;
        private System.Windows.Forms.ComboBox tabGenDropPreset;
        private System.Windows.Forms.TextBox tabGenTextSeed;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label tabGenLabelSeed;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Label tabSettingTitleLableColor;
        private System.Windows.Forms.Button tabSettingButtonConfigImport;
        private System.Windows.Forms.Button tabSettingButtonConfigExport;

        private System.Windows.Forms.Label tabSettingLabelConfigExpImp;
        private System.Windows.Forms.TextBox tabSettingTextConfigExpImp;
        private System.Windows.Forms.ComboBox tabSettingDropWalls;
        private System.Windows.Forms.Label tabSettingLabelWalls;
        private System.Windows.Forms.ComboBox tabSettingDropFloor;
        private System.Windows.Forms.Label tabSettingLabelFloor;
        private System.Windows.Forms.ComboBox tabSettingDropTrap;
        private System.Windows.Forms.ComboBox tabSettingDropTreasure;
        private System.Windows.Forms.ComboBox tabSettingDropEnd;
        private System.Windows.Forms.Label tabSettingLabelTraps;
        private System.Windows.Forms.Label tabSettingLabelTreasure;
        private System.Windows.Forms.Label tabSettingLabelEnd;
        private System.Windows.Forms.Label tabSettingLabelStart;
        private System.Windows.Forms.ComboBox tabSettingDropStart;
        private System.Windows.Forms.Label tabGenTitleLabelRooms;
        private System.Windows.Forms.Label tabGenTitleLabelGeneral;
        private System.Windows.Forms.TextBox tabGenTextRoomHeightMax;
        private System.Windows.Forms.Label tabGenLabelRoomHeightMax;
        private System.Windows.Forms.TextBox tabGenTextRoomHeightMin;
        private System.Windows.Forms.Label tabGenLabelRoomHeightMin;
        private System.Windows.Forms.Label tabGenLabelRoomHeight;
        private System.Windows.Forms.TextBox tabGenTextRoomWidthMax;
        private System.Windows.Forms.Label tabGenLabelRoomWidthMax;
        private System.Windows.Forms.TextBox tabGenTextRoomWidthMin;
        private System.Windows.Forms.Label tabGenLabelRoomWidthMin;
        private System.Windows.Forms.Label tabGenLabelRoomWidth;
        private System.Windows.Forms.Label tabGenTitleLabelObjects;
        private System.Windows.Forms.RichTextBox dungeonAnzeige;
        private System.Windows.Forms.RichTextBox statsAnzeige;
        private System.Windows.Forms.Label statsAusgabeLabel;
        private System.Windows.Forms.TextBox tabGenTextRoomCountMax;
        private System.Windows.Forms.Label tabGenLabelRoomCountMax;
        private System.Windows.Forms.TextBox tabGenTextRoomCountMin;
        private System.Windows.Forms.Label tabGenLabelRoomCountMin;
        private System.Windows.Forms.Label tabGenLabelRoomCount;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.CheckBox dungeonAnzeigePictureCheckbox;
        private System.Windows.Forms.Panel panelDungeonAnzeigePicture;
        private System.Windows.Forms.PictureBox dungeonAnzeigePicture;
    }
}