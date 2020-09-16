using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GoblinGame.obstacles
{
    class Bush
    {
        // declare fields to use in the class
        public int x, y, width, height; //variables for the rectangle
        public Image bush; //variable for the bush's image

        public Rectangle bushRec;//variable for a rectangle to place our image in
        Random rnd = new Random();

        //Create a constructor (initialises the values of the fields)
        public Bush()
        {
            x = 600;
            y = 254;
            width = 60;
            height = 50;
            bush = Properties.Resources.bush;
            bushRec = new Rectangle(x, y, width, height);
        }

        public void DrawBush(Graphics g)
        {
            g.DrawImage(bush, bushRec); //Draw bush image
        }

        public void MoveBush()
        {
            if (x <= -50) //If the bush is past the left side of the panel
            {
                x = 550 + rnd.Next(50, 400); //Set at a random position (within boundaries)
                bushRec.Location = new Point(x, y); //Set the location of the rectangle holding the bush
            }
            else //If the bush hasn't reached the left side of the panel
            {
                x -= 2; //Move 2 to the left
                bushRec.Location = new Point(x, y);
            }
        }
    }
}
