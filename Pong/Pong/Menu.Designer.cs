namespace Pong
{
    partial class Menu
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
            this.MenuArea = new System.Windows.Forms.Panel();
            this.QuitB = new System.Windows.Forms.Button();
            this.TwoPlayerB = new System.Windows.Forms.Button();
            this.OnePlayerB = new System.Windows.Forms.Button();
            this.graphic2 = new System.Windows.Forms.PictureBox();
            this.graphic1 = new System.Windows.Forms.PictureBox();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.HowToB = new System.Windows.Forms.Button();
            this.MenuArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphic1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuArea
            // 
            this.MenuArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MenuArea.Controls.Add(this.HowToB);
            this.MenuArea.Controls.Add(this.QuitB);
            this.MenuArea.Controls.Add(this.TwoPlayerB);
            this.MenuArea.Controls.Add(this.OnePlayerB);
            this.MenuArea.Controls.Add(this.graphic2);
            this.MenuArea.Controls.Add(this.graphic1);
            this.MenuArea.Controls.Add(this.MenuTitle);
            this.MenuArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuArea.Location = new System.Drawing.Point(0, 0);
            this.MenuArea.Name = "MenuArea";
            this.MenuArea.Size = new System.Drawing.Size(1146, 970);
            this.MenuArea.TabIndex = 0;
            this.MenuArea.ClientSizeChanged += new System.EventHandler(this.MenuArea_ClientSizeChanged);
            // 
            // QuitB
            // 
            this.QuitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitB.Location = new System.Drawing.Point(415, 800);
            this.QuitB.Name = "QuitB";
            this.QuitB.Size = new System.Drawing.Size(328, 85);
            this.QuitB.TabIndex = 4;
            this.QuitB.Text = "Quit";
            this.QuitB.UseVisualStyleBackColor = true;
            this.QuitB.Click += new System.EventHandler(this.QuitB_Click);
            // 
            // TwoPlayerB
            // 
            this.TwoPlayerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPlayerB.Location = new System.Drawing.Point(415, 518);
            this.TwoPlayerB.Name = "TwoPlayerB";
            this.TwoPlayerB.Size = new System.Drawing.Size(328, 85);
            this.TwoPlayerB.TabIndex = 2;
            this.TwoPlayerB.Text = "2 Player";
            this.TwoPlayerB.UseVisualStyleBackColor = true;
            this.TwoPlayerB.Click += new System.EventHandler(this.TwoPlayerB_Click);
            // 
            // OnePlayerB
            // 
            this.OnePlayerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePlayerB.Location = new System.Drawing.Point(415, 378);
            this.OnePlayerB.Name = "OnePlayerB";
            this.OnePlayerB.Size = new System.Drawing.Size(328, 85);
            this.OnePlayerB.TabIndex = 1;
            this.OnePlayerB.Text = "1 Player";
            this.OnePlayerB.UseVisualStyleBackColor = true;
            this.OnePlayerB.Click += new System.EventHandler(this.OnePlayerB_Click);
            // 
            // graphic2
            // 
            this.graphic2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.graphic2.Location = new System.Drawing.Point(0, 210);
            this.graphic2.Name = "graphic2";
            this.graphic2.Size = new System.Drawing.Size(400, 20);
            this.graphic2.TabIndex = 2;
            this.graphic2.TabStop = false;
            // 
            // graphic1
            // 
            this.graphic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.graphic1.Location = new System.Drawing.Point(0, 75);
            this.graphic1.Name = "graphic1";
            this.graphic1.Size = new System.Drawing.Size(400, 20);
            this.graphic1.TabIndex = 1;
            this.graphic1.TabStop = false;
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.Location = new System.Drawing.Point(510, 112);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(214, 74);
            this.MenuTitle.TabIndex = 0;
            this.MenuTitle.Text = "MENU";
            this.MenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // HowToB
            // 
            this.HowToB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToB.Location = new System.Drawing.Point(415, 660);
            this.HowToB.Name = "HowToB";
            this.HowToB.Size = new System.Drawing.Size(328, 85);
            this.HowToB.TabIndex = 3;
            this.HowToB.Text = "How To Play";
            this.HowToB.UseVisualStyleBackColor = true;
            this.HowToB.Click += new System.EventHandler(this.HowToB_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 970);
            this.Controls.Add(this.MenuArea);
            this.Name = "Menu";
            this.Text = "Menu";
            this.MenuArea.ResumeLayout(false);
            this.MenuArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuArea;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.PictureBox graphic2;
        private System.Windows.Forms.PictureBox graphic1;
        private System.Windows.Forms.Button QuitB;
        private System.Windows.Forms.Button TwoPlayerB;
        private System.Windows.Forms.Button OnePlayerB;
        private System.Windows.Forms.Button HowToB;
    }
}

