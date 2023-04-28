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
    public partial class Login : Form
    {
        public string nickname = "";
        public bool didWindowClosed = false;
        public Login()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 4)
            {
                lblAlert.Text = "حداقل  طول پسورد چهار کاراکتر است";
                btnLogin.Enabled = false;
            }
            else
            {
                lblAlert.Text = "";
                btnLogin.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtNickname.Text.Trim();
            if (name.Length == 0)
            {
                lblAlert.Text = "نام کاربری نمیتواند خالی باشد.";
            }
            else
            {
                int length = playerTableAdapter1.FillByGetPlayerByNickname(pacmanDataSet1.player, name);
                if (length == 0)
                {
                    playerTableAdapter1.InsertPlayer(name, txtPassword.Text);
                    nickname = name;
                    this.Close();
                }
                else
                {
                    DataRow userData = pacmanDataSet1.player.Rows[0];
                    if (userData["password"].ToString() == txtPassword.Text)
                    {
                        nickname = name;
                        this.Close();
                    }
                    else
                    {
                        lblAlert.Text = "پسورد اشتباه است";
                    }
                }
            }
        }
    }
}
