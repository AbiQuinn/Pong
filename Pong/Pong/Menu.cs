using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace start
namespace Pong
{

    // menu class
    public partial class Menu : Form
    {

        // set speed of moving graphics
        int graphicspeed = 250;

        //menu form
        public Menu()
        {
            InitializeComponent();

            //sets window to maximized
            this.WindowState = FormWindowState.Maximized;
            //removes the border to make the window fullscreen
            FormBorderStyle = FormBorderStyle.None;
        }

        //Timer controls the moving of the graphics
        private void Timer_Tick(object sender, EventArgs e)
        {
            graphic1.Left += graphicspeed;
            graphic2.Left -= graphicspeed;

            //if either graphic reaches the edge of the screen the movement of both graphics reverses
            if (graphic1.Right > MenuArea.Width || graphic1.Left < 0 || graphic2.Left < 0 || graphic2.Right > MenuArea.Width)
            {
                graphicspeed = 0-graphicspeed;
            }

            //checks boolean on final level which is made true on game completion
            if (Level5.GameComplete)
            {
                //few changes to the menu screen to reward completion of the game
                MenuArea.BackColor = Color.DarkSeaGreen;
                MenuTitle.Text = "- VERIFIED PRO -";
                MenuTitle.Left = MenuArea.Width / 2 - MenuTitle.Width / 2;
            }
        }

        //whenever the window size changes this re-aligns the objects to the center.
        private void MenuArea_ClientSizeChanged(object sender, EventArgs e)
        {
            graphic1.Left = 0;
            graphic2.Left = MenuArea.Width - graphic2.Width;

            MenuTitle.Left = MenuArea.Width / 2 - MenuTitle.Width / 2;
            OnePlayerB.Left = MenuArea.Width/2 - OnePlayerB.Width/2;
            TwoPlayerB.Left = MenuArea.Width/2 - TwoPlayerB.Width/2;
            QuitB.Left = MenuArea.Width/2 - QuitB.Width/2;
            HowToB.Left = MenuArea.Width / 2 - HowToB.Width / 2;
        }
        
        //menu buttons
        private void QuitB_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }

        private void TwoPlayerB_Click(object sender, EventArgs e)
        {
            //creates an instance of the singleplayer level form and opens it.
            TwoPlayer TwoPlayer = new TwoPlayer();
            TwoPlayer.Show();

            //sets Menu in reference so Oneplayer can open it again later
            TwoPlayer.RefMenu = this;

            //hides Menu
            this.Hide();
        }

        private void OnePlayerB_Click(object sender, EventArgs e)
        {
            //creates an instance of the singleplayer level form and opens it.
            Level1 Level1 = new Level1();
            Level1.Show();

            //sets Menu in reference so Oneplayer can open it again later
            Level1.RefMenu = this;
             
            //hides Menu
            this.Hide();
        }

        private void HowToB_Click(object sender, EventArgs e)
        {
            //howto form
            HowTo HowTo = new HowTo();
            HowTo.Show();

            HowTo.RefMenu = this;

            this.Hide();
        }
    }
}
