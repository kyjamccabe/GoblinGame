using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinGame
{
    public partial class frmGame : Form
    {

        Graphics g; //declare a graphics object called g
        Enemy bat1 = new Enemy(); //create the object, planet1
        Player goblin1 = new Player();

        public frmGame()
        {
            InitializeComponent();
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class&#39;s DrawPlanet method to draw the image planet1
            bat1.DrawEnemy(g);
            goblin1.DrawPlayer(g);
        }
    }
}
