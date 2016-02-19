using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class HowTo : Form
    {
        public HowTo()
        {
            InitializeComponent();
            //sets window to maximized
            this.WindowState = FormWindowState.Maximized;
            //removes the border to make the window fullscreen
            FormBorderStyle = FormBorderStyle.None;
        }

        public Form RefMenu { get; set; }

        private void HowTo_ClientSizeChanged(object sender, EventArgs e)
        {
            Title.Left = panel1.Width / 2 - Title.Width / 2;
            label1.Left = panel1.Width / 2 - label1.Width / 2;
            label4.Left = panel1.Width / 2 - label4.Width / 2;
            label5.Left = panel1.Width / 2 - label5.Width / 2;
            label6.Left = panel1.Width / 2 - label6.Width / 2;
            label7.Left = panel1.Width / 2 - label7.Width / 2;
            label8.Left = panel1.Width / 2 - label8.Width / 2;
            label11.Left = panel1.Width / 2 - label11.Width / 2;
            label12.Left = panel1.Width / 2 - label12.Width / 2;
            label13.Left = panel1.Width / 2 - label13.Width / 2;

            labelL.Left = panel1.Width / 2 + 5;
            labelR1.Left = panel1.Width / 2 + 35;
            labelR2.Left = panel1.Width / 2 + 35;
            labelR.Left = panel1.Width / 2 - labelR.Width - 5;
            labelL1.Left = panel1.Width / 2 - 175;
            labelL2.Left = panel1.Width / 2 - 175;

            labelP1.Left = panel1.Width / 2 - 185;
            labelP2.Left = panel1.Width / 2 + 45;

        }

        private void Pages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //on Esc. key press the game is hidden and the menu is brought back up.
                this.Close();
                RefMenu.Show();
            }
        }
    }
}
