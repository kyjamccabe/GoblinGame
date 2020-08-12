using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using GoblinGame.obstacles;
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
        Crate crate = new Crate();
        Bush bush = new Bush();
        Tree tree = new Tree();

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

            bat1.DrawEnemy(g);
            goblin1.DrawPlayer(g);
            tree.DrawTree(g);
            crate.DrawCrate(g);
            bush.DrawBush(g);
        }
    }
}
