using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using GoblinGame.obstacles;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GoblinGame
{
    public partial class frmGame : Form
    {

        Graphics g; //declare a graphics object called g
        Random rnd = new Random();
        Enemy bat1 = new Enemy(); //create the object, bat1
        Player goblin1 = new Player();
        Crate crate = new Crate();
        Bush bush = new Bush();
        Tree tree = new Tree();

        //declare a list  bullet from the bullet class
        List<Bullet> bullets = new List<Bullet>();

        bool left, right, jump;
        bool restart = false;
        bool shoot = true;
        string move;


        public frmGame()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
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

            foreach (Bullet b in bullets)
            {
                b.DrawBullet(g);
            }
        }
        
        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { jump = true; }
            if (e.KeyData == Keys.Space && shoot == true) { bullets.Add(new Bullet(goblin1.playerRec)); }
            if (e.KeyData == Keys.R) { restart = true; }
        }

        private void frmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.R) { restart = false; }
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            tmrGame.Enabled = true;
        }

        private void mnuPause_Click(object sender, EventArgs e)
        {
            tmrGame.Enabled = false;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                goblin1.MovePlayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                goblin1.MovePlayer(move);
            }

            if (jump == true)
            {
                move = "jump";
                goblin1.MovePlayer(move);
            }

            if (goblin1.y == 220)
            {
                jump = false;
                goblin1.yspeed = 17;              
            }

            bush.MoveBush();
            crate.MoveCrate();
            tree.MoveTree();

            if (tree.treeRec.IntersectsWith(crate.crateRec) || tree.treeRec.IntersectsWith(bush.bushRec))
            {
                tree.x += 20;
            }

            if (crate.crateRec.IntersectsWith(tree.treeRec) || crate.crateRec.IntersectsWith(bush.bushRec))
            {
                crate.x += 10;
            }

            bat1.MoveEnemy();

            foreach (Bullet b in bullets)
            {
                if (bat1.enemyRec.IntersectsWith(b.bulletRec))
                {
                    bat1.x = -50;
                    bullets.Remove(b);
                    break;
                }
                
                if (b.bulletRec.X >= 700)
                {
                    bullets.Remove(b);
                    break;
                }
            }

            if (goblin1.playerRec.IntersectsWith(crate.crateRec) || goblin1.playerRec.IntersectsWith(tree.treeRec) || goblin1.playerRec.IntersectsWith(bush.bushRec) || goblin1.playerRec.IntersectsWith(bat1.enemyRec))
            {
                tmrGame.Enabled = false;
                tmrRestart.Enabled = true;
                lblRestart.Visible = true;
                mnuStart.Enabled = false;
                shoot = false;
            }

            pnlGame.Invalidate(); //makes the paint event fire to redraw the panel
        }

        private void tmrRestart_Tick(object sender, EventArgs e)
        {
            if (restart == true)
            {
                tmrGame.Enabled = true;
                tmrRestart.Enabled = false;
                mnuStart.Enabled = true;
                lblRestart.Visible = false;
                goblin1.x = 20;
                goblin1.y = 220;

                jump = false;
                shoot = true;
                string move = string.Empty;
                goblin1.yspeed = 17;

                crate.x = 800;
                tree.x = 1000;
                bush.x = 600;
                bat1.x = 700;

                bush.MoveBush();
                crate.MoveCrate();
                tree.MoveTree();
                goblin1.MovePlayer(move);
                bat1.MoveEnemy();
            }

            pnlGame.Invalidate();
        }
    }
}

