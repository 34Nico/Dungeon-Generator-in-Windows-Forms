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

        static char[,] map;

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

            generateDungeon();

            string dungeon = "";

            for (int y = 0; y < dungeonHeight; y++)
            {
                for (int x = 0; x < dungeonWidth; x++)
                {
                    // Gibt die Wände und Gänge aus
                    dungeon += map[x,y];

                }
                dungeon += "\n";
            }

            MessageBox.Show(dungeon);

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


        private void generateDungeon()
        {

            // Array Initialiesieren
            map = new char[dungeonWidth, dungeonHeight];

            // Methoden aufrufen zum generieren des Dungeons
            int[] startCoords = generateStart();

            int roomCount = (dungeonWidth * dungeonHeight) / 150; // 1 Raum pro 150 Felder
            roomCount = Math.Max(0, Math.Min(roomCount, 6)); // mindestens 0  maximal 6
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
                int roomWidth = random.Next(3, 6);
                int roomHeight = random.Next(3, 6);

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
            // 4 mögliche Richtungen
            int[,] directions = new int[,]
            {              // x, y
                { 0, -2 }, // nach oben
                { 2, 0 },  // nach rechts
                { 0, 2 },  // nach unten
                { -2, 0 }  // nach links
            };

            // Direction Array zufällig anordnen
            for (int i = 3; i > 0; i--)
            {
                int j = random.Next(i + 1); // 0 bis i
                                            // Tausche i und j
                int tempX = directions[i, 0];
                int tempY = directions[i, 1];
                directions[i, 0] = directions[j, 0];
                directions[i, 1] = directions[j, 1];
                directions[j, 0] = tempX;
                directions[j, 1] = tempY;
            }

            // Führt den Code vier mal pro Methodenaufruf auf
            for (int i = 0; i < 4; i++)
            {
                // Berechnet wo der nächste Weg hingeht
                int targetX = startX + directions[i, 0];
                int targetY = startY + directions[i, 1];

                // Die nächste Koordinate darf nicht außerhalb des Dungeons sein
                if (targetX < 1 || targetX > dungeonWidth - 2 || targetY < 1 || targetY > dungeonHeight - 2)
                    continue;

                // Wenn die berechnete Koordinate nicht besetzt ist
                if (map[targetX, targetY] == '\0')
                {
                    // Berechnet die Zwischenkoordinate und setzt beide Koordinaten als Weg
                    int zwischenX = startX + directions[i, 0] / 2;
                    int zwischenY = startY + directions[i, 1] / 2;
                    map[zwischenX, zwischenY] = '.';
                    map[targetX, targetY] = '.';

                    // Führt solange aus bis der Weg nicht mehr weitergeführt werden kann
                    generateMaze(targetX, targetY);
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
        *  - Nur auf freien Feldern .
        *  - Wahrscheinlichkeit für Objekte liegt bei 5%
        *  - Für jedes gewählte Feld 50/50 Chance: T oder F
        */
        private void generateObjects()
        {
            for (int y = 0; y < dungeonHeight; y++)
            {
                for (int x = 0; x < dungeonWidth; x++)
                {
                    // Überspringt die Koordinate wenn sie schon belegt ist
                    if (map[x, y] != '.')
                        continue;

                    // Setzt die Chance der Objekte auf 5%
                    if (random.NextDouble() > 0.05)
                        continue;

                    // Entscheidet mit einer 50/50 Chance ob es eine Truhe oder eine Falle sein soll
                    if (random.NextDouble() > 0.5)
                    {
                        map[x, y] = 'T';
                    }
                    else
                    {
                        map[x, y] = 'F';
                    }
                }
            }
        }
    }
}