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
    public partial class FrmGame : Form
    {

        Graphics g; //declare a graphics object called g

        //Creates objects for each of the sprites
        Enemy bat1 = new Enemy();
        Player player = new Player(); 
        Crate crate = new Crate();
        Bush bush = new Bush();
        Tree tree = new Tree();

        List<Bullet> bullets = new List<Bullet>(); //Declare a list bullet from the bullet class

        bool left, right, jump;
        bool restart = false;
        bool shoot = true;
        string move;
        int score;

        public FrmGame(string playerName)
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true }); //Removes panel flickering
            lblName.Text = playerName;
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            
            //Calls to each objects respective draw methods
            bat1.DrawEnemy(g);
            player.DrawPlayer(g);
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
            //Sets variables according to key presses
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { jump = true; }
            if (e.KeyData == Keys.Space && shoot == true) { bullets.Add(new Bullet(player.playerRec)); }
            if (e.KeyData == Keys.R) { restart = true; }
        }

        private void frmGame_KeyUp(object sender, KeyEventArgs e)
        {
            //Unsets variables according to keys that aren't pressed
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.R) { restart = false; }
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            //Enable timers on start
            tmrGame.Enabled = true;
            tmrScore.Enabled = true;
            tmrAnim.Enabled = true;
        }

        private void mnuPause_Click(object sender, EventArgs e)
        {
            //Disable timers on pause
            tmrGame.Enabled = false;
            tmrScore.Enabled = false;
            tmrAnim.Enabled = false;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Close all forms when quit is pressed
        }

        private void tmrScore_Tick(object sender, EventArgs e)
        {
            //Adds to score and sets label accordingly on timer tick
            score += 1;
            lblScore.Text = score.ToString();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            //Closes FrmGame, opens FrmHighscore
            FrmHighScores FrmHighScore2 = new FrmHighScores(lblName.Text, Convert.ToInt32(lblScore.Text));
            Hide();
            FrmHighScore2.ShowDialog();
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Closes all forms if FrmGame is closed in any way
        }

        private void tmrAnim_Tick(object sender, EventArgs e)
        {
            player.PlayerAnim(); //Call to anim2
            bat1.EnemyAnim();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                player.MovePlayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                player.MovePlayer(move);
            }

            if (jump == true) //If space is pressed
            {
                move = "jump";
                player.MovePlayer(move);
            }

            if (player.y == 220) //Reset jump when the player hits the ground, so the player my jump again
            {
                jump = false;
                player.ySpeed = 17;              
            }

            bush.MoveBush();
            crate.MoveCrate();
            tree.MoveTree();
            
            //If the objects intersect with each other, move them
            if (tree.treeRec.IntersectsWith(crate.crateRec) || tree.treeRec.IntersectsWith(bush.bushRec))
            {
                tree.x += 20;
            }

            if (crate.crateRec.IntersectsWith(tree.treeRec) || crate.crateRec.IntersectsWith(bush.bushRec))
            {
                crate.x += 10;
            }

            if (score > 100) //Allow enemies to move only when score is > 100
            {
                bat1.MoveEnemy();
            }

            foreach (Bullet b in bullets) //If the bat intersects with the bullet reset the bat and remove the bullet, or the bullet reaches the right side of the panel, remove the bullet
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

            if (player.playerRec.IntersectsWith(crate.crateRec) || player.playerRec.IntersectsWith(tree.treeRec) || player.playerRec.IntersectsWith(bush.bushRec) || player.playerRec.IntersectsWith(bat1.enemyRec))
            {
                //If the player intersects with any bad objects, stop the game and show the restart label
                tmrGame.Enabled = false;
                tmrRestart.Enabled = true;
                tmrScore.Enabled = false;
                tmrAnim.Enabled = false;
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
                //If the player has lost and r is pressed, set everything back to its original place
                tmrGame.Enabled = true;
                tmrRestart.Enabled = false;
                tmrScore.Enabled = true;
                tmrAnim.Enabled = true;
                mnuStart.Enabled = true;
                lblRestart.Visible = false;
                player.x = 20;
                player.y = 220;

                jump = false;
                shoot = true;
                string move = string.Empty;
                score = 0;
                player.ySpeed = 20;

                crate.x = 800;
                tree.x = 1000;
                bush.x = 600;
                bat1.x = 700;

                bush.MoveBush();
                crate.MoveCrate();
                tree.MoveTree();
                player.MovePlayer(move);
                bat1.MoveEnemy();
            }

            pnlGame.Invalidate();
        }
    }
}

