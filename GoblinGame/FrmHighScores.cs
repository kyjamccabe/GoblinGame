﻿using System;
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
        public string playerName;
        string binPath = Application.StartupPath + @"\highscores.txt";
        List<HighScores> highScores = new List<HighScores>();

        public FrmHighScores(string name, int score)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            lblPlayerName.Text = name;
            lblPlayerScore.Text = score.ToString();
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
        }
        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                lstBoxName.Items.Add(s.Name);
                lstBoxScore.Items.Add(s.Score);

            }
        }

        private void FrmHighScores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(lblPlayerScore.Text) > lowest_score)
            {
                highScores.Add(new HighScores(lblPlayerName.Text, int.Parse(lblPlayerScore.Text)));
            }

            SortHighScores();
            DisplayHighScores();
        }

        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }

        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SaveHighScores();
            FrmGame FrmGame2 = new FrmGame(playerName);
            Hide();
            FrmGame2.ShowDialog();
        }
    }
}
