namespace Pong
{
    partial class TwoPlayer
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
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.PlayArea = new System.Windows.Forms.Panel();
            this.BallSpeedYLabel = new System.Windows.Forms.Label();
            this.BallSpeedXLabel = new System.Windows.Forms.Label();
            this.Win = new System.Windows.Forms.Label();
            this.Prompt = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.TimerBall = new System.Windows.Forms.Timer(this.components);
            this.TimerAI = new System.Windows.Forms.Timer(this.components);
            this.TimerInfo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
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
            this.Player.Size = new System.Drawing.Size(30, 120);
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
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Player2.Location = new System.Drawing.Point(1117, 268);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(30, 120);
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            // 
            // PlayArea
            // 
            this.PlayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PlayArea.Controls.Add(this.BallSpeedYLabel);
            this.PlayArea.Controls.Add(this.BallSpeedXLabel);
            this.PlayArea.Controls.Add(this.Win);
            this.PlayArea.Controls.Add(this.Prompt);
            this.PlayArea.Controls.Add(this.Score);
            this.PlayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayArea.Location = new System.Drawing.Point(0, 0);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(1182, 675);
            this.PlayArea.TabIndex = 3;
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
            // TimerInfo
            // 
            this.TimerInfo.Enabled = true;
            this.TimerInfo.Tick += new System.EventHandler(this.TimerInfo_Tick);
            // 
            // TwoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 675);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.PlayArea);
            this.Name = "TwoPlayer";
            this.Text = "TwoPlayer";
            this.ClientSizeChanged += new System.EventHandler(this.TwoPlayer_ClientSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TwoPlayer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            this.PlayArea.ResumeLayout(false);
            this.PlayArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Panel PlayArea;
        private System.Windows.Forms.Timer TimerBall;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.Timer TimerAI;
        private System.Windows.Forms.Label BallSpeedYLabel;
        private System.Windows.Forms.Label BallSpeedXLabel;
        private System.Windows.Forms.Timer TimerInfo;
        private System.Windows.Forms.Label Win;
    }
}