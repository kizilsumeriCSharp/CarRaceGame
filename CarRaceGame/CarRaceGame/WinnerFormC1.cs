using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarRaceGame
{
    public partial class WinnerFormC1 : Form
    {
        public WinnerFormC1()
        {
            InitializeComponent();
        }

        private void WinnerFormC1_Load(object sender, EventArgs e)
        {
            if (xd.dx == 1)
            {
                frstroundwnrlbl.Text = ("Car1isWinner");
            }
            else if (xd.dx == 2)
            {
                frstroundwnrlbl.Text = ("Car2isWinner");
            }
            else if (xd.dx == 3)
            {
                frstroundwnrlbl.Text = ("Car3isWinner");
            }
            
            if (xdd.dxx == 1)
            {
                scnroundwnrlbl.Text = ("Car1isWinner");
            }
            else if (xdd.dxx == 2)
            {
                scnroundwnrlbl.Text = ("Car2isWinner");
            }
            else if (xdd.dxx == 3)
            {
                scnroundwnrlbl.Text = ("Car3isWinner");
            }
            
            if (xddd.dxxx == 1)
            {
                thrdrndwnrlbl.Text = ("Car1isWinner");
            }
            else if (xddd.dxxx == 2)
            {
                thrdrndwnrlbl.Text = ("Car2isWinner");
            }
            else if (xddd.dxxx == 3)
            {
                thrdrndwnrlbl.Text = ("Car3isWinner");
            }
        }
    }
}
