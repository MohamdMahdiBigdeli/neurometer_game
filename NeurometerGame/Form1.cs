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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            a = 1;
            label1.Text = "0";
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (MessageBox.Show("آیا دوباره بازی می کنید؟", "شما یردید!", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
               a = 0;
               label1.Text = "Neuro meter";
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (a == 1)
            {
                if (MessageBox.Show("آیا دوباره تلاش می کنید؟", "شما باختید", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    a = 0;
                    label1.Text = "Neuro meter";
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }
    }
}