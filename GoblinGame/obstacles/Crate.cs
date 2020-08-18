using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GoblinGame.obstacles
{
    class Crate
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image crate;//variable for the crate's image
        public Rectangle crateRec;//variable for a rectangle to place our image in
        
        Random rnd = new Random();

        //Create a constructor (initialises the values of the fields)
        public Crate()
        {
            x = 800;
            y = 245;
            width = 50;
            height = 50;
            crate = Properties.Resources.crate;
            crateRec = new Rectangle(x, y, width, height);
        }

        public void DrawCrate(Graphics g)
        {
            g.DrawImage(crate, crateRec); //Draw crate image
        }

        public void MoveCrate()
        {
            if (x <= -50)
            {
                x = 550 + rnd.Next(100, 600);
                crateRec.Location = new Point(x, y);
            }
            else
            {
                x -= 2; //Move 2 to the left
                crateRec.Location = new Point(x, y);
            }
        }
    }
}
