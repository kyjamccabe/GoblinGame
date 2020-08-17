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

        int gravity = 1;
        int yspeed = 17;

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

        public void MovePlayer(string move)
        {
            playerRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (playerRec.Location.X > 485) // is spaceship within 50 of right side
                {
                    x = 490;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    playerRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (playerRec.Location.X < 10) // is spaceship within 10 of left side
                {
                    x = 5;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    playerRec.Location = new Point(x, y);
                }
            }

            if (move == "jump")
            {                    
                    yspeed = yspeed - gravity;
                    y = y - yspeed;
                    playerRec.Location = new Point(x, y);                       
            }
        }

        public void OnGround()
        {
            yspeed = 17;
        }
    }
}
