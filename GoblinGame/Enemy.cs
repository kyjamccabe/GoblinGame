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
        public Image enemyImage;//variable for the planet&#39;s image
        public Rectangle enemyRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Enemy()
        {
            x = 520;
            y = 120;
            width = 40;
            height = 40;

            //planetImage contains the plane1.png image
            enemyImage = Properties.Resources.bat1;
            enemyRec = new Rectangle(x, y, width, height);

        }

        // Methods for the Planet class
        public void DrawEnemy(Graphics g)
        {
            g.DrawImage(enemyImage, enemyRec);
        }
    }
}
