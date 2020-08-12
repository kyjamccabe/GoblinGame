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
        public int x, y, width, height;//variables for the rectangle
        public Image bush;//variable for the bush's image

        public Rectangle bushRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Bush()
        {
            x = 300;
            y = 250;
            width = 60;
            height = 50;
            bush = Properties.Resources.bush;
            bushRec = new Rectangle(x, y, width, height);
        }

        public void DrawBush(Graphics g)
        {
            g.DrawImage(bush, bushRec); //Draw rock image
        }
    }
}
