using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarRaceGame
{
    
    public partial class RaceScreen : Form
    {
        Int32 firstcar = 0, secondcar = 0, thirdcar = 0, firstcarboost = 0, secondcarboost = 0, thirdcarboost = 0, racestartSecnd = 3, firstcarboostt = 0,
              secondcarboostt = 0, thirdcarboostt = 0, firstcarbreak = 0, scndcarbreak = 0, thirdcarbreak = 0;



        private void racetimer_Tick(object sender, EventArgs e)
        {         
         if (car1PictureBox.Location.X > car2PictureBox.Location.X)  //NamePlateLeader//
            {
                namePlateLbl.Text = "Car1 Took To Lead";
            }
            else if (car1PictureBox.Location.X > car3PictureBox.Location.X)
            {
                namePlateLbl.Text = "Car1 Took To Lead";
            }
            else if (car2PictureBox.Location.X > car3PictureBox.Location.X)
            {
                namePlateLbl.Text = "Car2 Took To Lead";
            }
            else if (car3PictureBox.Location.X > car2PictureBox.Location.X)
            {
                namePlateLbl.Text = "Car3 Took To Lead";
            }


        }

        private void Car1BoostTimer_Tick(object sender, EventArgs e)
        {
            Random firstcarrnd = new Random();
            int firstcarboostt = firstcarrnd.Next(1, 4);
            car1PictureBox.Left = car1PictureBox.Left + firstcarboostt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            car2BoostBtn.Enabled = false;
            Car2BoostTimer.Start();
            car2boostBar.Value = 0;
        }

        private void Car2BoostTimer_Tick(object sender, EventArgs e)
        {
            Random scndcarrnd = new Random();
            int secondcarboostt = scndcarrnd.Next(1, 4);
            car2PictureBox.Left = car2PictureBox.Left + secondcarboostt;
        }

        private void Car3BoostTimer_Tick(object sender, EventArgs e)
        {
            Random thrdcarrnd = new Random();
            int thirdcarboostt = thrdcarrnd.Next(1, 4);
            car3PictureBox.Left = car3PictureBox.Left + thirdcarboostt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            car3BoostBtn.Enabled = false;
            Car3BoostTimer.Start();
            car3boostBar.Value = 0;
        }

        private void car1BreakTimer_Tick(object sender, EventArgs e)
        {
                      
        }

        private void car2RaceTimer_Tick(object sender, EventArgs e)
        {
            Random secondcarrnd = new Random();

            int secondcar = secondcarrnd.Next(3, 6);

            car2PictureBox.Left = car2PictureBox.Left + secondcar;

            if (car2PictureBox.Bounds.IntersectsWith(finishLineBtn.Bounds)) //Eğer 2. Araba Finish'e degerse//
            {
                racetimer.Stop();
                car1RaceTimer.Stop();
                car2RaceTimer.Stop();
                car3RaceTimer.Stop();


                Car1BoostTimer.Stop();
                Car2BoostTimer.Stop();
                Car3BoostTimer.Stop();

                SoundPlayer leaderboard = new SoundPlayer(@"leaderboard.wav");
                leaderboard.Play();

                MessageBox.Show("Race Finished Go To Leaderboard");
                WinnerForm win = new WinnerForm();
                win.winnerLbl.Text = "Car2IsWinner";

                xd.dx = 2;

                win.Show();
                this.Hide();
            }
        }

        private void car3RaceTimer_Tick(object sender, EventArgs e)
        {
            Random thirdcarrnd = new Random();

            int thirdcar = thirdcarrnd.Next(3, 6);

            car3PictureBox.Left = car3PictureBox.Left + thirdcar;

            if (car3PictureBox.Bounds.IntersectsWith(finishLineBtn.Bounds)) //Eğer 3. Araba Finish'e degerse//
            {
                racetimer.Stop();
                car1RaceTimer.Stop();
                car2RaceTimer.Stop();
                car3RaceTimer.Stop();

                Car1BoostTimer.Stop();
                Car2BoostTimer.Stop();
                Car3BoostTimer.Stop();

                SoundPlayer leaderboard = new SoundPlayer(@"leaderboard.wav");
                leaderboard.Play();

                MessageBox.Show("Race Finished Go To Leaderboard");
                WinnerForm win = new WinnerForm();
                win.winnerLbl.Text = "Car3IsWinner";

                xd.dx = 3;

                win.Show();
                this.Hide();
            }
        }

        private void car1RaceTimer_Tick(object sender, EventArgs e)
        {
            Random firstcarrnd = new Random();

            int firstcar = firstcarrnd.Next(3, 6);

            car1PictureBox.Left = car1PictureBox.Left + firstcar;

            if (car1PictureBox.Bounds.IntersectsWith(finishLineBtn.Bounds))  //Eğer 1. Araba Finish'e degerse//              
            {
                racetimer.Stop();
                car1RaceTimer.Stop();
                car2RaceTimer.Stop();
                car3RaceTimer.Stop();


                Car1BoostTimer.Stop();
                Car2BoostTimer.Stop();
                Car3BoostTimer.Stop();

                car1BoostBtn.Enabled = false;
                car2BoostBtn.Enabled = false;
                car3BoostBtn.Enabled = false;

                

                SoundPlayer leaderboard = new SoundPlayer(@"leaderboard.wav");
                leaderboard.Play();



                MessageBox.Show("Race Finished Go To Leaderboard");
                WinnerForm win = new WinnerForm();
                win.winnerLbl.Text = "Car1IsWinner";

                xd.dx = 1;

                win.Show();
                this.Hide();

            }
        }

        private void visibleBreakBtn_Click(object sender, EventArgs e)
        {
            car1RaceTimer.Start();
        }

        private void RaceScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                visibleBreakBtn.PerformClick();
            }
            if (e.KeyCode == Keys.X)
            {
                visibleBreakBtn2.PerformClick();
            }
            if (e.KeyCode == Keys.C)
            {
                visibleBreakBtn3.PerformClick();
            }

        }

        private void car2BreakBtn_Click(object sender, EventArgs e)
        {
            car2RaceTimer.Stop();
            Car2BoostTimer.Stop();
        }

        private void visibleBreakBtn2_Click(object sender, EventArgs e)
        {
            car2RaceTimer.Start();
        }

        private void car3BreakBtn_Click(object sender, EventArgs e)
        {
            car3RaceTimer.Stop();
            Car3BoostTimer.Stop();
        }

        private void visibleBreakBtn3_Click(object sender, EventArgs e)
        {
            car3RaceTimer.Start();
        }

        private void car1BreakBtn_MouseUp(object sender, MouseEventArgs e)
        {
            car1RaceTimer.Start();
            Car1BoostTimer.Start();
        }

        private void car2BreakBtn_MouseDown(object sender, MouseEventArgs e)
        {
            car2RaceTimer.Stop();
            Car2BoostTimer.Stop();
        }

        private void car2BreakBtn_MouseUp(object sender, MouseEventArgs e)
        {
            car2RaceTimer.Start();
            Car2BoostTimer.Start();
        }

        private void car3BreakBtn_MouseDown(object sender, MouseEventArgs e)
        {
            car2RaceTimer.Stop();
            Car2BoostTimer.Stop();
        }

        private void car3BreakBtn_MouseUp(object sender, MouseEventArgs e)
        {
            car2RaceTimer.Start();
            Car2BoostTimer.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            car1RaceTimer.Stop();
            Car1BoostTimer.Stop();
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            car1RaceTimer.Stop();
            Car1BoostTimer.Stop();
        }

        private void RaceScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                car1BoostBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.S)
            {
                car2BoostBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                car3BoostBtn.PerformClick();
            }
            if (e.KeyCode == Keys.Z)
            {
                car1BreakBtn.PerformClick();
            }
            if (e.KeyCode == Keys.X)
            {
                car2BreakBtn.PerformClick();
            }
            if (e.KeyCode == Keys.C)
            {
                car3BreakBtn.PerformClick();
            }

        }

            private void button9_Click(object sender, EventArgs e)
        {
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void racestartTimer_Tick(object sender, EventArgs e)
        {
            int sayacc = racestartSecnd--;
            racestartLbl.Text = sayacc.ToString();


            if (sayacc == 0)
            {
                racestartTimer.Stop();
                racetimer.Start();
                car1RaceTimer.Start();
                car2RaceTimer.Start();
                car3RaceTimer.Start();
                racestartLbl.Visible = false;

                car1BoostBtn.Enabled = true;
                car2BoostBtn.Enabled = true;
                car3BoostBtn.Enabled = true;
                car1BreakBtn.Enabled = true;
                car2BreakBtn.Enabled = true;
                car3BreakBtn.Enabled = true;
                visibleBreakBtn.Enabled = true;
                visibleBreakBtn.Visible = true;
                visibleBreakBtn2.Enabled = true;
                visibleBreakBtn3.Enabled = true;
                visibleBreakBtn2.Visible = true;
                visibleBreakBtn3.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void RaceScreen_Load(object sender, EventArgs e)
        {           
            car1BoostBtn.Enabled = false;
            car2BoostBtn.Enabled = false;
            car3BoostBtn.Enabled = false;
            car1BreakBtn.Enabled = false;
            visibleBreakBtn.Visible = false;
            visibleBreakBtn2.Visible = false;
            visibleBreakBtn3.Visible = false;
            visibleBreakBtn.Enabled = false;
            visibleBreakBtn2.Enabled = false;
            visibleBreakBtn3.Enabled = false;
            wayBtn.Enabled = false;
            car2BreakBtn.Enabled = false;
            car3BreakBtn.Enabled = false;
            racestartLbl.Visible = false;
            car1boostBar.Value = 100;
            car2boostBar.Value = 100;
            car3boostBar.Value = 100;
            button2.Enabled = false;
            car1boostBar.ForeColor = Color.Yellow;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {                        
            car1BoostBtn.Enabled = false;
            Car1BoostTimer.Start();
            car1boostBar.Value = 0;
           
        }

        public RaceScreen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            racestartTimer.Start();
           
            startRaceBtn.Enabled = false;          
            racestartLbl.Visible = true;

        }
    }
}
