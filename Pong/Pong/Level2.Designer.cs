namespace Pong
{
    partial class Level2
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.AI = new System.Windows.Forms.PictureBox();
            this.PlayArea = new System.Windows.Forms.Panel();
            this.Level = new System.Windows.Forms.Label();
            this.BallSpeedYLabel = new System.Windows.Forms.Label();
            this.BallSpeedXLabel = new System.Windows.Forms.Label();
            this.Lose = new System.Windows.Forms.Label();
            this.Win = new System.Windows.Forms.Label();
            this.Prompt = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.TimerBall = new System.Windows.Forms.Timer(this.components);
            this.TimerAI = new System.Windows.Forms.Timer(this.components);
            this.TimerInfo = new System.Windows.Forms.Timer(this.components);
            this.HitInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI)).BeginInit();
            this.PlayArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Player.Location = new System.Drawing.Point(42, 268);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 150);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Green;
            this.Ball.Location = new System.Drawing.Point(574, 328);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 25);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // AI
            // 
            this.AI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AI.Location = new System.Drawing.Point(1117, 268);
            this.AI.Name = "AI";
            this.AI.Size = new System.Drawing.Size(30, 150);
            this.AI.TabIndex = 2;
            this.AI.TabStop = false;
            // 
            // PlayArea
            // 
            this.PlayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PlayArea.Controls.Add(this.HitInfo);
            this.PlayArea.Controls.Add(this.Level);
            this.PlayArea.Controls.Add(this.BallSpeedYLabel);
            this.PlayArea.Controls.Add(this.BallSpeedXLabel);
            this.PlayArea.Controls.Add(this.Lose);
            this.PlayArea.Controls.Add(this.Win);
            this.PlayArea.Controls.Add(this.Prompt);
            this.PlayArea.Controls.Add(this.Score);
            this.PlayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayArea.Location = new System.Drawing.Point(0, 0);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(1182, 675);
            this.PlayArea.TabIndex = 3;
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(563, 328);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(138, 44);
            this.Level.TabIndex = 4;
            this.Level.Text = "Level2";
            // 
            // BallSpeedYLabel
            // 
            this.BallSpeedYLabel.AutoSize = true;
            this.BallSpeedYLabel.Location = new System.Drawing.Point(39, 80);
            this.BallSpeedYLabel.Name = "BallSpeedYLabel";
            this.BallSpeedYLabel.Size = new System.Drawing.Size(48, 17);
            this.BallSpeedYLabel.TabIndex = 5;
            this.BallSpeedYLabel.Text = "Y: N/A";
            // 
            // BallSpeedXLabel
            // 
            this.BallSpeedXLabel.AutoSize = true;
            this.BallSpeedXLabel.Location = new System.Drawing.Point(39, 63);
            this.BallSpeedXLabel.Name = "BallSpeedXLabel";
            this.BallSpeedXLabel.Size = new System.Drawing.Size(48, 17);
            this.BallSpeedXLabel.TabIndex = 4;
            this.BallSpeedXLabel.Text = "X: N/A";
            // 
            // Lose
            // 
            this.Lose.AutoSize = true;
            this.Lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lose.Location = new System.Drawing.Point(546, 414);
            this.Lose.Name = "Lose";
            this.Lose.Size = new System.Drawing.Size(186, 44);
            this.Lose.TabIndex = 6;
            this.Lose.Text = "You Lose";
            // 
            // Win
            // 
            this.Win.AutoSize = true;
            this.Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win.Location = new System.Drawing.Point(563, 414);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(169, 44);
            this.Win.TabIndex = 4;
            this.Win.Text = "You Win";
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.Location = new System.Drawing.Point(413, 328);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(487, 44);
            this.Prompt.TabIndex = 1;
            this.Prompt.Text = "Press Space when Ready.";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(571, 63);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(98, 44);
            this.Score.TabIndex = 0;
            this.Score.Text = "0 : 0";
            // 
            // TimerBall
            // 
            this.TimerBall.Enabled = true;
            this.TimerBall.Tick += new System.EventHandler(this.TimerBall_Tick);
            // 
            // TimerAI
            // 
            this.TimerAI.Enabled = true;
            this.TimerAI.Tick += new System.EventHandler(this.TimerAI_Tick);
            // 
            // TimerInfo
            // 
            this.TimerInfo.Enabled = true;
            this.TimerInfo.Tick += new System.EventHandler(this.TimerInfo_Tick);
            // 
            // HitInfo
            // 
            this.HitInfo.AutoSize = true;
            this.HitInfo.Location = new System.Drawing.Point(39, 97);
            this.HitInfo.Name = "HitInfo";
            this.HitInfo.Size = new System.Drawing.Size(41, 17);
            this.HitInfo.TabIndex = 8;
            this.HitInfo.Text = "Hit: 0";
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 675);
            this.Controls.Add(this.AI);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.PlayArea);
            this.Name = "Level2";
            this.Text = "Level2";
            this.ClientSizeChanged += new System.EventHandler(this.Level2_ClientSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI)).EndInit();
            this.PlayArea.ResumeLayout(false);
            this.PlayArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox AI;
        private System.Windows.Forms.Panel PlayArea;
        private System.Windows.Forms.Timer TimerBall;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.Timer TimerAI;
        private System.Windows.Forms.Label BallSpeedYLabel;
        private System.Windows.Forms.Label BallSpeedXLabel;
        private System.Windows.Forms.Timer TimerInfo;
        private System.Windows.Forms.Label Lose;
        private System.Windows.Forms.Label Win;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label HitInfo;
    }
}