using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class DashboardForm : Form
    {
        string nickname = "";
        int highScore;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Launch the Game
            Login loginForm = new Login();
            loginForm.ShowDialog();
            if (loginForm.nickname == "") {
                this.Close();
            } else {
                nickname = loginForm.nickname;
                btnPlay_Click(btnPlay, e);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            playerTableAdapter1.FillByGetPlayerByNickname(pacmanDataSet1.player, nickname);
            DataRow userData = pacmanDataSet1.player.Rows[0];

            PacManForm pmf = new PacManForm();
            pmf.ShowDialog();

            highScore = int.Parse(userData["highscore"].ToString());
            lblHighScore.Text = (highScore == 0) ? "" : "بهترین زمان: " + highScore;

            if (pmf.DidPlayerWon)
            {
                lblTitle.ForeColor = Color.Green;
                lblTitle.Text = "بردی";
                if (pmf.time < int.Parse(userData["highscore"].ToString()) || highScore == 0) {
                    playerTableAdapter1.UpdatePlayerHighScore(pmf.time, nickname);
                    lblHighScore.Text = "بهترین زمان: " + pmf.time;
                }
            }
            else
            {
                lblTitle.ForeColor = Color.Red;
                lblTitle.Text = "باختی";
            }
            lblHaert.Text = "قلب ها: " + pmf.hearts.ToString();
            lblTime.Text = "زمان: " + pmf.time.ToString();
            lblCoins.Text = "سکه های باقی مانده: " + pmf.NumberOfCoins.ToString();
        }
    }
}
