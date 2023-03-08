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
    public partial class WinnerForm : Form
    {
        int scnds = 0;
        public WinnerForm()
        {
            InitializeComponent();
        }

        private void WinnerForm_Load(object sender, EventArgs e)
        {
            slideText.Start();
            
        }

        private void slideText_Tick(object sender, EventArgs e)
        {
            Random scnd = new Random();

            int scnds = scnd.Next(10, 12);

            winnerLbl.Left = winnerLbl.Left + scnds;


            if (winnerLbl.Bounds.IntersectsWith(spawnBtn.Bounds))
            {
                winnerLbl.Location = new Point(-587, 34);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
