using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dungeon_aber_in_Windows_v1
{
    public partial class Form1 : Form
    {

        /*
         * TODO:
         *  - Farben machen
         *  - Dungeon exportieren
         *      - Dungeon als Textdatei exportieren
         *      - Toggle, ob man die Settings mit exportieren möchte oder nicht
         *  - vielleicht Dungeons laden können
         *  - Truhen/Traps an und aus schalten
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
         *  - Dungeon generieren
         *  - Dungeon als 2D Array generieren und irgendwie schön darstellen
         *  - Legende + Dungeon Statistik anzeigen
         *  - Dungeon zoomen können mit einem Slider
         */

        Random random = new Random();

        static char[,] map;

        static string[] colors = new string[] { "Rot", "Grün", "Blau", "Gelb", "Türkis", "Lila", "Weiß", "Grau" };

        static string[] presetNames = new string[] { "Small", "Medium", "Large", "Goldkammer", "Hölle", "GIGANTISCH" };
        int[,] presets =
        {
            {10, 10, 5, 5, 1, 3, 1, 3, 1, 1},
            {25, 25, 7, 6, 2, 4, 2, 4, 1, 3},
            {40, 40, 10, 8, 3, 7, 3, 7, 4, 6},
            {20, 20, 2, 25, 3, 4, 3, 4, 1, 3},
            {20, 20, 25, 4, 3, 4, 3, 4, 1, 3},
            {250, 250, 4, 4, 10, 50, 10, 50, 30, 65}
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
        int dungeonMinRoomCount = 3;
        int dungeonMaxRoomCount = 6;

        int dungeonSeed = 0;

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

        bool dungeonGenerated = false;
        string finishedDungeon = "";

        // Variablen zur Endstatistik Ausgabe

        int finishedTreasureCount = 0;
        int finishedTrapCount = 0;
        int finishedRoomCount = 0;

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

            tabGenTextRoomWidthMin.Text = dungeonMinRoomSizeWidth.ToString();
            tabGenTextRoomWidthMax.Text = dungeonMaxRoomSizeWidth.ToString();
            tabGenTextRoomHeightMin.Text = dungeonMinRoomSizeHeight.ToString();
            tabGenTextRoomHeightMax.Text = dungeonMaxRoomSizeHeight.ToString();
            tabGenTextRoomCountMin.Text = dungeonMinRoomCount.ToString();
            tabGenTextRoomCountMax.Text = dungeonMaxRoomCount.ToString();

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



        /*
         * ===================================
         *              Programm Features
         * ===================================
         */



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

            finishedTrapCount = 0;
            finishedTreasureCount = 0;

            generateDungeon();

            dungeonAnzeige.SuspendLayout();
            dungeonAnzeige.Clear();
            dungeonAnzeige.AppendText("\n\n");

            // Dungeon zeichnen
            for (int y = 0; y < dungeonHeight; y++)
            {
                for (int x = 0; x < dungeonWidth; x++)
                {
                    char tile = map[x, y];

                    Color color = GetTileColor(tile);

                    AppendColoredText(dungeonAnzeige, tile.ToString(), color);
                }

                dungeonAnzeige.AppendText("\n");
            }

            dungeonAnzeige.ResumeLayout();

            SendDungeonStatistic();

            dungeonGenerated = true;

            tabExportButtonExport.Enabled = true;
            tabExportTextFileName.Enabled = true;
            tabExportTextFilePath.Enabled = true;
            tabExportButtonRandomName.Enabled = true;
            tabExportError.Text = "";

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
                tabGenTextRoomCountMin.Text = presets[presetIndex, 8].ToString();
                tabGenTextRoomCountMax.Text = presets[presetIndex, 9].ToString();
            }
        }

        private void tabSettingButtonConfigExport_Click(object sender, EventArgs e)
        {
            string settingsString = settingsStartColor + ";" + settingsEndColor + ";" + settingsTrapColor + ";" +
                settingsTreasureColor + ";" + settingsFloorColor + ";" + settingsWallColor + ";" +
                dungeonHeight + ";" + dungeonWidth + ";" + dungeonTrapPercent + ";" + dungeonTreasurePercent + ";" +
                dungeonMinRoomSizeWidth + ";" + dungeonMaxRoomSizeWidth + ";" + dungeonMinRoomSizeHeight + ";" + dungeonMaxRoomSizeHeight + ";" +
                dungeonMinRoomCount + ";" + dungeonMaxRoomCount + ";" + exportFileName;

            tabSettingTextConfigExpImp.Text = settingsString;
        }

        private void tabSettingButtonConfigImport_Click(object sender, EventArgs e)
        {
            string[] settings = tabSettingTextConfigExpImp.Text.Split(';');

            if (settings.Length != 17)
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
                dungeonMinRoomCount = int.Parse(settings[14]);
                dungeonMaxRoomCount = int.Parse(settings[15]);

                exportFileName = settings[16];

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
                tabGenTextRoomCountMin.Text = dungeonMinRoomCount.ToString();
                tabGenTextRoomCountMax.Text = dungeonMaxRoomCount.ToString();

                tabExportTextFileName.Text = exportFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Importieren: " + ex.Message);
            }
        }

        /*
         * ===================================
         *              Hilfsmethoden
         * ===================================
         */



        private bool validateUserInterface()
        {
            List<string> errors = new List<string>();

            if (tabGenDropPreset.SelectedIndex == 5)
            {
                dungeonHeight = presets[tabGenDropPreset.SelectedIndex, 0];
                dungeonWidth = presets[tabGenDropPreset.SelectedIndex, 1];
                dungeonTrapPercent = presets[tabGenDropPreset.SelectedIndex, 2];
                dungeonTreasurePercent = presets[tabGenDropPreset.SelectedIndex, 3];

                dungeonMinRoomSizeWidth = presets[tabGenDropPreset.SelectedIndex, 4];
                dungeonMaxRoomSizeWidth = presets[tabGenDropPreset.SelectedIndex, 5];
                dungeonMinRoomSizeHeight = presets[tabGenDropPreset.SelectedIndex, 6];
                dungeonMaxRoomSizeHeight = presets[tabGenDropPreset.SelectedIndex, 7];
                dungeonMinRoomCount = presets[tabGenDropPreset.SelectedIndex, 8];
                dungeonMaxRoomCount = presets[tabGenDropPreset.SelectedIndex, 9];
            }
            else
            {
                ValidateInt(tabGenTextHeight, 10, 40, "Die Höhe des Dungeons", errors, out dungeonHeight);
                ValidateInt(tabGenTextWidth, 10, 40, "Die Breite des Dungeons", errors, out dungeonWidth);

                ValidateInt(tabGenTextTrapPercent, 0, 100, "Falle Prozent", errors, out dungeonTrapPercent);
                ValidateInt(tabGenTextTreasurePercent, 0, 100, "Truhe Prozent", errors, out dungeonTreasurePercent);

                if (dungeonTrapPercent + dungeonTreasurePercent > 100)
                {
                    errors.Add("Die Summe von Falle Prozent und Truhe Prozent darf nicht über 100 sein!");
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

                ValidateInt(tabGenTextRoomCountMin, 1, 20, "Minimale Raumanzahl", errors, out dungeonMinRoomCount);
                ValidateInt(tabGenTextRoomCountMax, 1, 20, "Maximale Raumanzahl", errors, out dungeonMaxRoomCount);

                if (dungeonMinRoomCount > dungeonMaxRoomCount)
                {
                    errors.Add("Mindest Raumanzahl darf nicht größer sein als das Maximum!");
                }
            }

            if (!String.IsNullOrWhiteSpace(tabGenTextSeed.Text))
            {
                ValidateInt(tabGenTextSeed, 1, 1000000, "Seed", errors, out _);
            }

            ValidateDropdown(tabSettingDropStart, "Startfarbe", errors, out settingsStartColor);
            ValidateDropdown(tabSettingDropEnd, "Endfarbe", errors, out settingsEndColor);
            ValidateDropdown(tabSettingDropTrap, "Fallenfarbe", errors, out settingsTrapColor);
            ValidateDropdown(tabSettingDropTreasure, "Truhenfarbe", errors, out settingsTreasureColor);
            ValidateDropdown(tabSettingDropFloor, "Bodenfarbe", errors, out settingsFloorColor);
            ValidateDropdown(tabSettingDropWalls, "Wandfarbe", errors, out settingsWallColor);

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

        private void SendDungeonStatistic()
        {
            int charsCount = dungeonHeight * dungeonWidth;
            int wallCount = finishedDungeon.Count(c => c == '#');
            int floorCount = finishedDungeon.Count(c => c == '.');

            double endTrapPercent = Math.Round((double)finishedTrapCount / charsCount * 100, 2);
            double endTreasurePercent = Math.Round((double)finishedTreasureCount / charsCount * 100, 2);

            string statsString =
                "===== Dungeon Statistik =====\r\n\r\n" +

                $"{"Seed:",-20}{dungeonSeed}\r\n" +
                $"{"Größe:",-20}{dungeonWidth} x {dungeonHeight}\r\n" +
                $"{"Fallen:",-20}{dungeonTrapPercent}%\r\n" +
                $"{"Schätze:",-20}{dungeonTreasurePercent}%\r\n" +
                $"{"Raumanzahl:",-20}{finishedRoomCount}\r\n" +
                $"{"Raumbreite:",-20}{dungeonMinRoomSizeWidth} bis {dungeonMaxRoomSizeWidth}\r\n" +
                $"{"Raumhöhe:",-20}{dungeonMinRoomSizeHeight} bis {dungeonMaxRoomSizeHeight}\r\n" +
                "\r\n" +
                $"{"Insgesamt:",-20}{charsCount}\r\n" +
                $"{"Boden:",-20}{floorCount}\r\n" +
                $"{"Wände:",-20}{wallCount}\r\n" +
                $"{"Fallen:",-20}{finishedTrapCount} {endTrapPercent}%\r\n" +
                $"{"Schätze:",-20}{finishedTreasureCount} {endTreasurePercent}%\r\n" +
                "\r\n========== Legende ==========\r\n\r\n";

            statsAnzeige.Clear();
            statsAnzeige.AppendText("\n\n" + statsString);

            AppendColoredText(statsAnzeige, "S ", GetColorFromIndex(settingsStartColor));
            statsAnzeige.AppendText("Startpunkt\n");

            AppendColoredText(statsAnzeige, "E ", GetColorFromIndex(settingsEndColor));
            statsAnzeige.AppendText("Endpunkt\n");

            AppendColoredText(statsAnzeige, ". ", GetColorFromIndex(settingsFloorColor));
            statsAnzeige.AppendText("Freier Weg\n");

            AppendColoredText(statsAnzeige, "# ", GetColorFromIndex(settingsWallColor));
            statsAnzeige.AppendText("Wand\n");

            AppendColoredText(statsAnzeige, "T ", GetColorFromIndex(settingsTreasureColor));
            statsAnzeige.AppendText("Schatztruhe\n");

            AppendColoredText(statsAnzeige, "F ", GetColorFromIndex(settingsTrapColor));
            statsAnzeige.AppendText("Falle\n");
        }

        private Color GetColorFromIndex(int index)
        {
            Color color = Color.Gray;

            switch (index)
            {
                case 0:
                    color = Color.Red;

                    break;
                case 1:
                    color = Color.Green;

                    break;
                case 2:
                    color = Color.Blue;

                    break;
                case 3:
                    color = Color.Yellow;

                    break;
                case 4:
                    color = Color.Cyan;

                    break;
                case 5:
                    color = Color.Magenta;

                    break;
                case 6:
                    color = Color.White;

                    break;
                default:
                    break;
            }

            return color;
        }

        private Color GetTileColor(char tile)
        {
            switch (tile)
            {
                case 'S':
                    return GetColorFromIndex(settingsStartColor);

                case 'E':
                    return GetColorFromIndex(settingsEndColor);

                case '.':
                    return GetColorFromIndex(settingsFloorColor);

                case '#':
                    return GetColorFromIndex(settingsWallColor);

                case 'T':
                    return GetColorFromIndex(settingsTreasureColor);

                case 'F':
                    return GetColorFromIndex(settingsTrapColor);

                default:
                    return Color.White;
            }
        }

        private void AppendColoredText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;

            box.AppendText(text);

            box.SelectionColor = box.ForeColor;
        }


        /*
         * ===================================
         *              Dungeon Generierung
         * ===================================
         */



        private void generateDungeon()
        {

            // Array Initialiesieren
            map = new char[dungeonWidth, dungeonHeight];

            // Methoden aufrufen zum generieren des Dungeons
            int[] startCoords = generateStart();

            int roomCount = random.Next(dungeonMinRoomCount, dungeonMaxRoomCount + 1);
            finishedRoomCount = roomCount;
            generateRandomRooms(roomCount);

            generateMaze(startCoords[0], startCoords[1]);
            generateEnd(startCoords[0], startCoords[1]);
            generateObjects();


            // Restlichen Wände hinzufügen
            // Zwei for Schleifen um ein Koordinatensystem zu simulieren
            for (int y = 0; y < dungeonHeight; y++)
            {
                for (int x = 0; x < dungeonWidth; x++)
                {

                    // Setzt den Rand
                    if (y == 0 || y == dungeonHeight - 1 || x == 0 || x == dungeonWidth - 1)
                    {
                        map[x, y] = '#';
                        continue;
                    }
                    // Überspringt die Koordinate wenn sie schon besetzt ist
                    if (map[x, y] != '\0')
                    {
                        continue;
                    }
                    // Füllt jede freie Koordinate mit einer Wand
                    map[x, y] = '#';

                }
            }
        }


        /* 
        * generateStart()
        * Wählt eine zufällige Startposition für den Dungeon und markiert sie mit S.
        * Gibt die Koordinaten x y zurück.
        */
        private int[] generateStart()
        {

            int startWidth = random.Next(1, dungeonWidth - 1);      // Erstellt eine Random Zahl zwischen 1 und der Dungeon Breite -1
            int startHeight = random.Next(1, dungeonHeight - 1);    // Erstellt eine Random Zahl zwischen 1 und der Dungeon Höhe -1
            map[startWidth, startHeight] = 'S';                     // Speichert diese Zahlen dann im Koordinatensystem und speichert S bei diesen Koordinaten 

            return new int[] { startWidth, startHeight };

        }


        /* 
        * generateRandomRooms(int roomCount)
        * Erstellt eine bestimmte Anzahl rechteckiger Räume im Dungeon.
        *  - Räume werden zufällig positioniert
        *  - Größe zwischen 3x3 und 6x6
        *  - Räume überschreiben nur leere Felder
        *  - Räume werden mit . markiert
        */
        private void generateRandomRooms(int roomCount)
        {

            for (int i = 0; i < roomCount; i++)
            {
                // Erstellt Random Zahlen zwischen 3 und 6 für die obere und Linke Wand des Raums
                int roomWidth = random.Next(dungeonMinRoomSizeWidth, dungeonMaxRoomSizeWidth);
                int roomHeight = random.Next(dungeonMinRoomSizeHeight, dungeonMaxRoomSizeHeight);

                // Erstellt eine Random Koordinate wo der Raum spawnt
                int roomX = random.Next(1, dungeonWidth - roomWidth - 1);
                int roomY = random.Next(1, dungeonHeight - roomHeight - 1);

                for (int y = roomY; y < roomY + roomHeight; y++)
                {
                    for (int x = roomX; x < roomX + roomWidth; x++)
                    {
                        // Überprüft ob die Koordinate schon besetzt ist
                        if (map[x, y] != '\0')
                        {
                            continue;
                        }
                        map[x, y] = '.';
                    }
                }
            }

        }


        /* 
        * generateMaze(int startX, int startY)
        * Erstellt ein Labyrinth ab einer Startposition.
        *  - Bewegt sich nur in vertikal/horizontal (keine Diagonalen)
        *  - Markiert den Pfad mit .
        */
        private void generateMaze(int startX, int startY)
        {
            Stack<(int x, int y)> stack = new Stack<(int, int)>();
            stack.Push((startX, startY));

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int x = current.x;
                int y = current.y;

                int[,] directions =
                {
                    {0,-2},
                    {2,0},
                    {0,2},
                    {-2,0}
                };

                for (int i = 3; i > 0; i--)
                {
                    int j = random.Next(i + 1);

                    int tempX = directions[i, 0];
                    int tempY = directions[i, 1];

                    directions[i, 0] = directions[j, 0];
                    directions[i, 1] = directions[j, 1];

                    directions[j, 0] = tempX;
                    directions[j, 1] = tempY;
                }

                for (int i = 0; i < 4; i++)
                {
                    int targetX = x + directions[i, 0];
                    int targetY = y + directions[i, 1];

                    if (targetX < 1 || targetX > dungeonWidth - 2 || targetY < 1 || targetY > dungeonHeight - 2)
                        continue;

                    if (map[targetX, targetY] == '\0')
                    {
                        int betweenX = x + directions[i, 0] / 2;
                        int betweenY = y + directions[i, 1] / 2;

                        map[betweenX, betweenY] = '.';
                        map[targetX, targetY] = '.';

                        stack.Push((targetX, targetY));
                    }
                }
            }
        }


        /* 
        * generateEnd(int startX, int startY)
        * Wählt eine zufällige Endposition für den Dungeon und markiert sie mit E.
        * - Endpunkt wird nur gewählt wenn er mindestens minDistance Felder vom Start entfernt ist
        * - Gibt die Koordinaten x y zurück
        */
        private int[] generateEnd(int startX, int startY)
        {

            // Variablen Deklarieren
            int endX;
            int endY;
            int distance;
            int minDistance = 7; // Mindestabstand zwischen Start und Ende

            // Überprüft ob der Abstand zwischen Start und Ende minDistance beträgt
            do
            {
                // Erstellt Random Koordinaten für das Ende
                endX = random.Next(1, dungeonWidth - 1);
                endY = random.Next(1, dungeonHeight - 1);

                // Rechnet den Abstand zwischen Start und Ende aus
                distance = Math.Abs(endX - startX) + Math.Abs(endY - startY);

            } while (map[endX, endY] != '.' || distance < minDistance);

            map[endX, endY] = 'E';      // Speichert diese Zahlen dann im Koordinatensystem und speichert S bei diesen Koordinaten

            return new int[] { endX, endY };

        }


        /* 
        * generateObjects()
        * Verteilt zufällig Schatzkisten T und Fallen F im Dungeon.
        *  - Nur auf freien Feldern
        */
        private void generateObjects()
        {
            for (int y = 0; y < dungeonHeight; y++)
            {
                for (int x = 0; x < dungeonWidth; x++)
                {
                    // Nur auf freien Wegen platzieren
                    if (map[x, y] != '.')
                        continue;

                    int roll = random.Next(1, 100);

                    if (roll <= dungeonTrapPercent)
                    {
                        map[x, y] = 'F'; // Falle
                        finishedTrapCount++;
                    }
                    else if (roll <= dungeonTrapPercent + dungeonTreasurePercent)
                    {
                        map[x, y] = 'T'; // Schatz
                        finishedTreasureCount++;
                    }
                }
            }
        }

        private void tabExportButtonExport_Click(object sender, EventArgs e)
        {
            finishedDungeon = "";

            for (int y = 0; y < dungeonHeight; y++)
            {
                for (int x = 0; x < dungeonWidth; x++)
                {
                    finishedDungeon += map[x, y];
                }

                finishedDungeon += ("\n");
            }

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                exportFileName = exportFileName.Replace(c.ToString(), "\0");
            }

            if (!string.IsNullOrWhiteSpace(tabExportTextFileName.Text))
            {
                exportFileName = tabExportTextFileName.Text;
            }

            foreach (char c in Path.GetInvalidPathChars())
            {
                exportFilePath = exportFilePath.Replace(c.ToString(), "\0");
            }

            if (!string.IsNullOrWhiteSpace(tabExportTextFilePath.Text))
            {
                exportFilePath = tabExportTextFilePath.Text;
            }


            if (Directory.Exists(exportFilePath))
            {
                File.WriteAllText(Path.Combine(exportFilePath, exportFileName + ".txt"), finishedDungeon);
                MessageBox.Show("Dungeon wurde erfolgreich in '" + exportFilePath + "' mit dem Namen '" + exportFileName + "' gespeichert.");
            }
            else
            {
                exportFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllText(Path.Combine(exportFilePath, "Dungeon.txt"), finishedDungeon);
                MessageBox.Show("Ein Fehler ist beim Speichern der Datei aufgetreten.\n" +
                    $"Es wurde mit dem Namen 'Dungeon' unter dem Pfad '" + exportFilePath + "' gespeichert.");
            }

        }
    }
}