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

        char[,] map = null;
        PictureBox pictureBox = new PictureBox
        {
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.Zoom
        };

        // Variablen zum Spielen

        int lifes = 5;
        int treasureCollected = 0;
        int moves = 0;

        private HauptForm hauptForm;

        public PlayForm(HauptForm hauptForm, char[,] map)
        {
            InitializeComponent();

            this.hauptForm = hauptForm;
            this.map = map;
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pictureBox);

            pictureBox.Paint += (object send, PaintEventArgs paintEventArgs) =>
            {
                int tileSize = 14;
                Graphics g = paintEventArgs.Graphics;

                for (int y = 0; y < map.GetLength(1); y++)
                {
                    for (int x = 0; x < map.GetLength(0); x++)
                    {
                        Image img = null;

                        switch (map[x, y])
                        {
                            case '#': img = Properties.Resources.Wall; break;
                            case '.': img = Properties.Resources.Floor; break;
                            case 'S': img = Properties.Resources.Start; break;
                            case 'E': img = Properties.Resources.Ende; break;
                            case 'T': img = Properties.Resources.Treasure; break;
                            case 'F': img = Properties.Resources.Bomb; break;
                        }

                        if (img != null)
                            g.DrawImage(img, x * tileSize, y * tileSize, tileSize, tileSize);
                    }
                }
            };
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
