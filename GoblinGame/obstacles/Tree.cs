using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GoblinGame.obstacles
{
    class Tree
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image tree;//variable for the tree's image

        public Rectangle treeRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Tree()
        {
            x = 400;
            y = 250;
            width = 50;
            height = 50;
            tree = Properties.Resources.tree;
            treeRec = new Rectangle(x, y, width, height);
        }

        public void DrawTree(Graphics g)
        {
            g.DrawImage(tree, treeRec); //Draw rock image
        }
    }
}
