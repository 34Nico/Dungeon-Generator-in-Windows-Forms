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

        int maxHeightDungeon = 580;

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

            tabGenTextHeight.Text = "10";
            tabGenTextWidth.Text = "10";
            tabGenTextTrapPercent.Text = "5";
            tabGenTextTreasurePercent.Text = "5";

            /*
             *      Settings
             */

            string[] colors = new string[] { "Rot", "Grüner", "Blau", "Gelb", "Türkis", "Lila", "Weiß", "Grau" };

            for(int i = 0; i < colors.Length; i++)
            {
                tabSettingDropStart.Items.Add(colors[i]);
                tabSettingDropEnd.Items.Add(colors[i]);
                tabSettingDropTrap.Items.Add(colors[i]);
                tabSettingDropTreasure.Items.Add(colors[i]);
                tabSettingDropFloor.Items.Add(colors[i]);
                tabSettingDropWalls.Items.Add(colors[i]);
            }

            tabSettingDropStart.SelectedIndex = 5;
            tabSettingDropEnd.SelectedIndex = 5;
            tabSettingDropTrap.SelectedIndex = 0;
            tabSettingDropTreasure.SelectedIndex = 3;
            tabSettingDropFloor.SelectedIndex = 6;
            tabSettingDropWalls.SelectedIndex = 7;

            /*
             *      Export
             */

            tabExportButtonExport.Enabled = false;
            tabExportTextFileName.Enabled = false;
            tabExportTextFilePath.Enabled = false;

            tabExportTextFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            tabExportTextFileName.Text = "Dungeon";

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



        /*
         * =========================================
         *              Hilfsmethoden
         * =========================================
         */


    }
}
