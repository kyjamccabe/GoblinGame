using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;

namespace GoblinGame
{
    class Enemy
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image enemyImage;//variable for the bats image

        Image[] images = new Image[2]; //Declare array

        public Rectangle enemyRec;//variable for a rectangle to place our image in

        //Declare a random number generator
        Random rnd = new Random();
        int randomSpeed = 3;
        int count = 0;

        //Create a constructor (initialises the values of the fields)
        public Enemy()
        {
            images[0] = Image.FromFile("bat0.png");
            images[1] = Image.FromFile("bat1.png");

            x = 700;
            y = 120;
            width = 40;
            height = 40;
            enemyImage = images[count];
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
                randomSpeed = rnd.Next(1, 7);
            }
            else
            {
                x -= randomSpeed; //If it is not at the left of the screen, move it by the random number generated
            }          
            enemyRec.Location = new Point(x, y); //Move the rectangle to coincide with the enemy
        }

        public void EnemyAnim()
        {
            enemyImage = images[count];
            count++;
            if (count > 1)
            {
                count = 0;
            }
        }
    }
}
