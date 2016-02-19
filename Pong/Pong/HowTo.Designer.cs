namespace Pong
{
    partial class HowTo
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
            this.Pages = new System.Windows.Forms.TabControl();
            this.Tab1Player = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Tab2Player = new System.Windows.Forms.TabPage();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.labelL2 = new System.Windows.Forms.Label();
            this.labelR1 = new System.Windows.Forms.Label();
            this.labelL1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pages.SuspendLayout();
            this.Tab1Player.SuspendLayout();
            this.Tab2Player.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.Tab1Player);
            this.Pages.Controls.Add(this.Tab2Player);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pages.Location = new System.Drawing.Point(0, 0);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(1182, 842);
            this.Pages.TabIndex = 0;
            this.Pages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            // 
            // Tab1Player
            // 
            this.Tab1Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Tab1Player.Controls.Add(this.label7);
            this.Tab1Player.Controls.Add(this.label6);
            this.Tab1Player.Controls.Add(this.label5);
            this.Tab1Player.Controls.Add(this.label4);
            this.Tab1Player.Controls.Add(this.labelL);
            this.Tab1Player.Controls.Add(this.labelR);
            this.Tab1Player.Controls.Add(this.label1);
            this.Tab1Player.Controls.Add(this.Title);
            this.Tab1Player.Location = new System.Drawing.Point(4, 40);
            this.Tab1Player.Name = "Tab1Player";
            this.Tab1Player.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1Player.Size = new System.Drawing.Size(1174, 798);
            this.Tab1Player.TabIndex = 0;
            this.Tab1Player.Text = "1 Player";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(401, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "in one try to win.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(432, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "in 5 Levels of increasing difficulty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(464, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reach 5 points before the computer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 701);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Space - Ready";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(638, 638);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(140, 17);
            this.labelL.TabIndex = 3;
            this.labelL.Text = "progress may be lost";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.Location = new System.Drawing.Point(476, 625);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(156, 32);
            this.labelR.TabIndex = 2;
            this.labelR.Text = "Esc - Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "W - up        S - Down";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(523, 116);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(167, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "1 Player";
            // 
            // Tab2Player
            // 
            this.Tab2Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Tab2Player.Controls.Add(this.labelP2);
            this.Tab2Player.Controls.Add(this.labelP1);
            this.Tab2Player.Controls.Add(this.label12);
            this.Tab2Player.Controls.Add(this.label11);
            this.Tab2Player.Controls.Add(this.labelR2);
            this.Tab2Player.Controls.Add(this.labelL2);
            this.Tab2Player.Controls.Add(this.labelR1);
            this.Tab2Player.Controls.Add(this.labelL1);
            this.Tab2Player.Controls.Add(this.label8);
            this.Tab2Player.Controls.Add(this.label13);
            this.Tab2Player.Location = new System.Drawing.Point(4, 25);
            this.Tab2Player.Name = "Tab2Player";
            this.Tab2Player.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2Player.Size = new System.Drawing.Size(1174, 813);
            this.Tab2Player.TabIndex = 1;
            this.Tab2Player.Text = "2 Player";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.Location = new System.Drawing.Point(655, 503);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(119, 32);
            this.labelP2.TabIndex = 21;
            this.labelP2.Text = "Player 2";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.Location = new System.Drawing.Point(365, 503);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(119, 32);
            this.labelP1.TabIndex = 20;
            this.labelP1.Text = "Player 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(490, 789);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 32);
            this.label12.TabIndex = 19;
            this.label12.Text = "Esc - Menu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(479, 741);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 32);
            this.label11.TabIndex = 18;
            this.label11.Text = "Space - Ready";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR2.Location = new System.Drawing.Point(605, 638);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(262, 32);
            this.labelR2.TabIndex = 17;
            this.labelR2.Text = "Down Arrow - Down";
            // 
            // labelL2
            // 
            this.labelL2.AutoSize = true;
            this.labelL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL2.Location = new System.Drawing.Point(392, 638);
            this.labelL2.Name = "labelL2";
            this.labelL2.Size = new System.Drawing.Size(129, 32);
            this.labelL2.TabIndex = 16;
            this.labelL2.Text = "S - Down";
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR1.Location = new System.Drawing.Point(605, 587);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(190, 32);
            this.labelR1.TabIndex = 15;
            this.labelR1.Text = "Up Arrow - Up";
            // 
            // labelL1
            // 
            this.labelL1.AutoSize = true;
            this.labelL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL1.Location = new System.Drawing.Point(421, 587);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(100, 32);
            this.labelL1.TabIndex = 14;
            this.labelL1.Text = "W - Up";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(449, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "First Player to reach 3 Points wins.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(477, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 44);
            this.label13.TabIndex = 8;
            this.label13.Text = "2 Player";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 842);
            this.panel1.TabIndex = 8;
            // 
            // HowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1182, 842);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.panel1);
            this.Name = "HowTo";
            this.Text = "HowTo";
            this.ClientSizeChanged += new System.EventHandler(this.HowTo_ClientSizeChanged);
            this.Pages.ResumeLayout(false);
            this.Tab1Player.ResumeLayout(false);
            this.Tab1Player.PerformLayout();
            this.Tab2Player.ResumeLayout(false);
            this.Tab2Player.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.TabPage Tab1Player;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabPage Tab2Player;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label labelL2;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelL1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP1;
    }
}