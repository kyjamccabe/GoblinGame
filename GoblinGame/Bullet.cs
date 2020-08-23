using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GoblinGame
{
    class Bullet
    {
        public int x, y, width, height;
        public Image bullet;//variable for the bullet's image
        public Rectangle bulletRec;//variable for a rectangle to place our image in

        // in the following constructor we pass in the values of spaceRec which
        // gives us the position of the spaceship which we can then use to place the
        // bullet where the spaceship is located
        public Bullet(Rectangle playerRec)
        {
            x = playerRec.X + 37; // move bullet to middle of spaceship
            y = playerRec.Y + 22;
            width = 20;
            height = 10;
            bullet = Properties.Resources.bullet;
            bulletRec = new Rectangle(x, y, width, height);
        }

        public void draw(Graphics g)
        {
            x += 20;//speed of bullet
            bulletRec = new Rectangle(x, y, width, height);
            g.DrawImage(bullet, bulletRec);
        }
    }
}
