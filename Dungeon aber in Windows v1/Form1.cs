using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
         */

        static string[] colors = new string[] { "Rot", "Grüner", "Blau", "Gelb", "Türkis", "Lila", "Weiß", "Grau" };

        static string[] presetNames = new string[] { "Small", "Medium", "Large", "Goldkammer", "Hölle" };
        int[,] presets =
        {
            {10, 10, 5, 5},
            {25, 25, 7, 6},
            {40, 40, 10, 8},
            {20, 20, 2, 25},
            {20, 20, 25, 4}
        };

        int maxHeightDungeonWindow = 580;

        // Generate Defaults
        int dungeonHeight = 10;
        int dungeonWidth = 10;
        int dungeonTrapPercent = 5;
        int dungeonTreasurePercent = 5;

        // Settings Defaults (Index von colors)
        int settingsStartColor = 5;
        int settingsEndColor = 5;
        int settingsTrapColor = 0;
        int settingsTreasureColor = 3;
        int settingsFloorColor = 6;
        int settingsWallColor = 7;

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

            for(int i = 0; i < presetNames.Length; i++)
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

        /*
         * =========================================
         *              Features
         * =========================================
         */

        /*      Click Eventhandler von Quit button
         *      Programm stoppen
         */
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /*      Click Eventhandler von Random Name button
         *      Erstellt einen Random Namen mithilfe von 2 Listen mit verschiedenen Wörtern
         */
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

        /*      SelectedIndexChanged Eventhandler von Preset Dropdown
         *      Handelt das ändern eines Presets und stellt alle nötigen Einstellungen um
         */
        private void tabGenDropPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            int presetIndex = tabGenDropPreset.SelectedIndex;

            if (presetIndex != -1)
            {
                tabGenTextHeight.Text = presets[presetIndex, 0].ToString();
                tabGenTextWidth.Text = presets[presetIndex, 1].ToString();
                tabGenTextTrapPercent.Text = presets[presetIndex, 2].ToString();
                tabGenTextTreasurePercent.Text = presets[presetIndex, 3].ToString();
            }
        }

        /*      Click Eventhandler von Generate button
         *      Auch die Hauptmethode zum Dungeon generieren
         */
        private void tabGenButtonGenerate_Click(object sender, EventArgs e)
        {

            if (!validateUserInterface())
                return;

        }

        /*      Click Eventhandler von Export button
         *      Exportiert den Dungeon als Textdatei an den angegebenen Ort mit dem angegebenen Namen
         */
        private void tabSettingButtonConfigExport_Click(object sender, EventArgs e)
        {
            string settingsString = settingsStartColor + ";" + settingsEndColor + ";" + settingsTrapColor + ";" + settingsTreasureColor + ";" + settingsFloorColor + ";" + settingsWallColor + ";" +
                                    dungeonHeight + ";" + dungeonWidth + ";" + dungeonTrapPercent + ";" + dungeonTreasurePercent + ";" + exportFileName;

            tabSettingTextConfigExpImp.Text = settingsString;
        }

        /*      Click Eventhandler von Import Settings button
         *      Importiert die Einstellungen aus einer Textdatei und stellt die UI entsprechend um
         */
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

                exportFileName = settings[10];

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

                tabExportTextFileName.Text = exportFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Importieren: " + ex.Message);
            }
        }

        /*
         * =========================================
         *              Hilfsmethoden
         * =========================================
         */

        private bool validateUserInterface()
        {
            List<string> errors = new List<string>();

            /*
             * Generate
             */

            if (!int.TryParse(tabGenTextHeight.Text, out dungeonHeight))
            {
                errors.Add("Die Höhe muss eine Zahl sein!");
            }
            else if (dungeonHeight < 10 || dungeonHeight > 40)
            {
                errors.Add("Die Höhe des Dungeons muss zwischen 10 und 40 liegen!");
            }
            tabGenTextHeight.Text = dungeonHeight.ToString();


            if (!int.TryParse(tabGenTextWidth.Text, out dungeonWidth))
            {
                errors.Add("Die Breite muss eine Zahl sein!");
            }
            else if (dungeonWidth < 10 || dungeonWidth > 40)
            {
                errors.Add("Die Breite des Dungeons muss zwischen 10 und 40 liegen!");
            }


            if (!int.TryParse(tabGenTextTrapPercent.Text, out dungeonTrapPercent))
            {
                errors.Add("Trap Prozent muss eine Zahl sein!");
            }
            else if (dungeonTrapPercent < 0 || dungeonTrapPercent > 100)
            {
                errors.Add("Trap Prozent muss zwischen 0 und 100 liegen!");
            }


            if (!int.TryParse(tabGenTextTreasurePercent.Text, out dungeonTreasurePercent))
            {
                errors.Add("Treasure Prozent muss eine Zahl sein!");
            }
            else if (dungeonTreasurePercent < 0 || dungeonTreasurePercent > 100)
            {
                errors.Add("Treasure Prozent muss zwischen 0 und 100 liegen!");
            }

            if(dungeonTrapPercent + dungeonTrapPercent > 100)
            {
                errors.Add("Die Summe von Trap Prozent und Treasure Prozent darf nicht über 100 sein!");
            }


            /*
             * Settings
             */

            settingsStartColor = tabSettingDropStart.SelectedIndex;
            settingsEndColor = tabSettingDropEnd.SelectedIndex;
            settingsTrapColor = tabSettingDropTrap.SelectedIndex;
            settingsTreasureColor = tabSettingDropTreasure.SelectedIndex;
            settingsFloorColor = tabSettingDropFloor.SelectedIndex;
            settingsWallColor = tabSettingDropWalls.SelectedIndex;

            if (settingsStartColor == -1) errors.Add("Startfarbe wurde nicht gewählt!");
            if (settingsEndColor == -1) errors.Add("Endfarbe wurde nicht gewählt!");
            if (settingsTrapColor == -1) errors.Add("Trapfarbe wurde nicht gewählt!");
            if (settingsTreasureColor == -1) errors.Add("Treasurefarbe wurde nicht gewählt!");
            if (settingsFloorColor == -1) errors.Add("Floorfarbe wurde nicht gewählt!");
            if (settingsWallColor == -1) errors.Add("Wallfarbe wurde nicht gewählt!");

            /*
             * Fehler anzeigen
             */

            if (errors.Count > 0)
            {

                MessageBox.Show("Du hast " + errors.Count() + " Fehler, die du beheben musst:\n\n - "
                    + string.Join("\n - ", errors), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return false;
            }

            return true;
        }


    }

}
