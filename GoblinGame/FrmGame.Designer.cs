namespace GoblinGame
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.label1 = new System.Windows.Forms.Label();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblRestart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu = new System.Windows.Forms.MenuStrip();
            this.MnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.tmrRestart = new System.Windows.Forms.Timer(this.components);
            this.tmrScore = new System.Windows.Forms.Timer(this.components);
            this.LblName = new System.Windows.Forms.Label();
            this.BtnScore = new System.Windows.Forms.Button();
            this.lstScore = new System.Windows.Forms.ListBox();
            this.tmrAnim = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 29.75F);
            this.label1.Location = new System.Drawing.Point(130, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goblin Game";
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Silver;
            this.PnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlGame.BackgroundImage")));
            this.PnlGame.Controls.Add(this.pictureBox1);
            this.PnlGame.Controls.Add(this.LblRestart);
            this.PnlGame.Location = new System.Drawing.Point(12, 84);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(550, 317);
            this.PnlGame.TabIndex = 3;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 20);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // LblRestart
            // 
            this.LblRestart.AutoSize = true;
            this.LblRestart.BackColor = System.Drawing.Color.Gray;
            this.LblRestart.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblRestart.Location = new System.Drawing.Point(147, 26);
            this.LblRestart.Name = "LblRestart";
            this.LblRestart.Size = new System.Drawing.Size(252, 37);
            this.LblRestart.TabIndex = 15;
            this.LblRestart.Text = "Press R to restart.";
            this.LblRestart.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(43, 20);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuPause
            // 
            this.MnuPause.Name = "MnuPause";
            this.MnuPause.Size = new System.Drawing.Size(50, 20);
            this.MnuPause.Text = "Pause";
            this.MnuPause.Click += new System.EventHandler(this.MnuPause_Click);
            // 
            // Mnu
            // 
            this.Mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuPause,
            this.MnuQuit});
            this.Mnu.Location = new System.Drawing.Point(0, 0);
            this.Mnu.Name = "Mnu";
            this.Mnu.Size = new System.Drawing.Size(691, 24);
            this.Mnu.TabIndex = 2;
            this.Mnu.Text = "menuStrip2";
            // 
            // MnuQuit
            // 
            this.MnuQuit.Name = "MnuQuit";
            this.MnuQuit.Size = new System.Drawing.Size(76, 20);
            this.MnuQuit.Text = "Quit Game";
            this.MnuQuit.Click += new System.EventHandler(this.MnuQuit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score:";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(619, 128);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(13, 13);
            this.LblScore.TabIndex = 7;
            this.LblScore.Text = "0";
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 10;
            this.tmrGame.Tick += new System.EventHandler(this.TmrGame_Tick);
            // 
            // tmrRestart
            // 
            this.tmrRestart.Interval = 1;
            this.tmrRestart.Tick += new System.EventHandler(this.TmrRestart_Tick);
            // 
            // tmrScore
            // 
            this.tmrScore.Tick += new System.EventHandler(this.TmrScore_Tick);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(624, 84);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(0, 13);
            this.LblName.TabIndex = 15;
            // 
            // BtnScore
            // 
            this.BtnScore.Location = new System.Drawing.Point(581, 160);
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.Size = new System.Drawing.Size(75, 23);
            this.BtnScore.TabIndex = 16;
            this.BtnScore.Text = "Highscores";
            this.BtnScore.UseVisualStyleBackColor = true;
            this.BtnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // lstScore
            // 
            this.lstScore.FormattingEnabled = true;
            this.lstScore.Location = new System.Drawing.Point(734, 415);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(10, 4);
            this.lstScore.TabIndex = 11;
            // 
            // tmrAnim
            // 
            this.tmrAnim.Tick += new System.EventHandler(this.TmrAnim_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 416);
            this.Controls.Add(this.BtnScore);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mnu);
            this.KeyPreview = true;
            this.Name = "FrmGame";
            this.Text = "Goblin Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Mnu.ResumeLayout(false);
            this.Mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuPause;
        private System.Windows.Forms.MenuStrip Mnu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.ToolStripMenuItem MnuQuit;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Timer tmrRestart;
        private System.Windows.Forms.Label LblRestart;
        private System.Windows.Forms.Timer tmrScore;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnScore;
        private System.Windows.Forms.ListBox lstScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrAnim;
    }
}

