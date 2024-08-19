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
            LoginPanel.Visible = true;
            LoginPanel.BringToFront();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username=  usernameTextBox.Text;
            string password = passwordTextBox.Text;

            Account loggedInAccount = AccountManager.ValidateLogin(username, password);

            if (loggedInAccount != null)
            {
                Form1 form1 = new Form1(loggedInAccount);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                passwordTextBox.Text = "";
            }
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
            string username = CreateUsernameTextBox.Text;
            string password = CreatePasswordTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string email = EmailTextBox.Text;


            if (!AccountManager.AccountExists(username))
            {
                Account newAccount = new Account(username, password, firstName, lastName, email);
                AccountManager.AddAccount(newAccount);
                MessageBox.Show("Account created successfully. Please login.");
            }
            else
            {
                MessageBox.Show("Account already exists. Please login or create a new account.");
            }
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
