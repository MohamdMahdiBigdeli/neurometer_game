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

        private int index_startButton_location;

        private Random random = new Random();

        public GameWindow()
        {
            InitializeComponent();
            index_startButton_location = random.Next(0, 4);
            startButton.Location = buttons_location[index_startButton_location];
            buttons_location.RemoveAt(index_startButton_location);
            endButton.Location = buttons_location[random.Next(0, 3)];
        }
    }
}