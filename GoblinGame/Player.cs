using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace GoblinGame
{
    class Player
    {
        public int x, y, width, height; //variables for the rectangle
        public Image player; //variable for the player's image
        
        Image[] images = new Image[3]; //Declare array

        public Rectangle playerRec; //variable for a rectangle to place our image in

        int count = 0;
        int gravity = 1;
        public int ySpeed = 18;

        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            images[0] = Image.FromFile("goblin0.png");
            images[1] = Image.FromFile("goblin1.png");
            images[2] = Image.FromFile("goblin2.png");

            x = 20;
            y = 220;
            width = 70;
            height = 80;
            player = images[count];
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
                if (playerRec.Location.X > 485) // is player within 50 of right side
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
                if (playerRec.Location.X < 10) // is player within 10 of left side
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
                    //If the player is jumping, gradually move it up then down
                    ySpeed -= gravity;
                    y -= ySpeed;
                    playerRec.Location = new Point(x, y);                       
            }
        }

        public void PlayerAnim()
        {
            player = images[count];
            count++;
            if (count > 2)
            {
                count = 1;
            }
        }
    }
}
