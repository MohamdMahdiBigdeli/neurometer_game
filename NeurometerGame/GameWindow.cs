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

        private int index_startButton_location, width_way = 20;

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

            index_startButton_location = random.Next(buttons_location.Count);
            startButton.Location = buttons_location[index_startButton_location];
            buttons_location.RemoveAt(index_startButton_location);
            endButton.Location = buttons_location[random.Next(buttons_location.Count)];

            next_way_location = first_way_location[index_startButton_location];

            int i = 1;
            PictureBox way;
            // if (random.NextDouble() == 1)
            // {
            while (i < 5)
            {
                if (i % 2 == 1)
                {
                    if (next_way_location.X > gamePanel.Width / 2)
                    {
                        way = new PictureBox();
                        way.BackColor = Color.Red;
                        way.Name = i.ToString();
                        way.Size = new Size(random.Next(50, gamePanel.Width / 2 - 130), width_way);
                        next_way_location.X -= way.Width;
                        way.Location = next_way_location;
                        gamePanel.Controls.Add(way);
                    }
                    else
                    {
                        way = new PictureBox();
                        way.BackColor = Color.Red;
                        way.Name = i.ToString();
                        way.Size = new Size(random.Next(50, gamePanel.Width / 2 - 130), width_way);
                        next_way_location.X += width_way;
                        way.Location = next_way_location;
                        next_way_location.X += way.Width - width_way;
                        gamePanel.Controls.Add(way);
                    }

                    i++;
                }
                else
                {
                    if (next_way_location.Y > gamePanel.Height / 2)
                    {
                        way = new PictureBox();
                        way.BackColor = Color.Green;
                        way.Name = i.ToString();
                        way.Size = new Size(width_way, random.Next(50, gamePanel.Width / 2));
                        next_way_location.Y -= way.Height;
                        way.Location = next_way_location;
                        gamePanel.Controls.Add(way);
                    }
                    else
                    {
                        way = new PictureBox();
                        way.BackColor = Color.Green;
                        way.Name = i.ToString();
                        way.Size = new Size(width_way, random.Next(50, gamePanel.Width / 2));
                        next_way_location.Y += width_way;
                        way.Location = next_way_location;
                        next_way_location.Y += way.Height - width_way;
                        gamePanel.Controls.Add(way);
                    }

                    i++;
                }
            }
            // }
        }
    }
}