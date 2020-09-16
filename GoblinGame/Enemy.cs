using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GoblinGame
{
    class Enemy
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image enemyImage;//variable for the bats image
        public Rectangle enemyRec;//variable for a rectangle to place our image in

        //Declare a random number generator
        Random rnd = new Random();
        int rndmspeed = 3;

        //Create a constructor (initialises the values of the fields)
        public Enemy()
        {
            x = 700;
            y = 120;
            width = 40;
            height = 40;
            enemyImage = Properties.Resources.bat1;
            enemyRec = new Rectangle(x, y, width, height);

        }

        // Methods for the Planet class
        public void DrawEnemy(Graphics g)
        {
            g.DrawImage(enemyImage, enemyRec);
            
        }

        public void MoveEnemy()
        {
            if (x <= -50) 
            {
                //If the enemy is at the left of the panel, reset its position and change its speed to a random number
                x = 700;
                rndmspeed = rnd.Next(1, 7);
            }
            else
            {
                x -= rndmspeed; //If it is not at the left of the screen, move it by the random number generated
            }          
            enemyRec.Location = new Point(x, y); //Move the rectangle to coincide with the enemy
        }
    }
}
