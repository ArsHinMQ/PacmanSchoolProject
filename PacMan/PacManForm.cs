using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PacMan
{
    public partial class PacManForm : Form
    {
        // Game Global Variables
        Random rnd = new Random();
        public bool DidPlayerWon = false;
        public int time = 0;
        public int hearts = 3;
        public int NumberOfCoins = 0;

        // PacMan Settings
        bool PacManMouthOpen = false;
        string PacManDir = "right";
        int[] PacManBaseLocation;

        // Enemies' Settings
        int[] GreenEnemyBaseLocation, RedEnemyBaseLocation, PurpleEnemyBaseLocation;
        string GreenEnemyDir = "down";
        string RedEnemyDir = "left";
        string PurpleEnemyDir = "up";
        string[] dirs = { "up", "down", "right", "left" };

        public PacManForm()
        {
            InitializeComponent();
        }

        private void PacManForm_Load(object sender, EventArgs e)
        {
            // Save base location of each character 
            GreenEnemyBaseLocation = new int[2];
            GreenEnemyBaseLocation[0] = picEnemyGreen.Top;
            GreenEnemyBaseLocation[1] = picEnemyGreen.Left;

            RedEnemyBaseLocation = new int[2];
            RedEnemyBaseLocation[0] = picEnemyRed.Top;
            RedEnemyBaseLocation[1] = picEnemyRed.Left;

            PurpleEnemyBaseLocation = new int[2];
            PurpleEnemyBaseLocation[0] = picEnemyPurple.Top;
            PurpleEnemyBaseLocation[1] = picEnemyPurple.Left;

            PacManBaseLocation = new int[2];
            PacManBaseLocation[0] = picPacMan.Top;
            PacManBaseLocation[1] = picPacMan.Left;

            // Count Coins
            foreach (Control control in this.Controls)
            {
                if ((string)control.Tag == "coin")
                {
                    NumberOfCoins++;
                }
            }
        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            // Event for start button(label) -> change font color of label
            lblStartGame.ForeColor = (lblStartGame.ForeColor == Color.Lime) ? Color.Crimson : Color.Lime;
        }

        private void lblStartGame_Click(object sender, EventArgs e)
        {
            // Enable all the timers
            timer.Enabled = true;
            timerPacManMouth.Enabled = true;
            timerPacManRunning.Enabled = true;
            timerRedEnemy.Enabled = true;
            timerGreenEnemy.Enabled = true;
            timerPurpleEnemy.Enabled = true;

            // Add KeyDown event to form
            this.KeyDown += PacManForm_KeyDown;

            // Delete start button(Label) & its animation timer
            timerBlink.Dispose();
            lblStartGame.Dispose();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            lblTimer.Text = time.ToString();
        }

        private void PacManForm_KeyDown(object sender, KeyEventArgs e)
        {
            // In order to change PacMan's direction
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    PacManDir = "left";
                    timerPacManRunning.Enabled = true;
                    break;
                case Keys.Up:
                case Keys.W:
                    PacManDir = "up";
                    timerPacManRunning.Enabled = true;
                    break;
                case Keys.Down:
                case Keys.S:
                    PacManDir = "down";
                    timerPacManRunning.Enabled = true;
                    break;
                case Keys.Right:
                case Keys.D:
                    PacManDir = "right";
                    timerPacManRunning.Enabled = true;
                    break;
            }
        }

        private void timerPacMan_Tick(object sender, EventArgs e)
        {
            // PacMan Mouth Animation -> based on PacMan's direction and PacManMouthOpen's value
            picPacMan.ImageLocation = "img/" + ((PacManMouthOpen) ? "pacman-o-" : "pacman-") + PacManDir + ".png";
            PacManMouthOpen = !PacManMouthOpen;

        }

        private void timerPacManRunning_Tick(object sender, EventArgs e)
        {
            Running(picPacMan, ref PacManDir, 4, false);
        }

        private void enemyRedTimer(object sender, EventArgs e)
        {
            Running(picEnemyRed, ref RedEnemyDir, 5, true);
        }

        private void enemyGreenTimer(object sender, EventArgs e)
        {
            Running(picEnemyGreen, ref GreenEnemyDir, 5, true);
        }

        private void enemyPurpleTimer(object sender, EventArgs e)
        {
            Running(picEnemyPurple, ref PurpleEnemyDir, 5, true);
        }

        private void Running(PictureBox Character, ref string dir, int speed, bool isEnemy) {
            if (isEnemy && rnd.Next(0, 100) == 42)
            {
                // Change enemy's direction randomly
                dir = dirs[rnd.Next(0, 4)];
            } 
            switch (dir)
            {
                case "down":
                    Character.Top += speed;
                    break;
                case "up":
                    Character.Top -= speed;
                    break;
                case "right":
                    Character.Left += speed;
                    break;
                case "left":
                    Character.Left -= speed;
                    break;
            }

            // If character is out of game box, enter it from other side
            if (Character.Left <= -speed)
            {
                Character.Left = 975;
            }
            else if (Character.Left >= 975 + speed)
            {
                Character.Left = 0;
            }

            foreach (Control control in this.Controls)
            {
                if (Character.Bounds.IntersectsWith(control.Bounds))
                {
                    string tag = (string)control.Tag;
                    if (tag == "wall")
                    {
                        switch (dir)
                        {
                            case "down":
                                Character.Top -= speed;
                                break;
                            case "up":
                                Character.Top += speed;
                                break;
                            case "right":
                                Character.Left -= speed;
                                break;
                            case "left":
                                Character.Left += speed;
                                break;
                        }
                        if (isEnemy)
                        {
                            // If enemy's hit the wall, change its direction randomly
                            dir = dirs[rnd.Next(0, 4)];
                        } else {
                            timerPacManRunning.Enabled = false;
                        }
                        break;
                    }
                    else if (tag == "coin" && !isEnemy) {
                        NumberOfCoins--;
                        control.Dispose();  // Remove the coin
                        if (NumberOfCoins == 0)
                        {
                            // Player Won!
                            DidPlayerWon = true;
                            this.Close();
                        }
                        break;
                    }
                    else if ((tag == "PacMan" && isEnemy) || (tag == "enemy" && !isEnemy))
                    {
                        // If enemy's got PacMan or PacMan's hit enemy -> EnemyGotPacMan
                        EnemyGotPacMan();
                    }
                }
            }
        }

        private void EnemyGotPacMan()
        {
            switch (hearts)
            {
                case 1:
                    heart1.Dispose();
                    break;
                case 2:
                    heart2.Dispose();
                    break;
                case 3:
                    heart3.Dispose();
                    break;

            }
            hearts--;
            if (hearts == 0)
            {
                // Player's Lost
                this.Close();
            }

            // Place all characters at their base location
            picEnemyGreen.Top = GreenEnemyBaseLocation[0];
            picEnemyGreen.Left = GreenEnemyBaseLocation[1];

            picEnemyRed.Top = RedEnemyBaseLocation[0];
            picEnemyRed.Left = RedEnemyBaseLocation[1];

            picEnemyPurple.Top = PurpleEnemyBaseLocation[0];
            picEnemyPurple.Left = PurpleEnemyBaseLocation[1];

            picPacMan.Top = PacManBaseLocation[0];
            picPacMan.Left = PacManBaseLocation[1];
        }
    }
}
