using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    public class HighScores
    {
        public HighScores(string name, int score)
        {
            //Get the name and score from FrmGame
            Name = name;
            Score = score;
        }
        //Set the name and score to be used in FrmHighscore
        public string Name { get; set; }

        public int Score { get; set; }
    }
}
