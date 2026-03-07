using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dungeon_aber_in_Windows_v1
{
    public partial class Form1 : Form
    {

        /*
         * TODO:
         *  - Dungeon generieren
         *      - Dungeon als 2D Array generieren und irgendwie schön darstellen
         *  - Dungeon exportieren
         *      - Dungeon als Textdatei exportieren
         *      - Toggle, ob man die Settings mit exportieren möchte oder nicht
         *  - Legende + Dungeon Statistik anzeigen
         *  - vielleicht Dungeons laden können
         */

        /*
         * FERTIG:
         *  - User Interface erstellen
         *  - User Interface mit Default Werten füllen
         *  - User Interface validieren
         *  - Quit Button zum Schließen des Programms hinzufügen
         *  - Fehler anzeigen, wenn die Validierung fehlschlägt
         *  - Random Name Generator für den Export hinzufügen
         *  - Presets zum Generieren hinzufügen
         *  - Exportieren/Importieren der Einstellungen als String hinzufügen
         *  - Dungeon Seedbasiert machen
         */

        Random random = new Random();

        static string[] colors = new string[] { "Rot", "Grüner", "Blau", "Gelb", "Türkis", "Lila", "Weiß", "Grau" };

        static string[] presetNames = new string[] { "Small", "Medium", "Large", "Goldkammer", "Hölle" };
        int[,] presets =
        {
            {10, 10, 5, 5, 1, 3, 1, 3},
            {25, 25, 7, 6, 2, 4, 2, 4},
            {40, 40, 10, 8, 3, 7, 3, 7},
            {20, 20, 2, 25, 3, 4, 3, 4},
            {20, 20, 25, 4, 3, 4, 3, 4}
        };

        // Generate Defaults
        int dungeonHeight = 10;
        int dungeonWidth = 10;
        int dungeonTrapPercent = 5;
        int dungeonTreasurePercent = 5;
        int dungeonMinRoomSizeWidth = 3;
        int dungeonMaxRoomSizeWidth = 7;
        int dungeonMinRoomSizeHeight = 3;
        int dungeonMaxRoomSizeHeight = 7;

        int dungeonSeed = 0;

        // Settings Defaults (Index von colors)
        int settingsStartColor = 5;
        int settingsEndColor = 5;
        int settingsTrapColor = 0;
        int settingsTreasureColor = 3;
        int settingsFloorColor = 6;
        int settingsWallColor = 7;

        int minRoomSizeWidth = 3;
        int maxRoomSizeWidth = 7;
        int minRoomSizeHeight = 3;
        int maxRoomSizeHeight = 7;

        // Export Defaults
        string exportFileName = "Dungeon";
        string exportFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Form1()
        {
            InitializeComponent();
            loadUserInterfaceDefaults();

        }

        private void loadUserInterfaceDefaults()
        {

            /*
             *      Generate
             */

            tabGenTextHeight.Text = dungeonHeight.ToString();
            tabGenTextWidth.Text = dungeonWidth.ToString();
            tabGenTextTrapPercent.Text = dungeonTrapPercent.ToString();
            tabGenTextTreasurePercent.Text = dungeonTreasurePercent.ToString();

            for (int i = 0; i < presetNames.Length; i++)
            tabGenTextRoomWidthMin.Text = dungeonMinRoomSizeWidth.ToString();
            tabGenTextRoomWidthMax.Text = dungeonMaxRoomSizeWidth.ToString();
            tabGenTextRoomHeightMin.Text = dungeonMinRoomSizeHeight.ToString();
            tabGenTextRoomHeightMax.Text = dungeonMaxRoomSizeHeight.ToString();

            for (int i = 0; i < presetNames.Length; i++)
            {
                tabGenDropPreset.Items.Add(presetNames[i]);
            }

            /*
             *      Settings
             */

            for (int i = 0; i < colors.Length; i++)
            {
                tabSettingDropStart.Items.Add(colors[i]);
                tabSettingDropEnd.Items.Add(colors[i]);
                tabSettingDropTrap.Items.Add(colors[i]);
                tabSettingDropTreasure.Items.Add(colors[i]);
                tabSettingDropFloor.Items.Add(colors[i]);
                tabSettingDropWalls.Items.Add(colors[i]);
            }

            tabSettingDropStart.SelectedIndex = settingsStartColor;
            tabSettingDropEnd.SelectedIndex = settingsEndColor;
            tabSettingDropTrap.SelectedIndex = settingsTrapColor;
            tabSettingDropTreasure.SelectedIndex = settingsTreasureColor;
            tabSettingDropFloor.SelectedIndex = settingsFloorColor;
            tabSettingDropWalls.SelectedIndex = settingsWallColor;

            /*
             *      Export
             */

            tabExportButtonExport.Enabled = false;
            tabExportTextFileName.Enabled = false;
            tabExportTextFilePath.Enabled = false;
            tabExportButtonRandomName.Enabled = false;

            tabExportTextFilePath.Text = exportFilePath;
            tabExportTextFileName.Text = exportFileName;

            tabExportError.Text = "Noch keinen exportierbaren Dungeon erstellt!";

        }

        private void tabGenButtonGenerate_Click(object sender, EventArgs e)
        {

            if (!validateUserInterface())
                return;

            if (String.IsNullOrEmpty(tabGenTextSeed.Text) || dungeonSeed == Convert.ToInt32(tabGenTextSeed.Text))
            {
                dungeonSeed = random.Next(1, 1000000);
            }
            else
            {
                dungeonSeed = int.Parse(tabGenTextSeed.Text);
            }

            random = new Random(dungeonSeed);
            tabGenTextSeed.Text = dungeonSeed.ToString();

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tabExportButtonRandomName_Click(object sender, EventArgs e)
        {
            List<string> prefix = new List<string>()
            {
                "Dunkler","Verlassener","Vergessener","Verfluchter","Verlorener",
                "Blutiger","Uralter","Geheimer","Verborgener","Schattenhafter",
                "Unheilvoller","Verdammter","Tiefer","Endloser","Zerfallener",
                "Heulender","Ewiger","Verstörter","Nebliger","Düsterer",
                "Stiller","Gefallener","Finstere","Grausamer","Unheiliger",
                "Vergifteter","Verstorbener","Unendlicher","Eisiger","Flüsternder"
            };

            List<string> suffix = new List<string>()
            {
                "Abgrund","Kerker","Katakomben","Labyrinth","Höhle",
                "Schacht","Gewölbe","Ruinen","Festung","Grab",
                "Tempel","Bastion","Tiefen","Kammern","Gänge",
                "Verlies","Tunnel","Hall","Domäne","Krypta",
                "Ruine","Unterwelt","Schlund","Feste","Schattenreich",
                "Tiefenlabyrinth","Schwarze Hallen","Seelengruft","Grabkammern","Nekropole"
            };

            Random rand = new Random();

            string randomName = prefix[rand.Next(prefix.Count)] + " " + suffix[rand.Next(suffix.Count)];

            tabExportTextFileName.Text = randomName;
        }

        private void tabGenDropPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            int presetIndex = tabGenDropPreset.SelectedIndex;

            if (presetIndex != -1)
            {
                tabGenTextHeight.Text = presets[presetIndex, 0].ToString();
                tabGenTextWidth.Text = presets[presetIndex, 1].ToString();
                tabGenTextTrapPercent.Text = presets[presetIndex, 2].ToString();
                tabGenTextTreasurePercent.Text = presets[presetIndex, 3].ToString();
                tabGenTextRoomWidthMin.Text = presets[presetIndex, 4].ToString();
                tabGenTextRoomWidthMax.Text = presets[presetIndex, 5].ToString();
                tabGenTextRoomHeightMin.Text = presets[presetIndex, 6].ToString();
                tabGenTextRoomHeightMax.Text = presets[presetIndex, 7].ToString();
            }
        }

        private void tabSettingButtonConfigExport_Click(object sender, EventArgs e)
        {
            string settingsString = settingsStartColor + ";" + settingsEndColor + ";" + settingsTrapColor + ";" +
                settingsTreasureColor + ";" + settingsFloorColor + ";" + settingsWallColor + ";" +
                dungeonHeight + ";" + dungeonWidth + ";" + dungeonTrapPercent + ";" + dungeonTreasurePercent + ";" +
                dungeonMinRoomSizeWidth + ";" + dungeonMaxRoomSizeWidth + ";" + dungeonMinRoomSizeHeight + ";" + dungeonMaxRoomSizeHeight + ";" +
                exportFileName;

            tabSettingTextConfigExpImp.Text = settingsString;
        }

        private void tabSettingButtonConfigImport_Click(object sender, EventArgs e)
        {
            string[] settings = tabSettingTextConfigExpImp.Text.Split(';');

            if (settings.Length != 11)
            {
                MessageBox.Show("Die Einstellungen müssen genau 11 Werte enthalten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                settingsStartColor = int.Parse(settings[0]);
                settingsEndColor = int.Parse(settings[1]);
                settingsTrapColor = int.Parse(settings[2]);
                settingsTreasureColor = int.Parse(settings[3]);
                settingsFloorColor = int.Parse(settings[4]);
                settingsWallColor = int.Parse(settings[5]);

                dungeonHeight = int.Parse(settings[6]);
                dungeonWidth = int.Parse(settings[7]);
                dungeonTrapPercent = int.Parse(settings[8]);
                dungeonTreasurePercent = int.Parse(settings[9]);

                dungeonMinRoomSizeWidth = int.Parse(settings[10]);
                dungeonMaxRoomSizeWidth = int.Parse(settings[11]);
                dungeonMinRoomSizeHeight = int.Parse(settings[12]);
                dungeonMaxRoomSizeHeight = int.Parse(settings[13]);

                exportFileName = settings[14];

                tabSettingDropStart.SelectedIndex = settingsStartColor;
                tabSettingDropEnd.SelectedIndex = settingsEndColor;
                tabSettingDropTrap.SelectedIndex = settingsTrapColor;
                tabSettingDropTreasure.SelectedIndex = settingsTreasureColor;
                tabSettingDropFloor.SelectedIndex = settingsFloorColor;
                tabSettingDropWalls.SelectedIndex = settingsWallColor;

                tabGenTextHeight.Text = dungeonHeight.ToString();
                tabGenTextWidth.Text = dungeonWidth.ToString();
                tabGenTextTrapPercent.Text = dungeonTrapPercent.ToString();
                tabGenTextTreasurePercent.Text = dungeonTreasurePercent.ToString();

                tabGenTextRoomWidthMin.Text = dungeonMinRoomSizeWidth.ToString();
                tabGenTextRoomWidthMax.Text = dungeonMaxRoomSizeHeight.ToString();
                tabGenTextRoomHeightMin.Text = dungeonMinRoomSizeHeight.ToString();
                tabGenTextRoomHeightMax.Text = dungeonMaxRoomSizeHeight.ToString();

                tabExportTextFileName.Text = exportFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Importieren: " + ex.Message);
            }
        }

        private bool validateUserInterface()
        {
            List<string> errors = new List<string>();

            if (tabGenDropPreset.SelectedIndex != -1)
            {
                dungeonHeight = presets[tabGenDropPreset.SelectedIndex, 0];
                dungeonWidth = presets[tabGenDropPreset.SelectedIndex, 1];
                dungeonTrapPercent = presets[tabGenDropPreset.SelectedIndex, 2];
                dungeonTreasurePercent = presets[tabGenDropPreset.SelectedIndex, 3];

                dungeonMinRoomSizeWidth = presets[tabGenDropPreset.SelectedIndex, 4];
                dungeonMaxRoomSizeWidth = presets[tabGenDropPreset.SelectedIndex, 5];
                dungeonMinRoomSizeHeight = presets[tabGenDropPreset.SelectedIndex, 6];
                dungeonMaxRoomSizeHeight = presets[tabGenDropPreset.SelectedIndex, 7];
            }
            else
            {
                ValidateInt(tabGenTextHeight, 10, 40, "Die Höhe des Dungeons", errors, out dungeonHeight);
                ValidateInt(tabGenTextWidth, 10, 40, "Die Breite des Dungeons", errors, out dungeonWidth);

                ValidateInt(tabGenTextTrapPercent, 0, 100, "Trap Prozent", errors, out dungeonTrapPercent);
                ValidateInt(tabGenTextTreasurePercent, 0, 100, "Treasure Prozent", errors, out dungeonTreasurePercent);

                if (dungeonTrapPercent + dungeonTreasurePercent > 100)
                {
                    errors.Add("Die Summe von Trap Prozent und Treasure Prozent darf nicht über 100 sein!");
                }

                ValidateInt(tabGenTextRoomWidthMin, 1, 10, "Minimale Raumgröße (Breite)", errors, out dungeonMinRoomSizeWidth);
                ValidateInt(tabGenTextRoomWidthMax, 1, 10, "Maximale Raumgröße (Breite)", errors, out dungeonMaxRoomSizeWidth);

                if (dungeonMinRoomSizeWidth > dungeonMaxRoomSizeWidth)
                {
                    errors.Add("Mindest Breite eines Raumes darf nicht größer sein als das Maximum!");
                }

                ValidateInt(tabGenTextRoomHeightMin, 1, 10, "Minimale Raumgröße (Höhe)", errors, out dungeonMinRoomSizeHeight);
                ValidateInt(tabGenTextRoomHeightMax, 1, 10, "Maximale Raumgröße (Höhe)", errors, out dungeonMaxRoomSizeHeight);

                if (dungeonMinRoomSizeHeight > dungeonMaxRoomSizeHeight)
                {
                    errors.Add("Mindest Höhe eines Raumes darf nicht größer sein als das Maximum!");
                }
            }

            if (!String.IsNullOrWhiteSpace(tabGenTextSeed.Text))
            {
                ValidateInt(tabGenTextSeed, 1, 1000000, "Seed", errors, out _);
            }

            ValidateDropdown(tabSettingDropStart, "Startfarbe", errors, out settingsStartColor);
            ValidateDropdown(tabSettingDropEnd, "Endfarbe", errors, out settingsEndColor);
            ValidateDropdown(tabSettingDropTrap, "Trapfarbe", errors, out settingsTrapColor);
            ValidateDropdown(tabSettingDropTreasure, "Treasurefarbe", errors, out settingsTreasureColor);
            ValidateDropdown(tabSettingDropFloor, "Floorfarbe", errors, out settingsFloorColor);
            ValidateDropdown(tabSettingDropWalls, "Wallfarbe", errors, out settingsWallColor);

            if (errors.Any())
            {
                MessageBox.Show(
                    "Du hast " + errors.Count + " Fehler, die du beheben musst:\n\n - " +
                    string.Join("\n - ", errors),
                    "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            return true;
        }

        private bool ValidateInt(TextBox box, int min, int max, string name, List<string> errors, out int value)
        {
            if (!int.TryParse(box.Text, out value))
            {
                errors.Add(name + " muss eine Zahl sein!");
                return false;
            }

            if (value < min || value > max)
            {
                errors.Add($"{name} muss zwischen {min} und {max} liegen!");
                return false;
            }

            return true;
        }

        private void ValidateDropdown(ComboBox box, string name, List<string> errors, out int value)
        {
            value = box.SelectedIndex;

            if (value == -1)
            {
                errors.Add(name + " wurde nicht gewählt!");
            }
        }

    }

}