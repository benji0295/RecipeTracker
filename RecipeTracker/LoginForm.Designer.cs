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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
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
            this.ConfirmNewPassText = new System.Windows.Forms.TextBox();
            this.ResetPasswordText = new System.Windows.Forms.TextBox();
            this.ResetPassUsernameText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CancelResetButton = new System.Windows.Forms.Button();
            this.ResetButtonPassword = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.CreateAccountPanel.SuspendLayout();
            this.ResetPasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.label1.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(117, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(120, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernameTextBox.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.usernameTextBox.Location = new System.Drawing.Point(246, 262);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(348, 32);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.passwordTextBox.Location = new System.Drawing.Point(246, 357);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(348, 32);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.loginButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.loginButton.Location = new System.Drawing.Point(308, 467);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(195, 79);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.createAccountLabel.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.createAccountLabel.Location = new System.Drawing.Point(313, 569);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(183, 24);
            this.createAccountLabel.TabIndex = 5;
            this.createAccountLabel.TabStop = true;
            this.createAccountLabel.Text = "Create An Account";
            this.createAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createAccountLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.createAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLabel_LinkClicked);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.forgotPasswordLabel.Location = new System.Drawing.Point(304, 610);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(204, 24);
            this.forgotPasswordLabel.TabIndex = 6;
            this.forgotPasswordLabel.TabStop = true;
            this.forgotPasswordLabel.Text = "Forgot My Password";
            this.forgotPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forgotPasswordLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.forgotPasswordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(167, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 136);
            this.label3.TabIndex = 7;
            this.label3.Text = "PrepPal";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
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
            this.CreateAccountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
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
            this.CancelCreateAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.CancelCreateAccountButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCreateAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.CancelCreateAccountButton.Location = new System.Drawing.Point(424, 622);
            this.CancelCreateAccountButton.Name = "CancelCreateAccountButton";
            this.CancelCreateAccountButton.Size = new System.Drawing.Size(190, 90);
            this.CancelCreateAccountButton.TabIndex = 14;
            this.CancelCreateAccountButton.Text = "Cancel";
            this.CancelCreateAccountButton.UseVisualStyleBackColor = false;
            this.CancelCreateAccountButton.Click += new System.EventHandler(this.CancelCreateAccountButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.CreateAccountButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.CreateAccountButton.Location = new System.Drawing.Point(163, 622);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(190, 90);
            this.CreateAccountButton.TabIndex = 13;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameTextBox.Location = new System.Drawing.Point(247, 143);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(406, 31);
            this.FirstNameTextBox.TabIndex = 12;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameTextBox.Location = new System.Drawing.Point(247, 225);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(406, 31);
            this.LastNameTextBox.TabIndex = 11;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailTextBox.Location = new System.Drawing.Point(247, 299);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(406, 31);
            this.EmailTextBox.TabIndex = 10;
            // 
            // CreateUsernameTextBox
            // 
            this.CreateUsernameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateUsernameTextBox.Location = new System.Drawing.Point(246, 379);
            this.CreateUsernameTextBox.Name = "CreateUsernameTextBox";
            this.CreateUsernameTextBox.Size = new System.Drawing.Size(406, 31);
            this.CreateUsernameTextBox.TabIndex = 9;
            // 
            // CreatePasswordTextBox
            // 
            this.CreatePasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreatePasswordTextBox.Location = new System.Drawing.Point(247, 456);
            this.CreatePasswordTextBox.Name = "CreatePasswordTextBox";
            this.CreatePasswordTextBox.PasswordChar = '●';
            this.CreatePasswordTextBox.Size = new System.Drawing.Size(406, 31);
            this.CreatePasswordTextBox.TabIndex = 8;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(247, 535);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '●';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(406, 31);
            this.ConfirmPasswordTextBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label10.Location = new System.Drawing.Point(117, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label9.Location = new System.Drawing.Point(31, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label8.Location = new System.Drawing.Point(117, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label7.Location = new System.Drawing.Point(122, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label6.Location = new System.Drawing.Point(167, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label5.Location = new System.Drawing.Point(117, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label4.Location = new System.Drawing.Point(38, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(701, 90);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create An Account";
            // 
            // ResetPasswordPanel
            // 
            this.ResetPasswordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
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
            // ConfirmNewPassText
            // 
            this.ConfirmNewPassText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConfirmNewPassText.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPassText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.ConfirmNewPassText.Location = new System.Drawing.Point(339, 464);
            this.ConfirmNewPassText.Name = "ConfirmNewPassText";
            this.ConfirmNewPassText.PasswordChar = '●';
            this.ConfirmNewPassText.Size = new System.Drawing.Size(301, 32);
            this.ConfirmNewPassText.TabIndex = 8;
            // 
            // ResetPasswordText
            // 
            this.ResetPasswordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetPasswordText.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.ResetPasswordText.Location = new System.Drawing.Point(339, 360);
            this.ResetPasswordText.Name = "ResetPasswordText";
            this.ResetPasswordText.PasswordChar = '●';
            this.ResetPasswordText.Size = new System.Drawing.Size(301, 32);
            this.ResetPasswordText.TabIndex = 7;
            // 
            // ResetPassUsernameText
            // 
            this.ResetPassUsernameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetPassUsernameText.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassUsernameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.ResetPassUsernameText.Location = new System.Drawing.Point(339, 258);
            this.ResetPassUsernameText.Name = "ResetPassUsernameText";
            this.ResetPassUsernameText.Size = new System.Drawing.Size(301, 32);
            this.ResetPassUsernameText.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label14.Location = new System.Drawing.Point(61, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(242, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "Confirm New Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label13.Location = new System.Drawing.Point(159, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "New Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label12.Location = new System.Drawing.Point(216, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "Username";
            // 
            // CancelResetButton
            // 
            this.CancelResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.CancelResetButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.CancelResetButton.Location = new System.Drawing.Point(431, 596);
            this.CancelResetButton.Name = "CancelResetButton";
            this.CancelResetButton.Size = new System.Drawing.Size(198, 96);
            this.CancelResetButton.TabIndex = 2;
            this.CancelResetButton.Text = "Cancel";
            this.CancelResetButton.UseVisualStyleBackColor = false;
            this.CancelResetButton.Click += new System.EventHandler(this.CancelResetButton_Click);
            // 
            // ResetButtonPassword
            // 
            this.ResetButtonPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.ResetButtonPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButtonPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.ResetButtonPassword.Location = new System.Drawing.Point(155, 596);
            this.ResetButtonPassword.Name = "ResetButtonPassword";
            this.ResetButtonPassword.Size = new System.Drawing.Size(198, 96);
            this.ResetButtonPassword.TabIndex = 1;
            this.ResetButtonPassword.Text = "Reset Password";
            this.ResetButtonPassword.UseVisualStyleBackColor = false;
            this.ResetButtonPassword.Click += new System.EventHandler(this.ResetButtonPassword_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.label11.Location = new System.Drawing.Point(61, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(648, 97);
            this.label11.TabIndex = 0;
            this.label11.Text = "Reset Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 785);
            this.Controls.Add(this.CreateAccountPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ResetPasswordPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
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