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

namespace NeurometerGame
{
    public partial class GameWindow : Form
    {
        List<Point> buttons_location = new List<Point>()
            { new Point(20, 20), new Point(820, 20), new Point(20, 430), new Point(820, 430) };

        private Point next_way_location;

        private int index_startButton_location, width_way = 25, XX, YY;

        private Random random = new Random();

        public GameWindow()
        {
            InitializeComponent();

            List<Point> first_way_location = new List<Point>()
            {
                new Point(buttons_location[0].X + startButton.Width - width_way,
                    (startButton.Height / 2 - width_way / 2) + buttons_location[0].Y),
                new Point(buttons_location[1].X, (startButton.Height / 2 - width_way / 2) + buttons_location[1].Y),
                new Point(buttons_location[2].X + startButton.Width - width_way,
                    (startButton.Height / 2 - width_way / 2) + buttons_location[2].Y),
                new Point(buttons_location[3].X, (startButton.Height / 2 - width_way / 2) + buttons_location[2].Y)
            };

            // index_startButton_location = random.Next(buttons_location.Count);
            // startButton.Location = buttons_location[index_startButton_location];
            // buttons_location.RemoveAt(index_startButton_location);
            // endButton.Location = buttons_location[random.Next(buttons_location.Count)];
            //
            // next_way_location = first_way_location[index_startButton_location];

            index_startButton_location = 2;
            startButton.Location = buttons_location[index_startButton_location];
            //buttons_location.RemoveAt(index_startButton_location);
            endButton.Location = buttons_location[1];

            next_way_location = first_way_location[index_startButton_location];
            XX = next_way_location.X;
            YY = next_way_location.Y;


            int number_of_way = 0, a;
            PictureBox way;
            if (startButton.Location.X == 20)
            {
                if (startButton.Location.Y == 20)
                {
                    while (true)
                    {
                        if (number_of_way % 2 == 0)
                        {
                            number_of_way++;

                            way = new PictureBox();
                            way.BackColor = Color.Red;
                            way.Name = number_of_way.ToString();
                            a = 300;
                            if (a + XX > gamePanel.Width - endButton.Width - 20)
                                a = gamePanel.Width - XX - 30;
                            way.Size = new Size(random.Next(width_way + 10, a), width_way);
                            next_way_location.X += width_way;
                            way.Location = next_way_location;
                            next_way_location.X += way.Width - width_way;
                            XX = way.Location.X + way.Width;
                            gamePanel.Controls.Add(way);
                        }
                        else
                        {
                            number_of_way++;

                            way = new PictureBox();
                            way.BackColor = Color.Green;
                            way.Name = number_of_way.ToString();
                            a = 200;
                            if (a + YY > gamePanel.Height - endButton.Height - 20)
                                a = gamePanel.Height - YY - 30;
                            way.Size = new Size(width_way, random.Next(width_way + 10, a));
                            next_way_location.Y += width_way;
                            way.Location = next_way_location;
                            next_way_location.Y += way.Height - width_way;
                            YY = way.Location.Y + way.Height;
                            gamePanel.Controls.Add(way);
                        }

                        if (number_of_way > 2 &&
                            (XX - width_way > endButton.Location.X && XX < endButton.Location.X + endButton.Width))
                        {
                            switch (endButton.Location.Y)
                            {
                                case 20:
                                    way = new PictureBox();
                                    way.BackColor = Color.Blue;
                                    way.Name = number_of_way.ToString();
                                    way.Size = new Size(width_way, YY - endButton.Location.Y);
                                    next_way_location.Y = endButton.Location.Y;
                                    way.Location = next_way_location;
                                    gamePanel.Controls.Add(way);
                                    break;
                                case 430:
                                    way = new PictureBox();
                                    way.BackColor = Color.Blue;
                                    way.Name = number_of_way.ToString();
                                    way.Size = new Size(width_way, endButton.Location.Y - YY);
                                    next_way_location.Y = YY;
                                    way.Location = next_way_location;
                                    gamePanel.Controls.Add(way);
                                    break;
                            }

                            break;
                        }

                        if (number_of_way > 2 &&
                            (YY > endButton.Location.Y && YY < endButton.Location.Y + endButton.Height - width_way))
                        {
                            switch (endButton.Location.X)
                            {
                                case 20:
                                    way = new PictureBox();
                                    way.BackColor = Color.Yellow;
                                    way.Name = number_of_way.ToString();
                                    way.Size = new Size(XX - endButton.Location.X, width_way);
                                    next_way_location.X = endButton.Location.X;
                                    way.Location = next_way_location;
                                    gamePanel.Controls.Add(way);
                                    break;
                                case 820:
                                    way = new PictureBox();
                                    way.BackColor = Color.Yellow;
                                    way.Name = number_of_way.ToString();
                                    way.Size = new Size(endButton.Location.X - XX, width_way);
                                    next_way_location.X += width_way;
                                    way.Location = next_way_location;
                                    gamePanel.Controls.Add(way);
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

                            way = new PictureBox();
                            way.BackColor = Color.Red;
                            way.Name = number_of_way.ToString();
                            a = 300;
                            if (a + XX > gamePanel.Width - endButton.Width - 20)
                                a = gamePanel.Width - XX - 30;
                            way.Size = new Size(random.Next(width_way + 10, a), width_way);
                            next_way_location.X += width_way;
                            way.Location = next_way_location;
                            next_way_location.X += way.Width - width_way;
                            XX = way.Location.X + way.Width;
                            gamePanel.Controls.Add(way);
                        }
                        else
                        {
                            number_of_way++;

                            way = new PictureBox();
                            way.BackColor = Color.Green;
                            way.Name = number_of_way.ToString();
                            a = 200;
                            if (YY - a < 0 + endButton.Height + 20)
                                a = YY - 30;
                            way.Size = new Size(width_way, random.Next(width_way + 10, a));
                            next_way_location.Y -= way.Height;
                            way.Location = next_way_location;
                            //next_way_location.Y += way.Height - width_way;
                            YY = way.Location.Y;
                            gamePanel.Controls.Add(way);
                        }

                        if (number_of_way > 2 &&
                            (XX - width_way > endButton.Location.X && XX < endButton.Location.X + endButton.Width))
                        {
                            switch (endButton.Location.Y)
                            {
                                case 20:
                                    way = new PictureBox();
                                    way.BackColor = Color.Blue;
                                    way.Name = number_of_way.ToString();
                                    way.Size = new Size(width_way, YY - endButton.Location.Y);
                                    next_way_location.Y = endButton.Location.Y;
                                    way.Location = next_way_location;
                                    gamePanel.Controls.Add(way);
                                    break;
                                case 430:
                                    way = new PictureBox();
                                    way.BackColor = Color.Blue;
                                    way.Name = number_of_way.ToString();
                                    way.Size = new Size(width_way, endButton.Location.Y - YY);
                                    next_way_location.Y = YY;
                                    way.Location = next_way_location;
                                    gamePanel.Controls.Add(way);
                                    break;
                            }

                            break;
                        }

                        if (number_of_way > 2 &&
                            (YY > endButton.Location.Y && YY < endButton.Location.Y + endButton.Height - width_way))
                        {
                            switch (endButton.Location.X)
                            {
                                case 20:
                                    way = new PictureBox();
                                    way.BackColor = Color.Yellow;
                                    way.Name = number_of_way.ToString();
                                    way.Size = new Size(XX - endButton.Location.X, width_way);
                                    next_way_location.X = endButton.Location.X;
                                    way.Location = next_way_location;
                                    gamePanel.Controls.Add(way);
                                    break;
                                case 820:
                                    way = new PictureBox();
                                    way.BackColor = Color.Yellow;
                                    way.Name = number_of_way.ToString();
                                    way.Size = new Size(endButton.Location.X - XX, width_way);
                                    next_way_location.X += width_way;
                                    way.Location = next_way_location;
                                    gamePanel.Controls.Add(way);
                                    break;
                            }

                            break;
                        }
                    }
                }
            }
        }
    }
}