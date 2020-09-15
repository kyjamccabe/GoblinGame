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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRestart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu = new System.Windows.Forms.MenuStrip();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.tmrRestart = new System.Windows.Forms.Timer(this.components);
            this.tmrScore = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.lstScore = new System.Windows.Forms.ListBox();
            this.pnlGame.SuspendLayout();
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
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Silver;
            this.pnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGame.BackgroundImage")));
            this.pnlGame.Controls.Add(this.pictureBox1);
            this.pnlGame.Controls.Add(this.lblRestart);
            this.pnlGame.Location = new System.Drawing.Point(12, 84);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(550, 317);
            this.pnlGame.TabIndex = 3;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
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
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.Gray;
            this.lblRestart.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRestart.Location = new System.Drawing.Point(147, 26);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(252, 37);
            this.lblRestart.TabIndex = 15;
            this.lblRestart.Text = "Press R to restart.";
            this.lblRestart.Visible = false;
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
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(43, 20);
            this.mnuStart.Text = "Start";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuPause
            // 
            this.mnuPause.Name = "mnuPause";
            this.mnuPause.Size = new System.Drawing.Size(50, 20);
            this.mnuPause.Text = "Pause";
            this.mnuPause.Click += new System.EventHandler(this.mnuPause_Click);
            // 
            // Mnu
            // 
            this.Mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuPause,
            this.mnuQuit});
            this.Mnu.Location = new System.Drawing.Point(0, 0);
            this.Mnu.Name = "Mnu";
            this.Mnu.Size = new System.Drawing.Size(691, 24);
            this.Mnu.TabIndex = 2;
            this.Mnu.Text = "menuStrip2";
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(76, 20);
            this.mnuQuit.Text = "Quit Game";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
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
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(619, 128);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 10;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // tmrRestart
            // 
            this.tmrRestart.Interval = 1;
            this.tmrRestart.Tick += new System.EventHandler(this.tmrRestart_Tick);
            // 
            // tmrScore
            // 
            this.tmrScore.Tick += new System.EventHandler(this.tmrScore_Tick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(624, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 15;
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(581, 160);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(75, 23);
            this.btnScore.TabIndex = 16;
            this.btnScore.Text = "Highscores";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // lstScore
            // 
            this.lstScore.FormattingEnabled = true;
            this.lstScore.Location = new System.Drawing.Point(734, 415);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(10, 4);
            this.lstScore.TabIndex = 11;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 416);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mnu);
            this.KeyPreview = true;
            this.Name = "FrmGame";
            this.Text = "Goblin Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyUp);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Mnu.ResumeLayout(false);
            this.Mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuPause;
        private System.Windows.Forms.MenuStrip Mnu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Timer tmrRestart;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.Timer tmrScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.ListBox lstScore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

