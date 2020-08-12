using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GoblinGame
{
    class Player
    {
        public int x, y, width, height; //variables for the rectangle
        public Image player; //variable for the player's image
        public Rectangle playerRec; //variable for a rectangle to place our image in
        
        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            x = 20;
            y = 220;
            width = 60;
            height = 70;
            player = Properties.Resources.goblin1;
            playerRec = new Rectangle(x, y, width, height);
        }
        
        public void DrawPlayer(Graphics g)
        {
            g.DrawImage(player, playerRec);
        }
    }
}
