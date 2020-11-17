namespace LogIn_Sandbox
{
    partial class LogIn
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
            this.userNameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.userNameLable = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.resetPWLink = new System.Windows.Forms.LinkLabel();
            this.newuserlinkLabel = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(99, 61);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(100, 20);
            this.userNameField.TabIndex = 0;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(99, 98);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 1;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(124, 141);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // userNameLable
            // 
            this.userNameLable.AutoSize = true;
            this.userNameLable.Location = new System.Drawing.Point(28, 64);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.Size = new System.Drawing.Size(63, 13);
            this.userNameLable.TabIndex = 3;
            this.userNameLable.Text = "User Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(28, 101);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // resetPWLink
            // 
            this.resetPWLink.AutoSize = true;
            this.resetPWLink.Location = new System.Drawing.Point(28, 146);
            this.resetPWLink.Name = "resetPWLink";
            this.resetPWLink.Size = new System.Drawing.Size(84, 13);
            this.resetPWLink.TabIndex = 5;
            this.resetPWLink.TabStop = true;
            this.resetPWLink.Text = "Reset Password";
            this.resetPWLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetPWLink_LinkClicked);
            // 
            // newuserlinkLabel
            // 
            this.newuserlinkLabel.AutoSize = true;
            this.newuserlinkLabel.Location = new System.Drawing.Point(50, 178);
            this.newuserlinkLabel.Name = "newuserlinkLabel";
            this.newuserlinkLabel.Size = new System.Drawing.Size(126, 13);
            this.newuserlinkLabel.TabIndex = 6;
            this.newuserlinkLabel.TabStop = true;
            this.newuserlinkLabel.Text = "Create a New User Here!";
            this.newuserlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewuserlinkLabel_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "HP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newuserlinkLabel);
            this.Controls.Add(this.resetPWLink);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLable);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.userNameField);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label userNameLable;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.LinkLabel resetPWLink;
        private System.Windows.Forms.LinkLabel newuserlinkLabel;
        private System.Windows.Forms.Button button1;
    }
}

