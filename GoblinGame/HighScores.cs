using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    class HighScores
    {
        public HighScores(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public string Name { get; set; }

        public int Score { get; set; }
    }
}
