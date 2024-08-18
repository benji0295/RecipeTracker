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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void createAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPanel.Visible = false;
            CreateAccountPanel.Visible = true;
        }

        private void forgotPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPanel.Visible = false;
            ResetPasswordPanel.Visible = true;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelCreateAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccountPanel.Visible = false;
            LoginPanel.Visible = true;
        }

        private void ResetButtonPassword_Click(object sender, EventArgs e)
        {

        }

        private void CancelResetButton_Click(object sender, EventArgs e)
        {
            ResetPasswordPanel.Visible = false;
            LoginPanel.Visible = true;
        }
    }
}
