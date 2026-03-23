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
    public partial class PlayForm : Form
    {

        /*
         * TODO:
         * - Dungeon spielbar machen
         * - Mukke (WE LIVE WE LOVE WE LIE)
         */

        /*
         * feddisch:
         * - Dungeon spielbar machen
         */


        // Variablen zum Spielen

        int lifes = 5;
        int treasureCollected = 0;
        int moves = 0;

        private HauptForm hauptForm;

        public PlayForm(HauptForm hauptForm)
        {
            InitializeComponent();
            this.hauptForm = hauptForm;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hauptForm != null)
            {
                if (hauptForm.WindowState == FormWindowState.Minimized)
                {
                    hauptForm.WindowState = FormWindowState.Normal;
                }

                hauptForm.Activate();
            }
        }
    }
}
