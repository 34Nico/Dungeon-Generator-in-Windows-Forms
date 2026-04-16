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
         * - Mukke (WE LIVE WE LOVE WE LIE)
         */

        /*
         * feddisch:
         * - Dungeon spielbar machen
         */

        char[,] map = null;
        Bitmap bmp = null;

        int playerX = 0;
        int playerY = 0;

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
            for (int y = 0; y < map.GetLength(1); y++)
                for (int x = 0; x < map.GetLength(0); x++)
                    if (map[x, y] == 'S')
                    {
                        playerX = x;
                        playerY = y;
                    }

            this.KeyPreview = true;
            this.KeyDown += PlayForm_KeyDown;

            DrawMap();
            DrawPlayer();
        }

        private void DrawMap()
        {
            int tileSize = 14;
            int width = map.GetLength(0) * tileSize;
            int height = map.GetLength(1) * tileSize;

            bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int y = 0; y < map.GetLength(1); y++)
                    for (int x = 0; x < map.GetLength(0); x++)
                        DrawTile(g, x, y, tileSize);
            }

            if (panelGame.Controls.Count == 0)
            {
                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                panelGame.Controls.Add(pb);
            }

            ((PictureBox)panelGame.Controls[0]).Image = bmp;
        }

        private void DrawTile(Graphics g, int x, int y, int tileSize)
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

        private void DrawPlayer()
        {
            int tileSize = 14;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(Properties.Resources.Player, playerX * tileSize, playerY * tileSize, tileSize, tileSize);
            }
            ((PictureBox)panelGame.Controls[0]).Image = bmp;
            ((PictureBox)panelGame.Controls[0]).Refresh();
        }

        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            int newX = playerX;
            int newY = playerY;

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) newY--;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) newY++;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) newX--;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) newX++;

            if (map[newX, newY] == '#') return;

            char tile = map[newX, newY];
            moves++;

            // Altes Tile neu zeichnen (Spieler weg)
            int tileSize = 14;
            using (Graphics g = Graphics.FromImage(bmp))
                DrawTile(g, playerX, playerY, tileSize);

            if (tile == 'T')
            {
                treasureCollected++;
                map[newX, newY] = '.';
                playerX = newX;
                playerY = newY;
                DrawPlayer();
                MessageBox.Show($"Du hast eine Schatztruhe gefunden! ({treasureCollected} gesamt)");
            }
            else if (tile == 'F')
            {
                lifes--;
                map[newX, newY] = '.';
                playerX = newX;
                playerY = newY;
                DrawPlayer();
                MessageBox.Show($"Du bist in eine Falle getreten! Leben übrig: {lifes}");
                if (lifes <= 0)
                {
                    MessageBox.Show($"Game Over! Du hast {treasureCollected} Schätze gesammelt in {moves} Zügen.");
                    this.Close();
                    return;
                }
            }
            else if (tile == 'E')
            {
                playerX = newX;
                playerY = newY;
                DrawPlayer();
                MessageBox.Show($"Du hast den Ausgang gefunden!\nSchätze: {treasureCollected}\nZüge: {moves}");
                this.Close();
                return;
            }
            else
            {
                playerX = newX;
                playerY = newY;
                DrawPlayer();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hauptForm != null)
            {
                if (hauptForm.WindowState == FormWindowState.Minimized)
                    hauptForm.WindowState = FormWindowState.Normal;

                hauptForm.Activate();
            }
        }
    }
}