using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRaceGame
{
    public partial class RaceScreen2 : Form
    {
        Int32 firstcar = 0, secondcar = 0, thirdcar = 0, firstcarboost = 0, secondcarboost = 0, thirdcarboost = 0;

        private void Car1BoostTimer_Tick(object sender, EventArgs e)
        {
            int sayac = firstcarboost++;
            if (sayac == 3)
            {
                Car1BoostTimer.Stop();
                button5.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + 100;
            Car2BoostTimer.Start();
            button6.Enabled = false;
        }

        private void Car2BoostTimer_Tick(object sender, EventArgs e)
        {
            int sayac = secondcarboost++;
            if (sayac == 3)
            {
                Car2BoostTimer.Stop();
                button6.Enabled = true;
            }
        }

        private void Car3BoostTimer_Tick(object sender, EventArgs e)
        {
            int sayac = thirdcarboost++;
            if (sayac == 3)
            {
                Car3BoostTimer.Stop();
                button7.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left + 100;
            button7.Enabled = false;
            Car3BoostTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 100;
            button5.Enabled = false;
            Car1BoostTimer.Start();
        }

        private void racetimer_Tick(object sender, EventArgs e)
        {
            Random firstcarrnd = new Random();
            Random secondcarrnd = new Random();
            Random thirdcarrnd = new Random();

            int firstcar = firstcarrnd.Next(3, 13);
            int secondcar = secondcarrnd.Next(3, 13);
            int thirdcar = thirdcarrnd.Next(3, 13);

            pictureBox1.Left = pictureBox1.Left + firstcar;
            pictureBox2.Left = pictureBox2.Left + secondcar;
            pictureBox3.Left = pictureBox3.Left + thirdcar;

            if (pictureBox1.Bounds.IntersectsWith(button1.Bounds))
            {
                racetimer.Stop();
                button4.Enabled = true;
                RaceScreen3 rs3 = new RaceScreen3();
                RaceScreen2 rs2 = new RaceScreen2();
                rs3.scnroundwnrlbl.Text = ("Car1 Is Wınner");
                rs3.frstroundwnrlbl.Text = rs2.frstroundwnrlbl.Text;
                MessageBox.Show("First Round Finished Go to Next Round");
                xdd.dxx = 1;
                rs3.Show();
                this.Hide();

            }
            if (pictureBox2.Bounds.IntersectsWith(button1.Bounds))
            {
                racetimer.Stop();
                button4.Enabled = true;
                RaceScreen3 rs3 = new RaceScreen3();
                rs3.scnroundwnrlbl.Text = ("Car2 Is Wınner");
                MessageBox.Show("First Round Finished Go to Next Round");
                xdd.dxx = 2;
                rs3.Show();
                this.Hide();
            }
            if (pictureBox3.Bounds.IntersectsWith(button1.Bounds))
            {
                racetimer.Stop();
                button4.Enabled = true;
                RaceScreen3 rs3 = new RaceScreen3();
                rs3.scnroundwnrlbl.Text = ("Car3 Is Wınner");
                MessageBox.Show("Second Round Finished Go to Next Round");
                xdd.dxx = 3;
                rs3.Show();
                this.Hide();
            }
        }

        public RaceScreen2()
        {
            InitializeComponent();
        }

        private void RaceScreen2_Load(object sender, EventArgs e)
        {
            button9.Enabled = false;

            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            racetimer.Start();
            button3.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }
    }
}
