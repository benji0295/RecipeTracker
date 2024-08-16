using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeTracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void createAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void forgotPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelCreateAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccountPanel.Visible = false;
        }

        private void ResetButtonPassword_Click(object sender, EventArgs e)
        {

        }

        private void CancelResetButton_Click(object sender, EventArgs e)
        {
            ResetPasswordPanel.Visible = false;
        }
    }
}
