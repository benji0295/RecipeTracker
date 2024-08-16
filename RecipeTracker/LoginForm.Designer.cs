namespace RecipeTracker
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.LinkLabel();
            this.forgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.CreateAccountPanel = new System.Windows.Forms.Panel();
            this.CancelCreateAccountButton = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CreateUsernameTextBox = new System.Windows.Forms.TextBox();
            this.CreatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetPasswordPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ResetButtonPassword = new System.Windows.Forms.Button();
            this.CancelResetButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ResetPassUsernameText = new System.Windows.Forms.TextBox();
            this.ResetPasswordText = new System.Windows.Forms.TextBox();
            this.ConfirmNewPassText = new System.Windows.Forms.TextBox();
            this.LoginPanel.SuspendLayout();
            this.CreateAccountPanel.SuspendLayout();
            this.ResetPasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(246, 262);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(348, 31);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(246, 357);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(348, 31);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(290, 467);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(195, 79);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Location = new System.Drawing.Point(293, 569);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(192, 25);
            this.createAccountLabel.TabIndex = 5;
            this.createAccountLabel.TabStop = true;
            this.createAccountLabel.Text = "Create An Account";
            this.createAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLabel_LinkClicked);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(285, 609);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(209, 25);
            this.forgotPasswordLabel.TabIndex = 6;
            this.forgotPasswordLabel.TabStop = true;
            this.forgotPasswordLabel.Text = "Forgot My Password";
            this.forgotPasswordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 106);
            this.label3.TabIndex = 7;
            this.label3.Text = "PrepPal";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.usernameTextBox);
            this.LoginPanel.Controls.Add(this.passwordTextBox);
            this.LoginPanel.Controls.Add(this.loginButton);
            this.LoginPanel.Controls.Add(this.createAccountLabel);
            this.LoginPanel.Controls.Add(this.forgotPasswordLabel);
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Location = new System.Drawing.Point(2, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(786, 789);
            this.LoginPanel.TabIndex = 8;
            // 
            // CreateAccountPanel
            // 
            this.CreateAccountPanel.Controls.Add(this.CancelCreateAccountButton);
            this.CreateAccountPanel.Controls.Add(this.CreateAccountButton);
            this.CreateAccountPanel.Controls.Add(this.FirstNameTextBox);
            this.CreateAccountPanel.Controls.Add(this.LastNameTextBox);
            this.CreateAccountPanel.Controls.Add(this.EmailTextBox);
            this.CreateAccountPanel.Controls.Add(this.CreateUsernameTextBox);
            this.CreateAccountPanel.Controls.Add(this.CreatePasswordTextBox);
            this.CreateAccountPanel.Controls.Add(this.ConfirmPasswordTextBox);
            this.CreateAccountPanel.Controls.Add(this.label10);
            this.CreateAccountPanel.Controls.Add(this.label9);
            this.CreateAccountPanel.Controls.Add(this.label8);
            this.CreateAccountPanel.Controls.Add(this.label7);
            this.CreateAccountPanel.Controls.Add(this.label6);
            this.CreateAccountPanel.Controls.Add(this.label5);
            this.CreateAccountPanel.Controls.Add(this.label4);
            this.CreateAccountPanel.Location = new System.Drawing.Point(2, 0);
            this.CreateAccountPanel.Name = "CreateAccountPanel";
            this.CreateAccountPanel.Size = new System.Drawing.Size(786, 789);
            this.CreateAccountPanel.TabIndex = 9;
            // 
            // CancelCreateAccountButton
            // 
            this.CancelCreateAccountButton.Location = new System.Drawing.Point(424, 622);
            this.CancelCreateAccountButton.Name = "CancelCreateAccountButton";
            this.CancelCreateAccountButton.Size = new System.Drawing.Size(190, 90);
            this.CancelCreateAccountButton.TabIndex = 14;
            this.CancelCreateAccountButton.Text = "Cancel";
            this.CancelCreateAccountButton.UseVisualStyleBackColor = true;
            this.CancelCreateAccountButton.Click += new System.EventHandler(this.CancelCreateAccountButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(163, 622);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(190, 90);
            this.CreateAccountButton.TabIndex = 13;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(247, 143);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(406, 31);
            this.FirstNameTextBox.TabIndex = 12;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(247, 225);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(406, 31);
            this.LastNameTextBox.TabIndex = 11;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(247, 299);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(406, 31);
            this.EmailTextBox.TabIndex = 10;
            // 
            // CreateUsernameTextBox
            // 
            this.CreateUsernameTextBox.Location = new System.Drawing.Point(246, 379);
            this.CreateUsernameTextBox.Name = "CreateUsernameTextBox";
            this.CreateUsernameTextBox.Size = new System.Drawing.Size(406, 31);
            this.CreateUsernameTextBox.TabIndex = 9;
            // 
            // CreatePasswordTextBox
            // 
            this.CreatePasswordTextBox.Location = new System.Drawing.Point(247, 456);
            this.CreatePasswordTextBox.Name = "CreatePasswordTextBox";
            this.CreatePasswordTextBox.Size = new System.Drawing.Size(406, 31);
            this.CreatePasswordTextBox.TabIndex = 8;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(247, 535);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(406, 31);
            this.ConfirmPasswordTextBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 538);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(701, 90);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create An Account";
            // 
            // ResetPasswordPanel
            // 
            this.ResetPasswordPanel.Controls.Add(this.ConfirmNewPassText);
            this.ResetPasswordPanel.Controls.Add(this.ResetPasswordText);
            this.ResetPasswordPanel.Controls.Add(this.ResetPassUsernameText);
            this.ResetPasswordPanel.Controls.Add(this.label14);
            this.ResetPasswordPanel.Controls.Add(this.label13);
            this.ResetPasswordPanel.Controls.Add(this.label12);
            this.ResetPasswordPanel.Controls.Add(this.CancelResetButton);
            this.ResetPasswordPanel.Controls.Add(this.ResetButtonPassword);
            this.ResetPasswordPanel.Controls.Add(this.label11);
            this.ResetPasswordPanel.Location = new System.Drawing.Point(2, 0);
            this.ResetPasswordPanel.Name = "ResetPasswordPanel";
            this.ResetPasswordPanel.Size = new System.Drawing.Size(786, 786);
            this.ResetPasswordPanel.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(599, 90);
            this.label11.TabIndex = 0;
            this.label11.Text = "Reset Password";
            // 
            // ResetButtonPassword
            // 
            this.ResetButtonPassword.Location = new System.Drawing.Point(132, 637);
            this.ResetButtonPassword.Name = "ResetButtonPassword";
            this.ResetButtonPassword.Size = new System.Drawing.Size(198, 96);
            this.ResetButtonPassword.TabIndex = 1;
            this.ResetButtonPassword.Text = "Reset Password";
            this.ResetButtonPassword.UseVisualStyleBackColor = true;
            this.ResetButtonPassword.Click += new System.EventHandler(this.ResetButtonPassword_Click);
            // 
            // CancelResetButton
            // 
            this.CancelResetButton.Location = new System.Drawing.Point(416, 637);
            this.CancelResetButton.Name = "CancelResetButton";
            this.CancelResetButton.Size = new System.Drawing.Size(198, 96);
            this.CancelResetButton.TabIndex = 2;
            this.CancelResetButton.Text = "Cancel";
            this.CancelResetButton.UseVisualStyleBackColor = true;
            this.CancelResetButton.Click += new System.EventHandler(this.CancelResetButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Username";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "New Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Confirm New Password";
            // 
            // ResetPassUsernameText
            // 
            this.ResetPassUsernameText.Location = new System.Drawing.Point(313, 255);
            this.ResetPassUsernameText.Name = "ResetPassUsernameText";
            this.ResetPassUsernameText.Size = new System.Drawing.Size(301, 31);
            this.ResetPassUsernameText.TabIndex = 6;
            // 
            // ResetPasswordText
            // 
            this.ResetPasswordText.Location = new System.Drawing.Point(313, 357);
            this.ResetPasswordText.Name = "ResetPasswordText";
            this.ResetPasswordText.Size = new System.Drawing.Size(301, 31);
            this.ResetPasswordText.TabIndex = 7;
            // 
            // ConfirmNewPassText
            // 
            this.ConfirmNewPassText.Location = new System.Drawing.Point(313, 464);
            this.ConfirmNewPassText.Name = "ConfirmNewPassText";
            this.ConfirmNewPassText.Size = new System.Drawing.Size(301, 31);
            this.ConfirmNewPassText.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 785);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.CreateAccountPanel);
            this.Controls.Add(this.ResetPasswordPanel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.CreateAccountPanel.ResumeLayout(false);
            this.CreateAccountPanel.PerformLayout();
            this.ResetPasswordPanel.ResumeLayout(false);
            this.ResetPasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel createAccountLabel;
        private System.Windows.Forms.LinkLabel forgotPasswordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel CreateAccountPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelCreateAccountButton;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox CreateUsernameTextBox;
        private System.Windows.Forms.TextBox CreatePasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel ResetPasswordPanel;
        private System.Windows.Forms.Button CancelResetButton;
        private System.Windows.Forms.Button ResetButtonPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ConfirmNewPassText;
        private System.Windows.Forms.TextBox ResetPasswordText;
        private System.Windows.Forms.TextBox ResetPassUsernameText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}