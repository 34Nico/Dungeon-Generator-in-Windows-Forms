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

        static string[] colors = new string[] { "Rot", "Grüner", "Blau", "Gelb", "Türkis", "Lila", "Weiß", "Grau" };


        int maxHeightDungeon = 580;

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
         */
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /*      Click Eventhandler von Generate button
         */
        private void tabGenButtonGenerate_Click(object sender, EventArgs e)
        {

            if (!validateUserInterface())
                return;

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

            if (errors.Count > 1)
            {

                MessageBox.Show("Du hast " + errors.Count() + " Fehler, die du beheben musst, bevor du den Dungeon generieren kannst:\n\n - "
                    + string.Join("\n - ", errors), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return false;
            }
            if (errors.Count == 1)
            {

                MessageBox.Show("Du hast " + errors.Count() + " Fehler, den du beheben musst, bevor du den Dungeon generieren kannst:\n\n - "
                    + string.Join("\n - ", errors), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return false;
            }

            return true;
        }
    }

}
