using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class TwoPlayer : Form
    {

        //imports DLL file using "InteropServices"
        [DllImport("user32.dll")]
        //declares external method from the "user32.dll" file used to get keyboard info
        public static extern int GetKeyboardState(byte[] keystate);

        // set base ball speed
        int BallSpeedY = 30;
        int BallSpeedX = 30;
        // create a random integer variable
        Random rnd = new Random();
        // initialize scores to 0
        int PlayerScore = 0;
        int Player2Score = 0;
        //creates boolean and sets it as false for use in toggles
        bool flag = false;

        //reference for the menu to reload it if needed.
        public Form RefMenu { get; set; }
        
        //initializing the form
        public TwoPlayer()
        {
            InitializeComponent();

            //sets window to maximized
            this.WindowState = FormWindowState.Maximized;
            //removes the border to make the window fullscreen
            FormBorderStyle = FormBorderStyle.None;
            //sets ball speed info label to be invisible.
            BallSpeedXLabel.Visible = false;
            BallSpeedYLabel.Visible = false;
            //stops TimerInfo as its not needed yet
            TimerInfo.Stop();
            //Win and lose statements invisible till needed
            Win.Visible = false;
            
            // pause game at start until player is ready
            TimerBall.Stop();
            TimerAI.Stop();
            Prompt.Visible = true;
        }

        //Player controls are checked by this timer.
        private void Timer_Tick(object sender, EventArgs e)
        {
            // byte array called 'keys' to hold keyboard data
            byte[] keys = new byte[256];

            //aquiring keyboard data and passing it to the byte array
            GetKeyboardState(keys);

            //a key is given the value 128 or 129 in the byte array if it is pressed.
            //if checks if W is pressed and that the players paddle is able to move upwards without leaving playarea.
            if (((keys[(int)Keys.W]) == 128 || (keys[(int)Keys.W]) == 129) && Player.Top > 0)
            {
                Player.Top -= 30;
            }
            //if checks if S is pressed and that the players paddle is able to move downwards without leaving playarea.
            if (((keys[(int)Keys.S]) == 128 || (keys[(int)Keys.S]) == 129) && Player.Top < PlayArea.Height - Player.Height)
            {
                Player.Top += 30;
            }

            if (((keys[(int)Keys.Up]) == 128 || (keys[(int)Keys.Up]) == 129) && Player2.Top > 0)
            {
                Player2.Top -= 30;
            }
            //if checks if S is pressed and that the players paddle is able to move downwards without leaving playarea.
            if (((keys[(int)Keys.Down]) == 128 || (keys[(int)Keys.Down]) == 129) && Player2.Top < PlayArea.Height - Player2.Height)
            {
                Player2.Top += 30;
            }
        }

        //Ball movements are checked by this timer. The score is updated here too.
        private void TimerBall_Tick(object sender, EventArgs e)
        {

            //the ball is hidden before moving to avoid seeing the ball in positions between the two movements.
            Ball.Hide();
            Ball.Top += BallSpeedY;
            Ball.Left += BallSpeedX;
            Ball.Show();
            //after moving the ball re-appears (this happens so quickly you hardly notice)
            // showing the ball moving however causes blurring and seeing the ball diagonally (unappealing and confusing)

            //if the ball is at the edge of the play area and moving in a direction that would put it out of the area then...
            if (Ball.Top >= PlayArea.Height - Ball.Height && BallSpeedY > 0 || Ball.Top <= 0 && BallSpeedY < 0)
            {
                //custom method to flip the direction the ball is travelling and add a little randomness 
                BallSpeedY = ReverseBallSpeed(BallSpeedY);
            }

            //if the ball leaves the sides of the playing area (behind the paddles) then...
            if (Ball.Left >= PlayArea.Right - Ball.Width)
            {
                //it leaves to the right so the players score increases
                PlayerScore++;
                Score.Text = PlayerScore + " : " + Player2Score;

                //reset positions of play
                Ball.Left = PlayArea.Width / 2 - Ball.Width / 2;
                Ball.Top = PlayArea.Height / 2 - Ball.Height / 2;
                Player2.Top = PlayArea.Height / 2 - Player2.Height / 2;
                Player.Top = PlayArea.Height / 2 - Player.Height / 2;

                //ball direction changes to go towards player after prompt.
                BallSpeedX = ReverseBallSpeed(BallSpeedX);
                //stop ball and AI from moving until player is ready again
                TimerBall.Stop();

                if (PlayerScore >= 3)
                {
                    //Win condition
                    Win.Text = "Player 1 wins!";
                    Win.Left = PlayArea.Width / 2 - Win.Width / 2;
                    Win.Visible = true;
                    Score.Top += 290;
                    Prompt.Text = "Press Space to return to menu";
                    Prompt.Left = PlayArea.Width / 2 - Prompt.Width / 2;
                    Prompt.Visible = true;
                }
                else
                {
                    Prompt.Visible = true;
                }              
            }

            //Same as above but check the left side and increases AI's score if it goes past the player.
            if (Ball.Left <= 0)
            {
                //player misses the ball and the AI scores
                Player2Score++;
                Score.Text = PlayerScore + " : " + Player2Score;

                //reset positions of play
                Ball.Left = PlayArea.Width / 2 - Ball.Width / 2;
                Ball.Top = PlayArea.Height / 2 - Ball.Height / 2;
                Player2.Top = PlayArea.Height / 2 - Player2.Height / 2;
                Player.Top = PlayArea.Height / 2 - Player.Height / 2;

                //ball direction changes to go towards player after prompt.
                BallSpeedX = ReverseBallSpeed(BallSpeedX);
                //stop ball and AI from moving until player is ready again
                TimerBall.Stop();

                if (Player2Score >= 3)
                {
                    //Win condition
                    Win.Text = "Player 2 wins!";
                    Win.Left = PlayArea.Width / 2 - Win.Width / 2;
                    Win.Visible = true;
                    Score.Top += 290;
                    Prompt.Text = "Press Space to return to menu";
                    Prompt.Left = PlayArea.Width / 2 - Prompt.Width / 2;
                    Prompt.Visible = true;
                }
                else
                {
                    Prompt.Visible = true;
                }
            }

            //if the ball crosses either paddle then...
            if (Ball.Bounds.IntersectsWith(Player.Bounds) && BallSpeedX < 0|| Ball.Bounds.IntersectsWith(Player2.Bounds) && BallSpeedX > 0)
            {
                //custom method to flip the direction the ball is travelling and add a little randomness (same as before)
                BallSpeedX = ReverseBallSpeed(BallSpeedX);
            }
        }

        //BallSpeed info is updated here and shown ingame using the Tab key
        private void TimerInfo_Tick(object sender, EventArgs e)
        {
            //updates labels with variable values
            BallSpeedXLabel.Text = "X : " + BallSpeedX;
            BallSpeedYLabel.Text = "Y : " + BallSpeedY;
        }

        //Keydown Events
        private void TwoPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            //checks for Esc. key press
            if(e.KeyCode == Keys.Escape)
            {
                //on Esc. key press the game is hidden and the menu is brought back up.
                this.Close();
                RefMenu.Show();
            }

            //checks for spacebar press
            if (e.KeyCode == Keys.Space)
            {
                if (PlayerScore >= 3 || Player2Score >= 3)
                {
                    //returns to menu
                    RefMenu.Show();
                    //closes level4
                    this.Close();
                }
                else if (PlayerScore < 3 && Player2Score < 3)
                {
                    //on spacebar press, the ball will resume movement after the ready check mentioned in TimerBall.
                    TimerBall.Start();
                    //and the prompt disappears.
                    Prompt.Visible = false;
                }
            }

            //checks for tab key press
            if (e.KeyCode == Keys.Tab)
            {
                //simple boolean switch toggle
                if (flag == false)
                {
                    flag = true;
                    //makes visible labels that relay variable information and starts the Timer that updates them.
                    BallSpeedXLabel.Visible = true;
                    BallSpeedYLabel.Visible = true;
                    //timer updates label that shows ballspeedx and y
                    TimerInfo.Start();
                }
                else
                {
                    flag = false;
                    //makes visible labels that relay variable information and starts the Timer that updates them.
                    BallSpeedXLabel.Visible = false;
                    BallSpeedYLabel.Visible = false;
                    //timer updates label that shows ballspeedx and y
                    TimerInfo.Stop();
                }
            }
        }

        //Form size change
        private void TwoPlayer_ClientSizeChanged(object sender, EventArgs e)
        {
            //when the form changes size all elements are moved to correct positions in the screen.
            Player.Left = 40;
            Player.Top = PlayArea.Height / 2 - Player.Height / 2;

            Ball.Left = PlayArea.Width / 2 - Ball.Width / 2;
            Ball.Top = PlayArea.Height / 2 - Ball.Height / 2;

            Player2.Left = PlayArea.Right - Player2.Width - 40;
            Player2.Top = PlayArea.Height / 2 - Player2.Height / 2;

            Score.Left = PlayArea.Width / 2 - Score.Width / 2;
            Score.Top = PlayArea.Top + 150;

            Prompt.Left = PlayArea.Width / 2 - Prompt.Width / 2;
            Prompt.Top = PlayArea.Height / 2 + 60;

            Win.Left = PlayArea.Width / 2 - Win.Width / 2;
            Win.Top = PlayArea.Height / 2 - Win.Height / 2 - 150;
        }

        //custom method for reversing an integer and changing it slightly by a random amount.
        public int ReverseBallSpeed(int n)
        {
            //checks if the number is positive or negative. Positive number goes in here.
            if (n > 0)
            {

                // limits number to between 30 and 40
                if (n < 40 && n > 30)
                {
                    //creates random integer between -8 and 2 (lowest is inclusive, highest is exclusive (so 2 not 3))
                    int i = rnd.Next(-8, 3);
                    n = (-n) + i;
                    return n;
                }

                //if the number is outside the "acceptable speed range (30-40)" the else if and else will slowly set them back
                else if (n < 35)
                {
                    n = -(n) - 5;
                    return n;
                }
                //numbers are weighted so that the speed stays faster for longer and slower for shorter.
                else
                {
                    n = -(n) + 2;
                    return n;
                }
            }

            //same as above but edited for negative numbers.
            else if (n < 0)
            {
                if (n < -30 && n > -40)
                {
                    int i = rnd.Next(-2, 9);
                    n = (-n) + i;
                    return n;
                }
                else if (n > -35)
                {
                    n = -(n) + 5;
                    return n;
                }
                else
                {
                    n = -(n) - 2;
                    return n;
                }
            }

            // contingency, if for any reason the number didn't go through the ifs
            //i.e. the number was 0 (which it should never be) then this would reset the number to the middle speed 35.
            else
            {
                n = 35;
                return n;
            }
        }

    }
}
