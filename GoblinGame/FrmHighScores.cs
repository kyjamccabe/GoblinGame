using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GoblinGame
{
    public partial class FrmHighScores : Form
    {
        string name;

        string binPath = "highscores.txt"; //File holding the highscores
        List<HighScores> highScores = new List<HighScores>();

        public FrmHighScores(string playerName, int score)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            LblPlayerName.Text = playerName;
            LblPlayerScore.Text = score.ToString();
            var reader = new StreamReader(binPath);
            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                var values = line.Split(',');
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1])));
            }
            reader.Close();
            name = LblPlayerName.Text; //Set the name string to be the same as lblPLayerNames text
        }
        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores) //Foreach value in the highscore file
            {
                LstBoxName.Items.Add(s.Name); //Add the name of the player to the listbox
                LstBoxScore.Items.Add(s.Score); //Add the score of the player to the listbox

            }
        }

        private void FrmHighScores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(LblPlayerScore.Text) > lowest_score) //If the score the player got was higher than the lowest score displayed
            {
                highScores.Add(new HighScores(LblPlayerName.Text, int.Parse(LblPlayerScore.Text))); //Add the name and score to highScores
            }

            SortHighScores();
            DisplayHighScores();
        }

        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList(); //Sets the box to only show 10 scores and put them in descending order
        }

        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine)); //Adds scores to a variable, {0} is for the Name, {1} is for the Score and {2} is for a new line
            }
            File.WriteAllText(binPath, builder.ToString()); //Write the variable with the scores to the file
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            //Sets closes FrmHighscores and opens FrmGame
            SaveHighScores();
            FrmGame FrmGame2 = new FrmGame(name);
            Hide();
            FrmGame2.ShowDialog();
        }

        private void FrmHighScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Saves highscores and exits the whole game if FrmHighscores is manually closed           
            Application.Exit();
        }
    }
}
