using CarRaceGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRaceGame
{
    
    public partial class SplashScreen : Form
    {
        int seconds = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            splashscreentimer.Stop();
            loadingBar.Visible = false;
            loadingBarCarGif.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playBtn.Visible = false;
            cntrlsBtn.Visible = false;
            aboutBtn.Visible = false;
            exitBtn.Visible = false;

            this.Size = new Size(299, 186);
            this.StartPosition = FormStartPosition.CenterScreen;

            

            splashscreentimer.Start();
            splashscreentimer.Enabled = true;
            loadingBar.Visible = true;
            loadingBarCarGif.Visible = true;
   
            cargif.Start();


            SoundPlayer carhorn = new SoundPlayer(@"carhorn.wav");
            carhorn.Play();






        }

        private void splashscreentimer_Tick(object sender, EventArgs e)
        {          
            loadingBar.Increment(2);
            if (loadingBar.Value == 100)
            {
                splashscreentimer.Enabled = false;
                this.Hide();
                RaceScreen racefrm = new RaceScreen();
                racefrm.Show();
            }
                

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            playBtn.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About aboutfrm = new About();
            aboutfrm.Show();
            this.Hide();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            aboutBtn.BackColor = Color.Gray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            aboutBtn.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            playBtn.BackColor = Color.White;
        }

        private void cargif_Tick(object sender, EventArgs e)
        {
            loadingBarCarGif.Left = loadingBarCarGif.Left + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.White;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            exitBtn.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Controls cntrl = new Controls();           
            cntrl.Show();
            this.Hide();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            cntrlsBtn.BackColor = Color.White;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            cntrlsBtn.BackColor = Color.Gray;
        }
    }
}
