﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace NeurometerGame
{
    public partial class GameWindow : Form
    {
        private int width_way = 25;

        private Random random = new Random();

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
                way.BackColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(230)))));
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
                way.BackColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(230)))));
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

        public GameWindow()
        {
            InitializeComponent();
            CreateNeurometer();

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
            resetPanel.BackColor = Color.FromArgb(5, 136, 220);
        }

        private void reset_MouseLeave(object sender, EventArgs e)
        {
            resetPanel.BackColor = Color.FromArgb(5, 142, 230);
        }

        private void reset_MouseDown(object sender, MouseEventArgs e)
        {
            resetPanel.BackColor = Color.FromArgb(5, 130, 210);
            second.Text = "0.0";
            minutes.Text = "00";
        }

        private void reset_MouseUp(object sender, MouseEventArgs e)
        {
            resetPanel.BackColor = Color.FromArgb(5, 142, 230);

            foreach (PictureBox i in gamePanel.Controls.OfType<PictureBox>().ToList())
            {
                gamePanel.Controls.Remove(i);
            }

            CreateNeurometer();
        }
    }
}