using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace NeurometerGame
{
    public partial class GameWindow : Form
    {
        private int width_way = 25;

        private Random random = new Random();

        private Color[,] color_palettes = new Color[2, 6]
        {
            {
                Color.White, Color.LightSkyBlue, Color.FromArgb(5, 142, 230), Color.FromArgb(5, 136, 220),
                Color.FromArgb(5, 130, 210), Color.FromArgb(5, 118, 190)
            },
            {
                Color.White, Color.FromArgb(172, 246, 180), Color.FromArgb(21, 188, 41), Color.FromArgb(20, 179, 39),
                Color.FromArgb(19, 170, 37), Color.FromArgb(17, 152, 33)
            }
        };

        private Color[] color_palette = new Color[6]
        {
            Color.White, Color.LightSkyBlue, Color.FromArgb(5, 142, 230), Color.FromArgb(5, 136, 220),
            Color.FromArgb(5, 130, 210), Color.FromArgb(5, 118, 190)
        };

        private bool game_started = false;

        private void CreateNeurometer()
        {
            List<Point> buttons_location = new List<Point>()
                { new Point(20, 20), new Point(820, 20), new Point(20, 430), new Point(820, 430) };

            int number_of_way = 0;
            Point[] first_way_location = new[]
            {
                new Point(buttons_location[0].X + startButton.Width - width_way,
                    random.Next(0, startButton.Height - width_way) + buttons_location[0].Y),
                new Point(buttons_location[1].X,
                    random.Next(0, startButton.Height - width_way) + buttons_location[1].Y),
                new Point(buttons_location[2].X + startButton.Width - width_way,
                    random.Next(0, startButton.Height - width_way) + buttons_location[2].Y),
                new Point(buttons_location[3].X, random.Next(0, startButton.Height - width_way) + buttons_location[2].Y)
            };
            if (random.NextDouble() > 0.5)
            {
                number_of_way = 1;
                first_way_location = new[]
                {
                    new Point(
                        random.Next(0, startButton.Width - width_way) + buttons_location[0].X,
                        buttons_location[0].Y + startButton.Height - width_way),
                    new Point(
                        random.Next(0, startButton.Width - width_way) + buttons_location[1].X,
                        buttons_location[1].Y + startButton.Height - width_way),
                    new Point(random.Next(0, startButton.Width - width_way) + buttons_location[2].X,
                        buttons_location[2].Y),
                    new Point(random.Next(0, startButton.Width - width_way) + buttons_location[3].X,
                        buttons_location[3].Y)
                };
            }

            int index_startButton_location = random.Next(buttons_location.Count), maximum_way_size;
            startButton.Location = buttons_location[index_startButton_location];
            buttons_location.RemoveAt(index_startButton_location);
            endButton.Location = buttons_location[random.Next(buttons_location.Count)];

            Point next_way_location = first_way_location[index_startButton_location],
                last_way_location = next_way_location;

            PictureBox way;

            PictureBox CreateWay(int type)
            {
                way = new PictureBox();
                way.BackColor = color_palette[2];
                way.Name = number_of_way.ToString();
                switch (type)
                {
                    case 1:
                        maximum_way_size = gamePanel.Width / 3 - gamePanel.Width % 3; // 940 / 3 = 113 
                        if (maximum_way_size + last_way_location.X > gamePanel.Width - endButton.Width - 20)
                        {
                            maximum_way_size = gamePanel.Width - last_way_location.X - 30;
                            if (maximum_way_size <= width_way + 10)
                                way.Size = new Size(maximum_way_size, width_way);
                            else
                                way.Size = new Size(random.Next(width_way + 10, maximum_way_size), width_way);
                        }
                        else
                        {
                            way.Size = new Size(random.Next(width_way + 10, maximum_way_size), width_way);
                        }

                        next_way_location.X += width_way;
                        way.Location = next_way_location;
                        next_way_location.X += way.Width - width_way;
                        last_way_location.X = way.Location.X + way.Width;
                        break;
                    case 2:
                        maximum_way_size = gamePanel.Width / 3 - gamePanel.Width % 3; // 940 / 3 = 113 
                        if (last_way_location.X - maximum_way_size < 0 + endButton.Width + 20)
                        {
                            maximum_way_size = last_way_location.X - 30;
                            if (maximum_way_size <= width_way + 10)
                                way.Size = new Size(maximum_way_size, width_way);
                            else
                                way.Size = new Size(random.Next(width_way + 10, maximum_way_size), width_way);
                        }
                        else
                        {
                            way.Size = new Size(random.Next(width_way + 10, maximum_way_size), width_way);
                        }

                        //next_way_location.X += width_way;
                        next_way_location.X -= way.Width;
                        way.Location = next_way_location;
                        //next_way_location.X += way.Width - width_way;
                        last_way_location.X = way.Location.X;
                        break;
                    case 3:
                        maximum_way_size = gamePanel.Height / 3 - gamePanel.Height % 3; // 550 / 3 = 183 
                        if (maximum_way_size + last_way_location.Y > gamePanel.Height - endButton.Height - 20)
                        {
                            maximum_way_size = gamePanel.Height - last_way_location.Y - 30;
                            if (maximum_way_size <= width_way + 10)
                                way.Size = new Size(width_way, maximum_way_size);
                            else
                                way.Size = new Size(width_way, random.Next(width_way + 10, maximum_way_size));
                        }
                        else
                        {
                            way.Size = new Size(width_way, random.Next(width_way + 10, maximum_way_size));
                        }

                        next_way_location.Y += width_way;
                        way.Location = next_way_location;
                        next_way_location.Y += way.Height - width_way;
                        last_way_location.Y = way.Location.Y + way.Height;
                        break;
                    case 4:
                        maximum_way_size = gamePanel.Height / 3 - gamePanel.Height % 3; // 550 / 3 = 183 
                        if (last_way_location.Y - maximum_way_size < 0 + endButton.Height + 20)
                        {
                            maximum_way_size = last_way_location.Y - 30;
                            if (maximum_way_size <= width_way + 10)
                                way.Size = new Size(width_way, maximum_way_size);
                            else
                                way.Size = new Size(width_way, random.Next(width_way + 10, maximum_way_size));
                        }
                        else
                        {
                            way.Size = new Size(width_way, random.Next(width_way + 10, maximum_way_size));
                        }

                        next_way_location.Y -= way.Height;
                        way.Location = next_way_location;
                        last_way_location.Y = way.Location.Y;
                        break;
                }

                return way;
            }

            PictureBox CreateFinalWay(int type)
            {
                way = new PictureBox();
                way.BackColor = color_palette[2];
                way.Name = number_of_way.ToString();
                switch (type)
                {
                    case 1:
                        way.Size = new Size(endButton.Location.X - last_way_location.X, width_way);
                        next_way_location.X += width_way;
                        way.Location = next_way_location;
                        break;
                    case 2:
                        way.Size = new Size(last_way_location.X - endButton.Location.X, width_way);
                        next_way_location.X = endButton.Location.X;
                        way.Location = next_way_location;
                        break;
                    case 3:
                        way.Size = new Size(width_way, endButton.Location.Y - last_way_location.Y);
                        next_way_location.Y = last_way_location.Y;
                        way.Location = next_way_location;
                        break;
                    case 4:
                        way.Size = new Size(width_way, last_way_location.Y - endButton.Location.Y);
                        next_way_location.Y = endButton.Location.Y;
                        way.Location = next_way_location;
                        break;
                }

                return way;
            }

            if (startButton.Location.X == 20)
            {
                if (startButton.Location.Y == 20)
                {
                    while (true)
                    {
                        if (number_of_way % 2 == 0)
                        {
                            number_of_way++;
                            gamePanel.Controls.Add(CreateWay(1));
                        }
                        else
                        {
                            number_of_way++;
                            gamePanel.Controls.Add(CreateWay(3));
                        }

                        if (number_of_way > 3 &&
                            (last_way_location.X - width_way > endButton.Location.X &&
                             last_way_location.X < endButton.Location.X + endButton.Width))
                        {
                            switch (endButton.Location.Y)
                            {
                                case 20:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(4));
                                    break;
                                case 430:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(3));
                                    break;
                            }

                            break;
                        }

                        if (number_of_way > 3 &&
                            (last_way_location.Y > endButton.Location.Y + width_way && last_way_location.Y <
                                endButton.Location.Y + endButton.Height))
                        {
                            switch (endButton.Location.X)
                            {
                                case 20:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(2));
                                    break;
                                case 820:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(1));
                                    break;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    while (true)
                    {
                        if (number_of_way % 2 == 0)
                        {
                            number_of_way++;
                            gamePanel.Controls.Add(CreateWay(1));
                        }
                        else
                        {
                            number_of_way++;
                            gamePanel.Controls.Add(CreateWay(4));
                        }

                        if (number_of_way > 3 &&
                            (last_way_location.X - width_way > endButton.Location.X &&
                             last_way_location.X < endButton.Location.X + endButton.Width))
                        {
                            switch (endButton.Location.Y)
                            {
                                case 20:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(4));
                                    break;
                                case 430:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(3));
                                    break;
                            }

                            break;
                        }

                        if (number_of_way > 3 &&
                            (last_way_location.Y > endButton.Location.Y && last_way_location.Y <
                                endButton.Location.Y + endButton.Height - width_way))
                        {
                            switch (endButton.Location.X)
                            {
                                case 20:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(2));
                                    break;
                                case 820:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(1));
                                    break;
                            }

                            break;
                        }
                    }
                }
            }
            else
            {
                if (startButton.Location.Y == 20)
                {
                    while (true)
                    {
                        if (number_of_way % 2 == 0)
                        {
                            number_of_way++;
                            gamePanel.Controls.Add(CreateWay(2));
                        }
                        else
                        {
                            number_of_way++;
                            gamePanel.Controls.Add(CreateWay(3));
                        }

                        if (number_of_way > 3 &&
                            (last_way_location.X > endButton.Location.X &&
                             last_way_location.X < endButton.Location.X + endButton.Width - width_way))
                        {
                            switch (endButton.Location.Y)
                            {
                                case 20:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(4));
                                    break;
                                case 430:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(3));
                                    break;
                            }

                            break;
                        }

                        if (number_of_way > 3 &&
                            (last_way_location.Y > endButton.Location.Y + width_way && last_way_location.Y <
                                endButton.Location.Y + endButton.Height))
                        {
                            switch (endButton.Location.X)
                            {
                                case 20:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(2));
                                    break;
                                case 820:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(1));
                                    break;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    while (true)
                    {
                        if (number_of_way % 2 == 0)
                        {
                            number_of_way++;
                            gamePanel.Controls.Add(CreateWay(2));
                        }
                        else
                        {
                            number_of_way++;
                            gamePanel.Controls.Add(CreateWay(4));
                        }

                        if (number_of_way > 3 &&
                            (last_way_location.X > endButton.Location.X &&
                             last_way_location.X < endButton.Location.X + endButton.Width - width_way))
                        {
                            switch (endButton.Location.Y)
                            {
                                case 20:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(4));
                                    break;
                                case 430:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(3));
                                    break;
                            }

                            break;
                        }

                        if (number_of_way > 3 &&
                            (last_way_location.Y > endButton.Location.Y && last_way_location.Y <
                                endButton.Location.Y + endButton.Height - width_way))
                        {
                            switch (endButton.Location.X)
                            {
                                case 20:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(2));
                                    break;
                                case 820:
                                    number_of_way++;
                                    gamePanel.Controls.Add(CreateFinalWay(1));
                                    break;
                            }

                            break;
                        }
                    }
                }
            }
        }

        private void ApplyColor()
        {
            this.BackColor = color_palette[0];
            gamePanel.BackColor = color_palette[1];
            timerPanel.BackColor = color_palette[1];
            timerPanel.ForeColor = color_palette[5];
            resetPanel.BackColor = color_palette[2];

            startButton.BackColor = color_palette[2];
            startButton.ForeColor = color_palette[0];
            startButton.FlatAppearance.MouseOverBackColor = color_palette[3];
            startButton.FlatAppearance.MouseDownBackColor = color_palette[4];
            startButton.FlatAppearance.BorderColor = color_palette[0];

            endButton.BackColor = color_palette[0];
            endButton.ForeColor = color_palette[2];
            endButton.FlatAppearance.MouseOverBackColor = color_palette[0];
            endButton.FlatAppearance.MouseDownBackColor = color_palette[0];
            endButton.FlatAppearance.BorderColor = color_palette[2];

            foreach (PictureBox i in gamePanel.Controls.OfType<PictureBox>().ToList())
            {
                i.BackColor = color_palette[2];
            }

            menu.BackColor = color_palette[1];
            foreach (ToolStripMenuItem i in menu.Items)
            {
                i.BackColor = color_palette[1];
                i.ForeColor = color_palette[5];
                foreach (ToolStripMenuItem j in i.DropDownItems)
                {
                    j.BackColor = color_palette[0];
                    j.ForeColor = color_palette[5];
                    foreach (ToolStripMenuItem k in j.DropDownItems)
                    {
                        k.BackColor = color_palette[0];
                        k.ForeColor = color_palette[5];
                    }
                }
            }
        }

        public GameWindow()
        {
            InitializeComponent();

            CreateNeurometer();

            ApplyColor();

            //Convert "." to game default decimal symbol for timer.
            var current = System.Threading.Thread.CurrentThread.CurrentCulture;
            var culture = System.Globalization.CultureInfo.CreateSpecificCulture(current.Name);
            culture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            game_started = true;
            second.Text = "0.0";
            minutes.Text = "00";
            timer.Enabled = true;
            startButton.Cursor = Cursors.Default;
        }

        private void gamePanel_MouseEnter(object sender, EventArgs e)
        {
            if (game_started)
            {
                timer.Enabled = false;
                game_started = false;
                MessageBox.Show("You went out of the way and lost!", "Game over!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                second.Text = "0.0";
                minutes.Text = "00";
                startButton.Cursor = Cursors.Hand;
            }
        }

        private void endButton_MouseEnter(object sender, EventArgs e)
        {
            if (game_started)
            {
                game_started = false;
                timer.Enabled = false;
                MessageBox.Show("You reached the end and won!", "Game over!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                startButton.Cursor = Cursors.Hand;
            }
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            second.Text = (Math.Round(float.Parse(second.Text) + 0.01, 2)).ToString();
            if (float.Parse(second.Text) == 60.00)
            {
                second.Text = "0.0";
                minutes.Text = (int.Parse(minutes.Text) + 1).ToString();
            }
        }

        private void reset_MouseEnter(object sender, EventArgs e)
        {
            resetPanel.BackColor = color_palette[3];
        }

        private void reset_MouseLeave(object sender, EventArgs e)
        {
            resetPanel.BackColor = color_palette[2];
        }

        private void reset_MouseDown(object sender, MouseEventArgs e)
        {
            resetPanel.BackColor = color_palette[4];
            second.Text = "0.0";
            minutes.Text = "00";
        }

        private void reset_MouseUp(object sender, MouseEventArgs e)
        {
            resetPanel.BackColor = color_palette[2];

            foreach (PictureBox i in gamePanel.Controls.OfType<PictureBox>().ToList())
            {
                gamePanel.Controls.Remove(i);
            }

            CreateNeurometer();
        }

        private void Colors_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem color = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem i in menuOptionsColor.DropDownItems)
            {
                i.Checked = false;
            }

            color.Checked = true;
            for (int i = 0; i < color_palette.Length; i++)
            {
                color_palette[i] = color_palettes[int.Parse(color.Name.Replace("menuOptionsColor", "")), i];
            }

            ApplyColor();
        }

        private void menuGameSave_Click(object sender, EventArgs e)
        {
            saveGame.DefaultExt = ".neurometer";

            if (saveGame.ShowDialog() == DialogResult.OK)
            {
                StreamWriter game_file = new StreamWriter(new FileStream(saveGame.FileName, FileMode.Create));
                game_file.Write(startButton.Location.X + "," + startButton.Location.Y + "\n");
                game_file.Write(endButton.Location.X + "," + endButton.Location.Y + "\n");
                foreach (PictureBox i in gamePanel.Controls.OfType<PictureBox>().ToList())
                {
                    game_file.Write(i.Location.X + "," + i.Location.Y + "," + i.Width + "," + i.Height + "\n");
                }

                game_file.Close();
            }
        }

        private void menuGameImport_Click(object sender, EventArgs e)
        {
            openGame.DefaultExt = ".neurometer";
            if (openGame.ShowDialog() == DialogResult.OK)
            {
                StreamReader game_file = new StreamReader(openGame.OpenFile());
                foreach (PictureBox i in gamePanel.Controls.OfType<PictureBox>().ToList())
                {
                    gamePanel.Controls.Remove(i);
                }

                List<string> lines = game_file.ReadToEnd().Split('\n').ToList(), line;
                
                line = lines[0].Split(',').ToList();
                Point p = new Point(int.Parse(line[0]), int.Parse(line[1]));
                startButton.Location = p;
                
                line = lines[1].Split(',').ToList();
                p = new Point(int.Parse(line[0]), int.Parse(line[1]));
                endButton.Location = p;

                PictureBox way;
                for (int i = 2; i < lines.Count - 1; i++)
                {
                    line = lines[i].Split(',').ToList();
                    p = new Point(int.Parse(line[0]), int.Parse(line[1]));
                    
                    way = new PictureBox();
                    gamePanel.Controls.Add(way);
                    way.BackColor = color_palette[2];
                    way.Name = (i - 1).ToString();
                    way.Location = p;
                    way.Width = int.Parse(line[2]);
                    way.Height = int.Parse(line[3]);
                }
            }
        }
    }
}